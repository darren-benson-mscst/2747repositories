using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace dbenson2747ex2c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void version1Button_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            //Create SqlConnection
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = this.connectionStringTextBox.Text; //set the connection string

            //Create SqlCommand
            SqlCommand selectCommand = new SqlCommand();
            string sqlText = "SELECT BusinessEntityID, AccountNumber, Name,"
                + "CreditRating, PreferredVendorStatus, ActiveFlag "
                + "FROM Purchasing.Vendor ORDER BY Name";
            selectCommand.CommandText = sqlText; //set the command text
            selectCommand.Connection = connection; // set the connection

            ArrayList stringList = new ArrayList();

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(); //execute the command
                if (reader.HasRows) // check to see if reader has rows
                {
                    while (reader.Read()) // if there are rows, go ahead and read from reader
                    {              
                        string vendor = reader.GetInt32(0).ToString()
                            + " " + reader.GetString(2);
                        stringList.Add(vendor);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sql Server error:" + 
                    ex.Message, ex.GetType().ToString());
            }
            finally
            {
                connection.Close();
            }

            //bind arraylist to the list box
            listBox1.DataSource = stringList;              
        }

        private void version2Button_Click(object sender, EventArgs e)
        {
            listBox2.DataSource = null;
            listBox2.Items.Clear();

            //Connection string builder
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "(LocalDB)\\MSSQLLocalDB";
            builder.AttachDBFilename = fileNameTextBox.Text;
            builder.IntegratedSecurity = true;

            //Create SqlConnection
            SqlConnection connection = new SqlConnection(builder.ConnectionString); // pass the stringbuilder to the connection object
            

            //Create SqlCommand
            SqlCommand selectCommand = new SqlCommand();
            string sqlText = "SELECT BusinessEntityID, AccountNumber, Name,"
                + "CreditRating, PreferredVendorStatus, ActiveFlag, ModifiedDate "
                + "FROM Purchasing.Vendor ORDER BY Name";
            selectCommand.CommandText = sqlText; //set the command text
            selectCommand.Connection = connection; // set the connection

            List<Vendor> vendorList = new List<Vendor>();

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(); //execute the command
                if (reader.HasRows) // check to see if reader has rows
                {
                    while (reader.Read()) // if there are rows, go ahead and read from reader
                    {
                        int businessEntityID = reader.GetInt32(
                            reader.GetOrdinal("BusinessEntityID"));
                        string accountNumber = reader.GetString(
                            reader.GetOrdinal("AccountNumber"));
                        string name = reader.GetString(
                            reader.GetOrdinal("Name"));
                        short creditRating = reader.GetByte(
                            reader.GetOrdinal("CreditRating"));
                        bool preferredVendorStatus = reader.GetBoolean(
                            reader.GetOrdinal("PreferredVendorStatus"));
                        bool activeFlag = reader.GetBoolean(
                            reader.GetOrdinal("ActiveFlag"));
                        System.DateTime modifiedDate = reader.GetDateTime(
                            reader.GetOrdinal("ModifiedDate"));

                        //create the vendor
                        Vendor vendor = new Vendor(
                            businessEntityID, accountNumber, name,
                            creditRating, preferredVendorStatus, activeFlag,
                            modifiedDate);
                                                   
                        vendorList.Add(vendor);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sql Server error:" +
                    ex.Message, ex.GetType().ToString());
            }
            finally
            {
                connection.Close();
            }

            //bind arraylist to the list box
            listBox2.DataSource = vendorList;
            listBox2.DisplayMember = "LongString";
            listBox2.ValueMember = "BusinessEntityID";

        }

        private void version3Button_Click(object sender, EventArgs e)
        {
            this.vendorsListView1.Items.Clear();

            //Create SqlConnection
            SqlConnection connection = new SqlConnection(dbenson2747ex2c.Properties.Settings.Default.AdventureWorksConnectionString);
            this.connectionString3Label.Text = dbenson2747ex2c.Properties.Settings.Default.AdventureWorksConnectionString;

            //Create SqlCommand
            SqlCommand selectCommand = new SqlCommand();
            string sqlText = "SELECT BusinessEntityID, AccountNumber, Name,"
                + "CreditRating, PreferredVendorStatus, ActiveFlag, PurchasingWebServiceURL, ModifiedDate "
                + "FROM Purchasing.Vendor ORDER BY Name";
            selectCommand.CommandText = sqlText; //set the command text
            selectCommand.Connection = connection; // set the connection

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
                MessageBox.Show("Sql Server error:" +
                    ex.Message, ex.GetType().ToString());
            }
            finally
            {
                connection.Close();
            }

            vendorsListView1.BeginUpdate();

           
            foreach (Vendor vend in vendorList)
            {
                ListViewItem item = new ListViewItem(vend.BusinessEntityID.ToString());
                item.SubItems.Add(vend.Name);
                item.SubItems.Add(vend.CreditRating.ToString());
                item.SubItems.Add(vend.PreferredVendorStatus.ToString());
                item.SubItems.Add(vend.ActiveFlag.ToString());
                item.SubItems.Add(vend.PurchasingWebServiceURL);
                item.SubItems.Add(vend.ModifiedDate.ToShortDateString());

                //add the item to the list view
                vendorsListView1.Items.Add(item);
            }
            
            vendorsListView1.EndUpdate();
        }

        private void version4Button_Click(object sender, EventArgs e)
        {
            this.vendorsListView2.Items.Clear();
            List<Vendor> vendorList = new List<Vendor>();
            int activeFlagParameter = 0;
            if (activeRadioButton.Checked) activeFlagParameter = 1;

            try {
                 vendorList = VendorDB.getVendors(activeFlagParameter);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sql Server error:" +
                ex.Message, ex.GetType().ToString());                
            }

            vendorsListView2.BeginUpdate();

            foreach (Vendor vend in vendorList)
            {
                ListViewItem item = new ListViewItem(vend.BusinessEntityID.ToString());
                item.SubItems.Add(vend.Name);
                item.SubItems.Add(vend.CreditRating.ToString());
                item.SubItems.Add(vend.PreferredVendorStatus.ToString());
                item.SubItems.Add(vend.ActiveFlag.ToString());
                item.SubItems.Add(vend.PurchasingWebServiceURL);
                item.SubItems.Add(vend.ModifiedDate.ToShortDateString());

                //add the item to the list view
                vendorsListView2.Items.Add(item);
            }

            vendorsListView2.EndUpdate();
            vendorsSelectedLabel.Text = "Vendors Selected: " + " " + vendorList.Count.ToString();
        }

       

        private void vendorsListView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vendorsListView2.SelectedItems.Count > 0)
            {
                int vendID = Int32.Parse(vendorsListView2.SelectedItems[0].SubItems[0].Text);
                vendorIDLabel.Text = vendID.ToString();
                this.displayPurchaseOrders(vendID);
            }

            
        }

        private void displayPurchaseOrders(int selectedVendorID)
        {
            this.purchaseOrderListView.Items.Clear();
            List<PurchaseOrderHeader> purchaseOrderList = new List<PurchaseOrderHeader>();

            try
            {
                purchaseOrderList = PurchaseOrderDB.getPurchaseOrders(selectedVendorID);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sql Server error:" +
                ex.Message, ex.GetType().ToString());
            }

            purchaseOrderListView.BeginUpdate();

            foreach (PurchaseOrderHeader po in purchaseOrderList)
            {
                ListViewItem item = new ListViewItem(po.PurchaseOrderID.ToString());
                item.SubItems.Add(po.RevisionNumber.ToString());
                item.SubItems.Add(po.Status.ToString());
                item.SubItems.Add(po.EmployeeID.ToString());
                item.SubItems.Add(po.ShipMethodID.ToString());
                item.SubItems.Add(po.OrderDate.ToShortDateString());
                if(po.ShipDate != null)
                {
                    DateTime shipDate = (DateTime)po.ShipDate;
                    item.SubItems.Add(shipDate.ToShortDateString());
                }
                else
                {
                    item.SubItems.Add(string.Empty);
                } 
                item.SubItems.Add(po.SubTotal.ToString("C2"));
                item.SubItems.Add(po.TaxAmt.ToString("C2"));
                item.SubItems.Add(po.Freight.ToString("C2"));
                item.SubItems.Add(po.TotalDue.ToString("C2"));

                //add the item to the list view
                purchaseOrderListView.Items.Add(item);
            }

            purchaseOrderListView.EndUpdate();
            purchaseOrderCountLabel.Text = purchaseOrderList.Count.ToString();
        }
    }
}
