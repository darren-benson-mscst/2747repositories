using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace dbenson2747ex2e_dbmapper
{
    public class VendorDB
    {
        public static List<Vendor> getVendors()
        {
            //Create SqlConnection
            SqlConnection connection = new SqlConnection(dbenson2747ex2e_dbmapper.Properties.Settings.Default.AdventureWorksConnectionString);


            //Create SqlCommand
            SqlCommand selectCommand = new SqlCommand();           
            selectCommand.CommandText = "spEx2dSelectVendors";
            selectCommand.CommandType = System.Data.CommandType.StoredProcedure; // set command type to stored procedure
            selectCommand.Connection = connection; 
           
            List<Vendor> vendorList = new List<Vendor>();

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(); //execute the command
                if (reader.HasRows) // check to see if reader has rows
                {
                    int ordBusinessEntityID = reader.GetOrdinal("BusinessEntityID");
                    int ordAccountNumber = reader.GetOrdinal("AccountNumber");
                    int ordName = reader.GetOrdinal("Name");
                    int ordCreditRating = reader.GetOrdinal("CreditRating");
                    int ordPreferredVendorStatus = reader.GetOrdinal("PreferredVendorStatus");
                    int ordActiveFlag = reader.GetOrdinal("ActiveFlag");
                    int ordPurchasingWebServiceURL = reader.GetOrdinal("PurchasingWebServiceURL");
                    int ordModifiedDate = reader.GetOrdinal("ModifiedDate");

                    while (reader.Read()) // if there are rows, go ahead and read from reader
                    {
                        int businessEntityID = reader.GetInt32(ordBusinessEntityID);
                        string accountNumber = reader.GetString(ordAccountNumber);
                        string name = reader.GetString(ordName);
                        short creditRating = reader.GetByte(ordCreditRating);
                        bool preferredVendorStatus = reader.GetBoolean(ordPreferredVendorStatus);
                        bool activeFlag = reader.GetBoolean(ordActiveFlag);
                        string purchasingWebServiceURL = string.Empty;
                        if (!reader.IsDBNull(ordPurchasingWebServiceURL))
                        {
                            purchasingWebServiceURL = reader.GetString(ordPurchasingWebServiceURL);
                        }
                        System.DateTime modifiedDate = reader.GetDateTime(ordModifiedDate);

                        Address address = AddressDB.getAddress(businessEntityID);

                        //create the vendor
                        Vendor vendor = new Vendor(
                            businessEntityID, accountNumber, name,
                            creditRating, preferredVendorStatus, activeFlag,
                            purchasingWebServiceURL, modifiedDate, address);

                        vendorList.Add(vendor);
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

            return vendorList;
        }

        public static Vendor getVendor(int businessEntityID)
        {

            Vendor vendor = null;

            //Create SqlConnection
            SqlConnection connection = new SqlConnection(dbenson2747ex2e_dbmapper.Properties.Settings.Default.AdventureWorksConnectionString);


            //Create SqlCommand
            SqlCommand selectCommand = new SqlCommand();
            selectCommand.CommandText = "spEx2dSelectVendor";
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
                    int ordAccountNumber = reader.GetOrdinal("AccountNumber");
                    int ordName = reader.GetOrdinal("Name");
                    int ordCreditRating = reader.GetOrdinal("CreditRating");
                    int ordPreferredVendorStatus = reader.GetOrdinal("PreferredVendorStatus");
                    int ordActiveFlag = reader.GetOrdinal("ActiveFlag");
                    int ordPurchasingWebServiceURL = reader.GetOrdinal("PurchasingWebServiceURL");
                    int ordModifiedDate = reader.GetOrdinal("ModifiedDate");

                    if (reader.Read()) // if there are rows, go ahead and read from reader
                    {
                        //int businessEntityID = reader.GetInt32(ordBusinessEntityID);
                        string accountNumber = reader.GetString(ordAccountNumber);
                        string name = reader.GetString(ordName);
                        short creditRating = reader.GetByte(ordCreditRating);
                        bool preferredVendorStatus = reader.GetBoolean(ordPreferredVendorStatus);
                        bool activeFlag = reader.GetBoolean(ordActiveFlag);
                        string purchasingWebServiceURL = string.Empty;
                        if (!reader.IsDBNull(ordPurchasingWebServiceURL))
                        {
                            purchasingWebServiceURL = reader.GetString(ordPurchasingWebServiceURL);
                        }
                        System.DateTime modifiedDate = reader.GetDateTime(ordModifiedDate);

                        Address address = AddressDB.getAddress(businessEntityID);

                        //create the vendor
                         vendor = new Vendor(
                            businessEntityID, accountNumber, name,
                            creditRating, preferredVendorStatus, activeFlag,
                            purchasingWebServiceURL, modifiedDate, address);

                      
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

            return vendor;
        }

        public static Vendor updateVendor(Vendor vendor)
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
                    //Create the transaction object
                    AdventureWorksDbContext.transaction =
                        AdventureWorksDbContext.connection.BeginTransaction();
                }


                Address address = AddressDB.updateAddress(vendor.BusinessEntityID, vendor.Address);


                //Create SqlCommand
                SqlCommand updateCommand = new SqlCommand();
                updateCommand.CommandText = "spEx2dUpdateVendor";
                updateCommand.CommandType = System.Data.CommandType.StoredProcedure; // set command type to stored procedure
                //updateCommand.Connection = connection; // Ex2d
                updateCommand.Connection = AdventureWorksDbContext.connection; // Ex2e
                updateCommand.Transaction = AdventureWorksDbContext.transaction; // Ex2e
                SqlParameter businessEntityIDSqlParameter = new SqlParameter("@BusinessEntityID", vendor.BusinessEntityID);
                updateCommand.Parameters.Add(businessEntityIDSqlParameter);
                SqlParameter accountNumberSqlParameter = new SqlParameter("@AccountNumber", vendor.AccountNumber);
                updateCommand.Parameters.Add(accountNumberSqlParameter);
                SqlParameter nameSqlParameter = new SqlParameter("@Name", vendor.Name);
                updateCommand.Parameters.Add(nameSqlParameter);
                SqlParameter creditRatingSqlParameter = new SqlParameter("@CreditRating", vendor.CreditRating);
                updateCommand.Parameters.Add(creditRatingSqlParameter);
                SqlParameter prefVendorSqlParameter = new SqlParameter("@PreferredVendorStatus", vendor.PreferredVendorStatus);
                updateCommand.Parameters.Add(prefVendorSqlParameter);
                SqlParameter activeFlagSqlParameter = new SqlParameter("@ActiveFlag", vendor.ActiveFlag);
                updateCommand.Parameters.Add(activeFlagSqlParameter);
                SqlParameter modifiedDateSqlParameter = new SqlParameter("@ModifiedDate", vendor.ModifiedDate);
                updateCommand.Parameters.Add(modifiedDateSqlParameter);

                if (!vendor.PurchasingWebServiceURL.Equals(String.Empty))
                {
                    SqlParameter webServiceURLSqlParameter = 
                        new SqlParameter("@PurchasingWebServiceURL", vendor.PurchasingWebServiceURL);
                    updateCommand.Parameters.Add(webServiceURLSqlParameter);
                }
                else
                {
                    SqlParameter webServiceURLSqlParameter = 
                        new SqlParameter("@PurchasingWebServiceURL", (object)DBNull.Value);
                    updateCommand.Parameters.Add(webServiceURLSqlParameter);
                }

           
                //connection.Open(); // Ex2d
                //AdventureWorksDbContext.connection.Open(); // Ex2e -- connection is already open. No need to execute here.
                SqlDataReader reader = updateCommand.ExecuteReader(); //execute the command
                if (reader.HasRows) // check to see if reader has rows
                {
                    int ordBusinessEntityID = reader.GetOrdinal("BusinessEntityID");
                    int ordAccountNumber = reader.GetOrdinal("AccountNumber");
                    int ordName = reader.GetOrdinal("Name");
                    int ordCreditRating = reader.GetOrdinal("CreditRating");
                    int ordPreferredVendorStatus = reader.GetOrdinal("PreferredVendorStatus");
                    int ordActiveFlag = reader.GetOrdinal("ActiveFlag");
                    int ordPurchasingWebServiceURL = reader.GetOrdinal("PurchasingWebServiceURL");
                    int ordModifiedDate = reader.GetOrdinal("ModifiedDate");

                    if (reader.Read()) // if there are rows, go ahead and read from reader
                    {
                        int businessEntityID = reader.GetInt32(ordBusinessEntityID);
                        string accountNumber = reader.GetString(ordAccountNumber);
                        string name = reader.GetString(ordName);
                        short creditRating = reader.GetByte(ordCreditRating);
                        bool preferredVendorStatus = reader.GetBoolean(ordPreferredVendorStatus);
                        bool activeFlag = reader.GetBoolean(ordActiveFlag);
                        string purchasingWebServiceURL = string.Empty;
                        if (!reader.IsDBNull(ordPurchasingWebServiceURL))
                        {
                            purchasingWebServiceURL = reader.GetString(ordPurchasingWebServiceURL);
                        }
                        System.DateTime modifiedDate = reader.GetDateTime(ordModifiedDate);

                        //Address address = vendor.Address;

                        //create the vendor
                        vendor = new Vendor(
                           businessEntityID, accountNumber, name,
                           creditRating, preferredVendorStatus, activeFlag,
                           purchasingWebServiceURL, modifiedDate, address);

                    }
                }
                reader.Close();
                //committ the transaction
                AdventureWorksDbContext.transaction.Commit();
            }
            catch (Exception ex)
            {
                //attempt to roll back the transaction if there are errors
                try
                {
                    AdventureWorksDbContext.transaction.Rollback();
                }
                catch (Exception exRB)
                {
                    throw exRB;
                }
                
                throw ex;
            }
            finally
            {
                //connection.Close(); // Ex2d
                AdventureWorksDbContext.connection.Close(); //Ex2e
            }

            return vendor;
        }

        public static Vendor insertEmptyVendor()
        {

            Vendor vendor = null;
            
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
                    //Create the transaction object
                    AdventureWorksDbContext.transaction =
                        AdventureWorksDbContext.connection.BeginTransaction();
                }

                
               
                //Create SqlCommand
                SqlCommand insertCommand = new SqlCommand();               
                insertCommand.CommandText = "spEx2eInsertEmptyVendor";
                insertCommand.CommandType = System.Data.CommandType.StoredProcedure; // set command type to stored procedure                
                insertCommand.Connection = AdventureWorksDbContext.connection; // Ex2e
                insertCommand.Transaction = AdventureWorksDbContext.transaction; // Ex2e
                SqlParameter newBusinessEntityIDSqlParameter = new SqlParameter("@NewBusinessEntityID", System.Data.SqlDbType.Int);
                newBusinessEntityIDSqlParameter.Direction = System.Data.ParameterDirection.Output;
                insertCommand.Parameters.Add(newBusinessEntityIDSqlParameter);

                
                                
                SqlDataReader reader = insertCommand.ExecuteReader(); //execute the command
                if (reader.HasRows) // check to see if reader has rows
                {
                    int ordBusinessEntityID = reader.GetOrdinal("BusinessEntityID");
                    int ordAccountNumber = reader.GetOrdinal("AccountNumber");
                    int ordName = reader.GetOrdinal("Name");
                    int ordCreditRating = reader.GetOrdinal("CreditRating");
                    int ordPreferredVendorStatus = reader.GetOrdinal("PreferredVendorStatus");
                    int ordActiveFlag = reader.GetOrdinal("ActiveFlag");
                    int ordPurchasingWebServiceURL = reader.GetOrdinal("PurchasingWebServiceURL");
                    int ordModifiedDate = reader.GetOrdinal("ModifiedDate");

                    if (reader.Read()) // if there are rows, go ahead and read from reader
                    {
                        int businessEntityID = reader.GetInt32(ordBusinessEntityID);
                        string accountNumber = reader.GetString(ordAccountNumber);
                        string name = reader.GetString(ordName);
                        short creditRating = reader.GetByte(ordCreditRating);
                        bool preferredVendorStatus = reader.GetBoolean(ordPreferredVendorStatus);
                        bool activeFlag = reader.GetBoolean(ordActiveFlag);
                        string purchasingWebServiceURL = string.Empty;
                        if (!reader.IsDBNull(ordPurchasingWebServiceURL))
                        {
                            purchasingWebServiceURL = reader.GetString(ordPurchasingWebServiceURL);
                        }
                        System.DateTime modifiedDate = reader.GetDateTime(ordModifiedDate);

                        reader.Close(); // moved in Ex2e
                        Address address = AddressDB.insertEmptyAddress(businessEntityID);

                        //create the vendor
                        vendor = new Vendor(
                           businessEntityID, accountNumber, name,
                           creditRating, preferredVendorStatus, activeFlag,
                           purchasingWebServiceURL, modifiedDate, address);

                    }
                }
                //reader.Close();
                //committ the transaction
                AdventureWorksDbContext.transaction.Commit();
            }
            catch (Exception ex)
            {
                //attempt to roll back the transaction if there are errors
                try
                {
                    AdventureWorksDbContext.transaction.Rollback();
                }
                catch (Exception exRB)
                {
                    throw exRB;
                }

                throw ex;
            }
            finally
            {
                //connection.Close(); // Ex2d
                AdventureWorksDbContext.connection.Close(); //Ex2e
            }

            return vendor;
        }
    }

}