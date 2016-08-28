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
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();
        }

        private void storeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.storeBindingSource.EndEdit();
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

        private void StoreForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorksDataSet.Store' table. You can move, or remove it, as needed.
            try {
                this.storeTableAdapter.Fill(this.adventureWorksDataSet.Store);
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void storeBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
