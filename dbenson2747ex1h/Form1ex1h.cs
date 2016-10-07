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

namespace dbenson2747ex1h
{
    public partial class Form1ex1h : Form {

        private AdventureWorksDataSet.PurchaseOrderHeaderRow currentPOHeaderRow = null; //ex1h
    
        public Form1ex1h()
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

        //private void purchaseOrderHeaderBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        //{
        //    this.Validate();

        //    this.tableAdapterManager.UpdateAll(this.adventureWorksDataSet);

        //}

        private void Form1ex1h_Load(object sender, EventArgs e)
        {
          
            
            try
            {
                this.productTableAdapter.Fill(this.adventureWorksDataSet.Product);
                this.shipMethodTableAdapter.Fill(this.adventureWorksDataSet.ShipMethod);
                this.employeeNameTableAdapter.Fill(this.adventureWorksDataSet.EmployeeName);
                this.vendorTableAdapter.Fill(this.adventureWorksDataSet.Vendor);
                this.displayVendorCount();
                int vendorID = (Int32)vendorComboBox.SelectedValue;
                this.purchaseOrderHeaderTableAdapter.FillByVendorID(this.adventureWorksDataSet.PurchaseOrderHeader, vendorID);
                this.loadPODateRangeForCurrentVendor();

                this.loadPOHeadersForCurrentVendor();
                this.subscribeEventHandlers();

            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Form1ex1h_Load() " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Form1ex1h_Load() " + ex.GetType().ToString());
            }


        }

        private void vendorComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.unSubscribeEventHandlers();
            this.displayVendorCount();
            this.promptToSaveChanges();
            this.loadPODateRangeForCurrentVendor();
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

            //ex1h addition
            this.startDateTimePicker.ValueChanged
                += new System.EventHandler(this.dateRangeChanged);

