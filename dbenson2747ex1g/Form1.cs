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

namespace dbenson2747ex1g
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void purchaseOrderHeaderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {

                //this.tableAdapterManager.UpdateAll(this.adventureWorksDataSet);
                this.saveChanges();
                
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
            
            try
            {
                this.shipMethodTableAdapter.Fill(this.adventureWorksDataSet.ShipMethod);
                this.employeeNameTableAdapter.Fill(this.adventureWorksDataSet.EmployeeName);
                this.vendorTableAdapter.Fill(this.adventureWorksDataSet.Vendor);
                int vendorID = (Int32)vendorComboBox.SelectedValue;
                this.purchaseOrderHeaderTableAdapter.FillByVendorID(this.adventureWorksDataSet.PurchaseOrderHeader, vendorID);

                this.loadPOHeadersForCurrentVendor();
                this.subscribeEventHandlers();
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

            this.unSubscribeEventHandlers();
            this.promptToSaveChanges();
            this.loadPOHeadersForCurrentVendor();
            this.subscribeEventHandlers();
            
        }

        private void purchaseOrderHeaderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.unSubscribeEventHandlers();
            this.promptToSaveChanges();
            this.poHeaderChanged();
            this.subscribeEventHandlers();
        }

        private void purchaseOrderDetailDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            this.calcTotals();
        }

        private void subscribeEventHandlers()
        {
            
            this.vendorComboBox.SelectedValueChanged
                += new System.EventHandler(this.vendorComboBox_SelectedValueChanged);

            this.purchaseOrderHeaderBindingSource.CurrentChanged
                += new System.EventHandler(this.purchaseOrderHeaderBindingSource_CurrentChanged);

            this.purchaseOrderDetailDataGridView.CellValueChanged
                += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseOrderDetailDataGridView_CellValueChanged);
        }

        private void unSubscribeEventHandlers()
        {
            this.vendorComboBox.SelectedValueChanged
                -= new System.EventHandler(this.vendorComboBox_SelectedValueChanged);

            this.purchaseOrderHeaderBindingSource.CurrentChanged
                -= new System.EventHandler(this.purchaseOrderHeaderBindingSource_CurrentChanged);

            this.purchaseOrderDetailDataGridView.CellValueChanged
                -= new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseOrderDetailDataGridView_CellValueChanged);
        }



        private void loadPOHeadersForCurrentVendor()
        {
            try
            {
                int vendorID = (Int32)vendorComboBox.SelectedValue;
                this.purchaseOrderHeaderTableAdapter.FillByVendorID(this.adventureWorksDataSet.PurchaseOrderHeader, vendorID);

                this.poHeaderChanged();
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

        private void poHeaderChanged()
        {
            this.adventureWorksDataSet.PurchaseOrderDetail.Clear();

            try
            {
                DataRowView currentDataRowView = (DataRowView)purchaseOrderHeaderBindingSource.Current;
                AdventureWorksDataSet.PurchaseOrderHeaderRow currentPOHeaderRow =
                    (AdventureWorksDataSet.PurchaseOrderHeaderRow)currentDataRowView.Row;
                int purchaseOrderID = currentPOHeaderRow.PurchaseOrderID;
                this.purchaseOrderDetailTableAdapter.FillByPurchaseOrderID(this.adventureWorksDataSet.PurchaseOrderDetail, purchaseOrderID);
                this.calcTotals();
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

        private void calcTotals()
        {
            Decimal subTotal = 0m;
            Decimal taxAmount = 0m;
            Decimal freight = 0.0m;
            Decimal.TryParse(freightTextBox.Text, out freight);
            Decimal total = 0.0m;

            foreach (DataGridViewRow currentRow in purchaseOrderDetailDataGridView.Rows)
            {

                if (currentRow.Cells[3].Value != null && currentRow.Cells[5].Value !== null)
                {
                  
                    int orderQty = 0;
                    decimal unitPrice = 0m;
                    Int32.TryParse(currentRow.Cells[3].Value.ToString(), out orderQty);
                    Decimal.TryParse(currentRow.Cells[5].Value.ToString(), out unitPrice);
                    Decimal lineTotal = orderQty * unitPrice;

                    if (lineTotal > 0)
                    {
                        currentRow.Cells[7].Value = lineTotal.ToString("N2");
                        subTotal += lineTotal;

                    }
                }

                taxAmount = (subTotal * 0.08m);
                total = subTotal + freight + taxAmount;
                freightTextBox.Text = freight.ToString("N2");
                subTotalLabel1.Text = subTotal.ToString("N2");
                taxAmtLabel1.Text = taxAmount.ToString("N2");
                totalDueLabel1.Text = total.ToString("C2");
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.promptToSaveChanges();
            this.unSubscribeEventHandlers();
        }

        private void promptToSaveChanges()
        {
            this.Validate();
            this.purchaseOrderDetailDataGridView.EndEdit();
            this.purchaseOrderDetailBindingSource.EndEdit();
            this.purchaseOrderHeaderBindingSource.EndEdit();

            if (this.adventureWorksDataSet.HasChanges())
            {
                DialogResult saveChanges =
                MessageBox.Show("Save changes?", "Purchase Order Updates",
                MessageBoxButtons.OKCancel);

                if (saveChanges == DialogResult.OK)
                {
                    this.saveChanges();
                }
                else
                {
                    this.adventureWorksDataSet.RejectChanges();
                }
            }
        }

        private void saveChanges()
        {
            this.Validate();
            this.purchaseOrderDetailDataGridView.EndEdit();
            this.purchaseOrderDetailBindingSource.EndEdit();
            this.purchaseOrderHeaderBindingSource.EndEdit();

            try
            {
                this.tableAdapterManager.UpdateAll(this.adventureWorksDataSet);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: \nMessage: " + ex.Message,
                    "saveChanges(): " + ex.GetType().ToString());
            }
            catch (System.InvalidCastException ex)
            {
                MessageBox.Show("Error: \nMessage: " + ex.Message,
                    "saveChanges(): " + ex.GetType().ToString());
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Error: \nMessage: " + ex.Message,
                    "saveChanges(): " + ex.GetType().ToString());
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: \nMessage: " + ex.Message,
                    "saveChanges(): " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \nMessage: " + ex.Message,
                    "saveChanges(): " + ex.GetType().ToString());
            }
        }

        private void purchaseOrderDetailDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataRowView currentDataRowView = (DataRowView)this.purchaseOrderHeaderBindingSource.Current;
            AdventureWorksDataSet.PurchaseOrderHeaderRow currentPOHeaderRow =
                (AdventureWorksDataSet.PurchaseOrderHeaderRow)currentDataRowView.Row;

            purchaseOrderDetailDataGridView.CurrentRow.Cells[0].Value = currentPOHeaderRow.PurchaseOrderID;
        }
    }
}
