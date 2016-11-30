using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace dbenson2747ex2d_dbmapper
{
    public class AddressDB
    {


        public static dbenson2747ex2d_dbmapper.Address getAddress(int businessEntityID)
        {
            Address address = null;

            //Create SqlConnection
            SqlConnection connection = new SqlConnection(dbenson2747ex2d_dbmapper.Properties.Settings.Default.AdventureWorksConnectionString);


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

        public static dbenson2747ex2d_dbmapper.Address updateAddress(int businessEntityID, Address address)
        {
            
            //Create SqlConnection
            SqlConnection connection = new SqlConnection(dbenson2747ex2d_dbmapper.Properties.Settings.Default.AdventureWorksConnectionString);


            //Create SqlCommand
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.CommandText = "spEx2dUpdateAddress";
            updateCommand.CommandType = System.Data.CommandType.StoredProcedure; // set command type to stored procedure
            updateCommand.Connection = connection;
            SqlParameter businessEntityIDSqlParameter = new SqlParameter("@BusinessEntityID", address.BusinessEntityID);
            updateCommand.Parameters.Add(businessEntityIDSqlParameter);
            SqlParameter addressLine1SqlParameter = new SqlParameter("@AddressLine1", address.AddressLine1);
            updateCommand.Parameters.Add(addressLine1SqlParameter);
            if (!address.AddressLine2.Equals(String.Empty))
            {
                SqlParameter addressLine2SqlParameter = new SqlParameter("@AddressLine2", address.AddressLine2);
                updateCommand.Parameters.Add(addressLine2SqlParameter);
            }
            else
            {
                SqlParameter addressLine2SqlParameter = new SqlParameter("@AddressLine2", (object)DBNull.Value);
                updateCommand.Parameters.Add(addressLine2SqlParameter);
            }
            SqlParameter citySqlParameter = new SqlParameter("@City", address.City);
            updateCommand.Parameters.Add(citySqlParameter);
            SqlParameter stateProvinceIDSqlParameter = new SqlParameter("@StateProvinceID", address.StateProvinceID);
            updateCommand.Parameters.Add(stateProvinceIDSqlParameter);
            SqlParameter postalCodeSqlParameter = new SqlParameter("@PostalCode", address.PostalCode);
            updateCommand.Parameters.Add(postalCodeSqlParameter);
            SqlParameter modifiedDateSqlParameter = new SqlParameter("@ModifiedDate", address.ModifiedDate);
            updateCommand.Parameters.Add(modifiedDateSqlParameter);

            
           

            try
            {
                connection.Open();
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
    }
}