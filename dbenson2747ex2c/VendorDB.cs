using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dbenson2747ex2c
{
    public class VendorDB
    {
        public static List<Vendor> getVendors(int actFlagParameter)
        {
            //Create SqlConnection
            SqlConnection connection = new SqlConnection(dbenson2747ex2c.Properties.Settings.Default.AdventureWorksConnectionString);


            //Create SqlCommand
            SqlCommand selectCommand = new SqlCommand();
            string sqlText = "SELECT BusinessEntityID, AccountNumber, Name,"
                + "CreditRating, PreferredVendorStatus, ActiveFlag, PurchasingWebServiceURL, ModifiedDate "
                + "FROM Purchasing.Vendor WHERE ActiveFlag = @ActiveFlag ORDER BY Name";
            selectCommand.CommandText = sqlText; //set the command text
            selectCommand.Connection = connection; // set the connection

            //create SQL parameter
            SqlParameter activeFlagParameter = new SqlParameter("@ActiveFlag", actFlagParameter);
            selectCommand.Parameters.Add(activeFlagParameter);

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

                        //create the vendor
                        Vendor vendor = new Vendor(
                            businessEntityID, accountNumber, name,
                            creditRating, preferredVendorStatus, activeFlag,
                            purchasingWebServiceURL, modifiedDate);

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
    }
}