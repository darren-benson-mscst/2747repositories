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

namespace dbenson2747ex1b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vendorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendorBindingSource.EndEdit();
            try {
                this.tableAdapterManager.UpdateAll(this.adventureWorksDataSet);
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Error Message: " + ex.Message,
                   "\vendorBindingNavigatorSaveButton_Click: " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message,
                    "\vendorBindingNavigatorSaveButton_Click: " + ex.GetType().ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorksDataSet.Vendor' table. You can move, or remove it, as needed.
            try {
                this.vendorTableAdapter.Fill(this.adventureWorksDataSet.Vendor);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Form1_Load() " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Form1_Load() " + ex.GetType().ToString());
            }
        }

        private void vendorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vendorBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonVendorDetails_Click(object sender, EventArgs e)
        {
            VendorDetailsForm vendorDetails = new VendorDetailsForm();
            vendorDetails.Show();
        }

        private void buttonStoreDetails_Click(object sender, EventArgs e)
        {
            StoreForm storeForm = new StoreForm();
            storeForm.Show();
        }

        private void vendorDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e )
        {
            MessageBox.Show(e.Exception.Message,
                "vendorDataGridView_DataError(): " + e.Exception.GetType().ToString());
        }
    }
}
