using dbenson2747ex3a_ef.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbenson2747ex3a
{
    public partial class Form1 : Form
    {        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            loadControls();
            this.vendorComboBox.SelectedIndexChanged 
                += new System.EventHandler(this.vendorComboBox_SelectedIndexChanged);
        }

        private void loadControls()
        {
            List<ShipMethod> shipMethodList = new List<ShipMethod>();
           
            try
            {
                this.shipMethodComboBox.DataSource = Company.getShipMethod();
                this.shipMethodComboBox.ValueMember = "ShipMethodID";
                this.shipMethodComboBox.DisplayMember = "Name";

                this.vendorComboBox.DataSource = Company.getVendors();
                this.vendorComboBox.ValueMember = null;
                this.vendorComboBox.DisplayMember = "Name";
                this.vendorComboBox.SelectedIndex = 1;

                this.employeeComboBox.DataSource = Company.getEmployees();
                this.employeeComboBox.ValueMember = "BusinessEntityID";
                this.employeeComboBox.DisplayMember = "LastFirstName";

                this.vendorComboBox_SelectedIndexChanged(null, null);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void vendorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vendor vendor = (Vendor)vendorComboBox.SelectedValue;

            try
            {
                this.purchaseOrderHeaderBindingSource.DataSource =
                    vendor.PurchaseOrderHeaders.ToList(); // Uses EF lazy loading
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \nMessage: " + ex.Message,
                    "vendorComboBox_SelectedIndexChanged(): " + ex.GetType().ToString());
            }
        }

        private void purchaseOrderHeaderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            PurchaseOrderHeader currentPOHeader = (PurchaseOrderHeader)purchaseOrderHeaderBindingSource.Current;

            try
            {
                this.purchaseOrderDetailBindingSource.DataSource =
                    currentPOHeader.PurchaseOrderDetails.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \nMessage: " + ex.Message,
                    "purchaseOrderHeaderBindingSource_CurrentChanged(): " + ex.GetType().ToString());
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int countChanges = Company.saveChanges();
                MessageBox.Show("Changes Saved:" + countChanges.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \nMessage: " + ex.Message,
                    "purchaseOrderHeaderBindingSource_CurrentChanged(): " + ex.GetType().ToString());
            }
        }
    }
}
