using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace dbenson2747ex2c
{
    public class PurchaseOrderDB
    {
        public static List<PurchaseOrderHeader> getPurchaseOrders(int selectedVendorID)
        {
            //Create SqlConnection
            SqlConnection connection = new SqlConnection(dbenson2747ex2c.Properties.Settings.Default.AdventureWorksConnectionString);


            //Create SqlCommand
            SqlCommand selectCommand = new SqlCommand();
            string sqlText = "SELECT PurchaseOrderID, RevisionNumber, Status,"
                + "EmployeeID, VendorID, ShipMethodID, OrderDate, ShipDate, "
                + "SubTotal, TaxAmt, Freight, TotalDue, ModifiedDate "
                + "FROM Purchasing.PurchaseOrderHeader WHERE VendorID = @VendorID "
                + "ORDER BY PurchaseOrderID";
            selectCommand.CommandText = sqlText; //set the command text
            selectCommand.Connection = connection; // set the connection


            //Create SQL parameter
            SqlParameter inputVendorID = new SqlParameter("@VendorID", selectedVendorID);
            selectCommand.Parameters.Add(inputVendorID);

            List<PurchaseOrderHeader> purchaseOrderList = new List<PurchaseOrderHeader>();

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(); //execute the command
                if (reader.HasRows) // check to see if reader has rows
                {
                    int ordPurchaseOrderID = reader.GetOrdinal("PurchaseOrderID");
                    int ordRevisionNumber = reader.GetOrdinal("RevisionNumber");
                    int ordStatus = reader.GetOrdinal("Status");
                    int ordEmployeeID = reader.GetOrdinal("EmployeeID");
                    int ordShipMethodID = reader.GetOrdinal("ShipMethodID");
                    int ordOrderDate = reader.GetOrdinal("OrderDate");
                    int ordShipDate = reader.GetOrdinal("ShipDate");
                    int ordSubTotal = reader.GetOrdinal("SubTotal");
                    int ordTaxAmt = reader.GetOrdinal("TaxAmt");
                    int ordFreight = reader.GetOrdinal("Freight");
                    int ordTotalDue = reader.GetOrdinal("TotalDue");

                    while (reader.Read()) // if there are rows, go ahead and read from reader
                    {
                        int purchaseOrderID = reader.GetInt32(ordPurchaseOrderID);
                        int revisionNumber = reader.GetByte(ordRevisionNumber);
                        int status = reader.GetByte(ordStatus);
                        int employeeID = reader.GetInt32(ordEmployeeID);
                        int shipMethodID = reader.GetInt32(ordShipMethodID);
                        DateTime orderDate = reader.GetDateTime(ordOrderDate);
                        DateTime? shipDate = null;
                        if (!reader.IsDBNull(ordShipDate))
                            shipDate = reader.GetDateTime(ordShipDate);
                        decimal subTotal = reader.GetDecimal(ordSubTotal);
                        decimal taxAmt = reader.GetDecimal(ordTaxAmt);
                        decimal freight = reader.GetDecimal(ordFreight);
                        decimal totalDue = reader.GetDecimal(ordTotalDue);
                       

                        //create the vendor
                        PurchaseOrderHeader vendor = new PurchaseOrderHeader(
                            purchaseOrderID, revisionNumber, status,
                            employeeID, shipMethodID, orderDate,
                            shipDate, subTotal, taxAmt, freight, totalDue);

                        purchaseOrderList.Add(vendor);
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

            return purchaseOrderList;
        }
    }
}