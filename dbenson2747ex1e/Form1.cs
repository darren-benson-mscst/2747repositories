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

namespace dbenson2747ex1e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void purchaseOrderDetailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try {
                this.purchaseOrderDetailBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.adventureWorksDataSet);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: \nMessage: " + ex.Message,
                    "purchaseOrderHeaderBindingNavigatorSaveItem_Click(): " + ex.GetType().ToString());
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Error Message: " + ex.Message,
                   "purchaseOrderHeaderBindingNavigatorSaveItem_Click(): " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message,
                    "purchaseOrderHeaderBindingNavigatorSaveItem_Click(): " + ex.GetType().ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                this.purchaseOrderHeaderTableAdapter.Fill(this.adventureWorksDataSet.PurchaseOrderHeader);
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

        private void purchaseOrderHeaderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try {
                DataRowView currentDataRowView = (DataRowView)purchaseOrderHeaderBindingSource.Current;
                AdventureWorksDataSet.PurchaseOrderHeaderRow currentPOHeaderRow =
                    (AdventureWorksDataSet.PurchaseOrderHeaderRow)currentDataRowView.Row;
                int purchaseOrderID = currentPOHeaderRow.PurchaseOrderID;
                this.purchaseOrderDetailTableAdapter.FillByPurchaseOrderID(this.adventureWorksDataSet.PurchaseOrderDetail, purchaseOrderID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