            this.endDateTimePicker.ValueChanged
                += new System.EventHandler(this.dateRangeChanged);
        }

        private void unSubscribeEventHandlers()
        {
            this.vendorComboBox.SelectedValueChanged
                -= new System.EventHandler(this.vendorComboBox_SelectedValueChanged);

            this.purchaseOrderHeaderBindingSource.CurrentChanged
               -= new System.EventHandler(this.purchaseOrderHeaderBindingSource_CurrentChanged);

            this.purchaseOrderDetailDataGridView.CellValueChanged
                -= new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseOrderDetailDataGridView_CellValueChanged);

            //ex1h addition
            this.startDateTimePicker.ValueChanged
                -= new System.EventHandler(this.dateRangeChanged);

            this.endDateTimePicker.ValueChanged
                -= new System.EventHandler(this.dateRangeChanged);
        }

        private void displayVendorCount()
        {
            try {
                int vendorCount = (int)this.vendorTableAdapter.CountVendorsQuery();

                vendorCountLabel.Text = (vendorComboBox.Items.Count.ToString() + " selected of " + vendorCount.ToString() + " total vendors");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "displayVendorCount() " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "displayVendorCount() " + ex.GetType().ToString());
            }
        }

        private void loadPOHeadersForCurrentVendor()
        {
            try
            {
                int vendorID = (Int32)vendorComboBox.SelectedValue;
                //this.purchaseOrderHeaderTableAdapter.FillByVendorID(this.adventureWorksDataSet.PurchaseOrderHeader, vendorID);
                this.purchaseOrderHeaderTableAdapter.FillByVendorIDDateRange(
                    this.adventureWorksDataSet.PurchaseOrderHeader, vendorID, startDateTimePicker.Value, endDateTimePicker.Value);

                int poCount = (int)this.purchaseOrderHeaderTableAdapter.CountPurchaseOrdersByVendor(vendorID);
                this.totalOrdersLabel.Text = (purchaseOrderHeaderBindingSource.Count.ToString() + " selected of " + poCount.ToString() + " total orders");


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
                this.currentPOHeaderRow =
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

            Decimal freight = 0.0m;
            Decimal.TryParse(freightTextBox.Text, out freight);

            Decimal total = 0.0m;

            foreach (DataGridViewRow currentRow in purchaseOrderDetailDataGridView.Rows)
            {

                if (currentRow.Cells[3].Value != null && currentRow.Cells[6].Value != null)
                {

                    int orderQty = 0;
                    decimal unitPrice = 0m;
                    Int32.TryParse(currentRow.Cells[3].Value.ToString(), out orderQty);
                    Decimal.TryParse(currentRow.Cells[6].Value.ToString(), out unitPrice);
                    Decimal lineTotal = orderQty * unitPrice;

                    if (lineTotal > 0)
                    {
                        currentRow.Cells[8].Value = lineTotal.ToString("N2");
                        subTotal += lineTotal;

                    }
                }

                Decimal taxAmount = 0m;
                taxAmount = (subTotal * 0.08m);
                total = subTotal + freight + taxAmount;
                freightTextBox.Text = freight.ToString("N2");
                subTotalLabel1.Text = subTotal.ToString("N2");
                taxAmtLabel1.Text = taxAmount.ToString("N2");
                totalDueLabel1.Text = total.ToString("C2");

            }
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
            //ex1h updating the unbound tax amount field
            decimal taxAmt = 0m;
            Decimal.TryParse(this.taxAmtLabel1.Text, out taxAmt);
            this.currentPOHeaderRow.TaxAmt = taxAmt;

            this.Validate();
            this.purchaseOrderDetailDataGridView.EndEdit();
            this.purchaseOrderDetailBindingSource.EndEdit();
            this.purchaseOrderHeaderBindingSource.EndEdit();

            try
            {
                //this.tableAdapterManager.UpdateAll(this.adventureWorksDataSet);
                this.purchaseOrderHeaderTableAdapter.Update(this.adventureWorksDataSet);
                this.purchaseOrderDetailTableAdapter.Update(this.adventureWorksDataSet);
                
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


        private void totalDueLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1ex1h_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.promptToSaveChanges();
            this.unSubscribeEventHandlers();
        }

        private void purchaseOrderDetailDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataRowView currentDataRowView = (DataRowView)this.purchaseOrderHeaderBindingSource.Current;
            AdventureWorksDataSet.PurchaseOrderHeaderRow currentPOHeaderRow =
                (AdventureWorksDataSet.PurchaseOrderHeaderRow)currentDataRowView.Row;

            purchaseOrderDetailDataGridView.CurrentRow.Cells[0].Value = currentPOHeaderRow.PurchaseOrderID;
        }

        private void cityButton_Click(object sender, EventArgs e)
        {
            this.unSubscribeEventHandlers();
            this.promptToSaveChanges();
            this.adventureWorksDataSet.PurchaseOrderDetail.Clear();
            this.adventureWorksDataSet.PurchaseOrderHeader.Clear();
            try {
                this.vendorTableAdapter.FillByCity(
                    adventureWorksDataSet.Vendor, searchTextBox.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \nMessage: " + ex.Message,
                    "cityButton_Click(): " + ex.GetType().ToString());
            }
            this.loadPODateRangeForCurrentVendor();
            this.displayVendorCount();
            this.loadPOHeadersForCurrentVendor();
            this.subscribeEventHandlers();
        }

        private void stateButton_Click(object sender, EventArgs e)
        {
            this.unSubscribeEventHandlers();
            this.promptToSaveChanges();
            this.adventureWorksDataSet.PurchaseOrderDetail.Clear();
            this.adventureWorksDataSet.PurchaseOrderHeader.Clear();
            try
            {
                this.vendorTableAdapter.FillByState(
                    adventureWorksDataSet.Vendor, searchTextBox.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \nMessage: " + ex.Message,
                    "stateButton_Click(): " + ex.GetType().ToString());
            }
            this.loadPODateRangeForCurrentVendor();
            this.displayVendorCount();
            this.loadPOHeadersForCurrentVendor();
            this.subscribeEventHandlers();
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            this.unSubscribeEventHandlers();
            this.promptToSaveChanges();
            this.adventureWorksDataSet.PurchaseOrderDetail.Clear();
            this.adventureWorksDataSet.PurchaseOrderHeader.Clear();
            try
            {
                this.vendorTableAdapter.FillByName(
                    adventureWorksDataSet.Vendor, searchTextBox.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \nMessage: " + ex.Message,
                    "nameButton_Click(): " + ex.GetType().ToString());
            }
            this.loadPODateRangeForCurrentVendor();
            this.displayVendorCount();
            this.loadPOHeadersForCurrentVendor();
            this.subscribeEventHandlers();
        }

        private void loadAllButton_Click(object sender, EventArgs e)
        {
            this.unSubscribeEventHandlers();
            this.promptToSaveChanges();
            this.adventureWorksDataSet.PurchaseOrderDetail.Clear();
            this.adventureWorksDataSet.PurchaseOrderHeader.Clear();
            try
            {
                this.vendorTableAdapter.Fill(this.adventureWorksDataSet.Vendor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \nMessage: " + ex.Message,
                    "loadALLButton_Click(): " + ex.GetType().ToString());
            }
            this.loadPODateRangeForCurrentVendor();
            this.displayVendorCount();
            this.loadPOHeadersForCurrentVendor();
            this.subscribeEventHandlers();
        }

        private void loadPODateRangeForCurrentVendor()
        {

            int vendorID = (int)vendorComboBox.SelectedValue;


            this.startDateTimePicker.MaxDate = DateTime.Today;
            this.startDateTimePicker.MinDate = DateTime.Today;
            this.startDateTimePicker.Value = DateTime.Today;
            this.endDateTimePicker.MaxDate = DateTime.Today;
            this.endDateTimePicker.MinDate = DateTime.Today;
            this.endDateTimePicker.Value = DateTime.Today;

            try {

                this.startDateTimePicker.MinDate =
                    (DateTime)this.purchaseOrderHeaderTableAdapter.GetPOStartDateByVendor(vendorID);
                this.startDateTimePicker.MaxDate =
                    (DateTime)this.purchaseOrderHeaderTableAdapter.GetPOEndDateByVendor(vendorID);

                this.startDateTimePicker.Value = this.startDateTimePicker.MinDate;
                this.endDateTimePicker.MinDate = this.startDateTimePicker.MinDate;
                this.endDateTimePicker.MaxDate = this.startDateTimePicker.MaxDate;
                this.endDateTimePicker.Value = this.startDateTimePicker.MaxDate;
            }
            catch (System.InvalidOperationException ex)
            {
                //ignore
            }

            catch (System.NullReferenceException ex)
            {
                //Ignore
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: \nMessage: " + ex.Message,
                    "loadPODateRangeForCurrentVendor(): " + ex.GetType().ToString());
            }
        }

        private void dateRangeChanged(object sender, EventArgs e)
        {
            this.unSubscribeEventHandlers();
            //this.promptToSaveChanges();
            this.loadPOHeadersForCurrentVendor();
            this.subscribeEventHandlers();
        }
    }

}
