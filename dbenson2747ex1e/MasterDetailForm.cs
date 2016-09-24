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
    public partial class MasterDetailForm : Form
    {
        public MasterDetailForm()
        {
            InitializeComponent();
        }

        private void purchaseOrderHeaderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try {
                //used to ensure that both tables save correctly if changes are made
                this.purchaseOrderDetailBindingSource.EndEdit();
                this.purchaseOrderHeaderBindingSource.EndEdit();
                this.purchaseOrderDetailTableAdapter.Update(this.adventureWorksDataSet.PurchaseOrderDetail);
                this.purchaseOrderHeaderTableAdapter.Update(this.adventureWorksDataSet.PurchaseOrderHeader);
                //this.tableAdapterManager.UpdateAll(this.adventureWorksDataSet);
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

        private void MasterDetailForm_Load(object sender, EventArgs e)
        {
            
            try
            {
                this.employeeNameTableAdapter.Fill(this.adventureWorksDataSet.EmployeeName);
                this.shipMethodTableAdapter.Fill(this.adventureWorksDataSet.ShipMethod);
                this.vendorTableAdapter.Fill(this.adventureWorksDataSet.Vendor);
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "MasterDetailForm_Load() " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "MasterDetailForm_Load() " + ex.GetType().ToString());
            }
        }

        private void vendorComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try {
                int vendorID = (Int32)vendorComboBox.SelectedValue;
                this.purchaseOrderHeaderTableAdapter.FillByVendorID(this.adventureWorksDataSet.PurchaseOrderHeader, vendorID);
                
            }
            catch (System.NullReferenceException ex)
            {
                //Ignore
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "vendorComboBox_SelectedValueChanged() " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "vendorComboBox_SelectedValueChanged() " + ex.GetType().ToString());
            }

        }

        private void purchaseOrderHeaderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView currentDataRowView = (DataRowView)purchaseOrderHeaderBindingSource.Current;
                AdventureWorksDataSet.PurchaseOrderHeaderRow currentPOHeaderRow =
                    (AdventureWorksDataSet.PurchaseOrderHeaderRow)currentDataRowView.Row;
                int purchaseOrderID = currentPOHeaderRow.PurchaseOrderID;
                this.purchaseOrderDetailTableAdapter.FillByPurchaseOrderID(this.adventureWorksDataSet.PurchaseOrderDetail, purchaseOrderID);
            }
            catch (System.NullReferenceException ex)
            {
                //Ignore
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "purchaseOrderHeaderBindingSource_CurrentChanged " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "purchaseOrderHeaderBindingSource_CurrentChanged " + ex.GetType().ToString());
            }
        }

        private void purchaseOrderDetailDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            rowCountBox.Text = string.Empty;
            rowIndexBox.Text = string.Empty;
            colIndexBox.Text = string.Empty;
            detailIDBox.Text = string.Empty;
            currentCellValBox.Text = string.Empty;

           if (purchaseOrderDetailDataGridView.RowCount > 1)
            {
                rowCountBox.Text = purchaseOrderDetailDataGridView.RowCount.ToString();
            }
            
            try {
                rowIndexBox.Text = purchaseOrderDetailDataGridView.CurrentCell.RowIndex.ToString();
                colIndexBox.Text = purchaseOrderDetailDataGridView.CurrentCell.ColumnIndex.ToString();
                DataGridViewRow currentRow = purchaseOrderDetailDataGridView.CurrentRow;
                DataGridViewCell cell1 = currentRow.Cells[0];
                int detailID = Convert.ToInt32(cell1.Value);
                detailIDBox.Text = detailID.ToString();

                switch (purchaseOrderDetailDataGridView.CurrentCell.ColumnIndex)
                {
                    case 0:
                    case 2:
                    case 3:
                    case 6:
                    case 7:
                    case 8:
                        int i = Convert.ToInt32(purchaseOrderDetailDataGridView.CurrentCell.Value);
                        currentCellValBox.Text = i.ToString();
                        break;
                    case 1:
                    case 9:
                        DateTime dateTime = (DateTime)purchaseOrderDetailDataGridView.CurrentCell.Value;
                        currentCellValBox.Text = dateTime.ToString();
                        break;
                    case 4:
                    case 5:
                        decimal d = Convert.ToDecimal(purchaseOrderDetailDataGridView.CurrentCell.Value);
                        currentCellValBox.Text = d.ToString("N2");
                        break;

                }
            }
            catch (System.InvalidCastException)
            {
                detailIDBox.Text = "Invalid Cast";
            }
            catch (System.NullReferenceException)
            {
                //ignore
            }


        }

        private void purchaseOrderDetailDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Decimal subTotal = 0m;
            foreach (DataGridViewRow currentRow in purchaseOrderDetailDataGridView.Rows)
            {
                Decimal lineTotal = 0m;
                lineTotal = Convert.ToInt32(currentRow.Cells[2].Value) * Convert.ToInt32(currentRow.Cells[4].Value);
                //currentRow.Cells[5].Value = lineTotal;  // lineTotal is read only.
                subTotal += lineTotal;
            }
            subTotalGridViewLabel.Text = subTotal.ToString("n2");
            Decimal tax = subTotal * 0.08m;
            taxGridViewLabel.Text = tax.ToString("n2");
            Decimal freight = 0m;
            decimal.TryParse(freightTextBox.Text, out freight);
            Decimal totalDue = subTotal + tax + freight;
            totalGridViewLabel.Text = totalDue.ToString("n2");
        }

        private void purchaseOrderDetailBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Decimal subTotal = 0m;
            for (int i = 0; i< purchaseOrderDetailBindingSource.Count; i++)
            {
                DataRowView currentDataRowView = (DataRowView)purchaseOrderDetailBindingSource.List[i];
                AdventureWorksDataSet.PurchaseOrderDetailRow detailRow =
                    (AdventureWorksDataSet.PurchaseOrderDetailRow)currentDataRowView.Row;
                subTotal += detailRow.OrderQty * detailRow.UnitPrice;
            }
            subTotalBindingSourceLabel.Text = subTotal.ToString("n2");
            Decimal tax = subTotal * 0.08m;
            taxBindingSourceLabel.Text = tax.ToString("n2");
            Decimal freight = 0m;
            decimal.TryParse(freightTextBox.Text, out freight);
            Decimal totalDue = subTotal + tax + freight;
            totalBindingSourceLabel.Text = totalDue.ToString("n2");
        }

        private void showForm1Button_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
