using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace dbenson2747ex2e_dbmapper
{
    public class AddressDB
    {


        public static dbenson2747ex2e_dbmapper.Address getAddress(int businessEntityID)
        {
            Address address = null;

            //Create SqlConnection
            SqlConnection connection = new SqlConnection(dbenson2747ex2e_dbmapper.Properties.Settings.Default.AdventureWorksConnectionString);


            //Create SqlCommand
            SqlCommand selectCommand = new SqlCommand();
            selectCommand.CommandText = "spEx2dSelectAddress";
            selectCommand.CommandType = System.Data.CommandType.StoredProcedure; // set command type to stored procedure
            selectCommand.Connection = connection;
            SqlParameter businessEntityIDSqlParameter = new SqlParameter("@BusinessEntityID", businessEntityID);
            selectCommand.Parameters.Add(businessEntityIDSqlParameter);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(); //execute the command
                if (reader.HasRows) // check to see if reader has rows
                {
                    int ordBusinessEntityID = reader.GetOrdinal("BusinessEntityID");
                    int ordAddressID = reader.GetOrdinal("AddressID");
                    int ordAddressLine1 = reader.GetOrdinal("AddressLine1");
                    int ordAddressLine2 = reader.GetOrdinal("AddressLine2");
                    int ordCity = reader.GetOrdinal("City");
                    int ordStateProvinceID = reader.GetOrdinal("StateProvinceID");
                    int ordPostalCode = reader.GetOrdinal("PostalCode");
                    int ordModifiedDate = reader.GetOrdinal("ModifiedDate");

                    if (reader.Read()) // if there are rows, go ahead and read from reader
                    {
                        //int businessEntityID = reader.GetInt32(ordBusinessEntityID);
                        int addressID = reader.GetInt32(ordAddressID);
                        string addressLine1 = reader.GetString(ordAddressLine1);
                        string addressLine2 = string.Empty;
                        if (!reader.IsDBNull(ordAddressLine2))
                             addressLine2 = reader.GetString(ordAddressLine2);
                        string city = reader.GetString(ordCity);
                        int stateProvinceID = reader.GetInt32(ordStateProvinceID);
                        string postalCode = reader.GetString(ordPostalCode);
                        System.DateTime modifiedDate = reader.GetDateTime(ordModifiedDate);

                        //create the address
                         address = new Address(businessEntityID,
                           addressID, addressLine1,
                           addressLine2, city, stateProvinceID,
                           postalCode, modifiedDate);


                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return address;
        }

        public static dbenson2747ex2e_dbmapper.Address updateAddress(int businessEntityID, Address address)
        {

            
            //SqlConnection connection = new SqlConnection(dbenson2747ex2e_dbmapper.Properties.Settings.Default.AdventureWorksConnectionString);

            //Create SqlConnection using static object //Ex2e
            if (AdventureWorksDbContext.connection == null)
            {
                AdventureWorksDbContext.connection =
                    new SqlConnection(dbenson2747ex2e_dbmapper.Properties.Settings.Default.AdventureWorksConnectionString);
            }
            //Test to see if the connection is closed. If it is closed, open it. //Ex2e
            try
            {
                if (AdventureWorksDbContext.connection.State == System.Data.ConnectionState.Closed)
                {
                    AdventureWorksDbContext.connection.Open();
                }
           
            
                //Create SqlCommand
                SqlCommand updateCommand = new SqlCommand();
                updateCommand.CommandText = "spEx2dUpdateAddress";
                updateCommand.CommandType = System.Data.CommandType.StoredProcedure; // set command type to stored procedure
                //updateCommand.Connection = connection;
                updateCommand.Connection = AdventureWorksDbContext.connection; // Ex2e
                updateCommand.Transaction = AdventureWorksDbContext.transaction; // Ex2e               
                updateCommand.Parameters.AddWithValue("@BusinessEntityID", address.BusinessEntityID);              
                updateCommand.Parameters.AddWithValue("@AddressLine1", address.AddressLine1);
                if (!address.AddressLine2.Equals(String.Empty))
                {                    
                    updateCommand.Parameters.AddWithValue("@AddressLine2", address.AddressLine2);
                }
                else
                {                    
                    updateCommand.Parameters.AddWithValue("@AddressLine2", (object)DBNull.Value);
                }                
                updateCommand.Parameters.AddWithValue("@City", address.City);                
                updateCommand.Parameters.AddWithValue("@StateProvinceID", address.StateProvinceID);               
                updateCommand.Parameters.AddWithValue("@PostalCode", address.PostalCode);                
                updateCommand.Parameters.AddWithValue("@ModifiedDate", address.ModifiedDate);

                                   
                //connection.Open(); //Ex2d
                //AdventureWorksDbContext.connection.Open(); //Ex2e -- connection is already open. No need to execute here.
                SqlDataReader reader = updateCommand.ExecuteReader(); //execute the command
                if (reader.HasRows) // check to see if reader has rows
                {
                    int ordBusinessEntityID = reader.GetOrdinal("BusinessEntityID");
                    int ordAddressID = reader.GetOrdinal("AddressID");
                    int ordAddressLine1 = reader.GetOrdinal("AddressLine1");
                    int ordAddressLine2 = reader.GetOrdinal("AddressLine2");
                    int ordCity = reader.GetOrdinal("City");
                    int ordStateProvinceID = reader.GetOrdinal("StateProvinceID");
                    int ordPostalCode = reader.GetOrdinal("PostalCode");
                    int ordModifiedDate = reader.GetOrdinal("ModifiedDate");

                    if (reader.Read()) // if there are rows, go ahead and read from reader
                    {
                        //int businessEntityID = reader.GetInt32(ordBusinessEntityID);
                        int addressID = reader.GetInt32(ordAddressID);
                        string addressLine1 = reader.GetString(ordAddressLine1);
                        string addressLine2 = string.Empty;
                        if (!reader.IsDBNull(ordAddressLine2))
                            addressLine2 = reader.GetString(ordAddressLine2);
                        string city = reader.GetString(ordCity);
                        int stateProvinceID = reader.GetInt32(ordStateProvinceID);
                        string postalCode = reader.GetString(ordPostalCode);
                        System.DateTime modifiedDate = reader.GetDateTime(ordModifiedDate);

                        //create the address
                        address = new Address(businessEntityID,
                          addressID, addressLine1,
                          addressLine2, city, stateProvinceID,
                          postalCode, modifiedDate);


                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            //finally
            //{
            //    //connection.Close(); //Ex2d
            //    AdventureWorksDbContext.connection.Close(); //Ex2e
            //}

            return address;
        }

        public static dbenson2747ex2e_dbmapper.Address insertEmptyAddress(int businessEntityID)
        {

            Address address = null;
            

            //Create SqlConnection using static object //Ex2e
            if (AdventureWorksDbContext.connection == null)
            {
                AdventureWorksDbContext.connection =
                    new SqlConnection(dbenson2747ex2e_dbmapper.Properties.Settings.Default.AdventureWorksConnectionString);
            }
            //Test to see if the connection is closed. If it is closed, open it. //Ex2e
            try
            {
                if (AdventureWorksDbContext.connection.State == System.Data.ConnectionState.Closed)
                {
                    AdventureWorksDbContext.connection.Open();
                }


                //Create SqlCommand
                SqlCommand insertCommand = new SqlCommand();
                insertCommand.CommandText = "spEx2eInsertEmptyAddress";
                insertCommand.CommandType = System.Data.CommandType.StoredProcedure; // set command type to stored procedure                
                insertCommand.Connection = AdventureWorksDbContext.connection; // Ex2e
                insertCommand.Transaction = AdventureWorksDbContext.transaction; // Ex2e   
                insertCommand.Parameters.AddWithValue("@BusinessEntityID", businessEntityID);            
                SqlParameter newAddressIDSqlParameter = new SqlParameter("@NewAddressID", System.Data.SqlDbType.Int);
                newAddressIDSqlParameter.Direction = System.Data.ParameterDirection.Output;
                insertCommand.Parameters.Add(newAddressIDSqlParameter);


                //connection.Open(); //Ex2d
                //AdventureWorksDbContext.connection.Open(); //Ex2e -- connection is already open. No need to execute here.
                //SqlDataReader reader = insertCommand.ExecuteReader(); //execute the command
                //if (reader.HasRows) // check to see if reader has rows
                //{
                //    int ordBusinessEntityID = reader.GetOrdinal("BusinessEntityID");
                //    int ordAddressID = reader.GetOrdinal("AddressID");
                //    int ordAddressLine1 = reader.GetOrdinal("AddressLine1");
                //    int ordAddressLine2 = reader.GetOrdinal("AddressLine2");
                //    int ordCity = reader.GetOrdinal("City");
                //    int ordStateProvinceID = reader.GetOrdinal("StateProvinceID");
                //    int ordPostalCode = reader.GetOrdinal("PostalCode");
                //    int ordModifiedDate = reader.GetOrdinal("ModifiedDate");

                //    if (reader.Read()) // if there are rows, go ahead and read from reader
                //    {
                //        //int businessEntityID = reader.GetInt32(ordBusinessEntityID);
                //        int addressID = reader.GetInt32(ordAddressID);
                //        string addressLine1 = reader.GetString(ordAddressLine1);
                //        string addressLine2 = string.Empty;
                //        if (!reader.IsDBNull(ordAddressLine2))
                //            addressLine2 = reader.GetString(ordAddressLine2);
                //        string city = reader.GetString(ordCity);
                //        int stateProvinceID = reader.GetInt32(ordStateProvinceID);
                //        string postalCode = reader.GetString(ordPostalCode);
                //        System.DateTime modifiedDate = reader.GetDateTime(ordModifiedDate);

                int rowCount = insertCommand.ExecuteNonQuery();
                int addressID = (int)newAddressIDSqlParameter.Value;
                        //create the address
                        address = new Address(
                          addressID, string.Empty,
                          string.Empty, string.Empty, 9,
                          string.Empty, DateTime.Now);              
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
            return address;
        }
    }
}