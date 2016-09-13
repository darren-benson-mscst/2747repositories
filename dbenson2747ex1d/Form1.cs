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

namespace dbenson2747ex1d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try {
                this.productBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.adventureWorks2014_DataDataSet);
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

        private void FormatProductNumber(object sender, ConvertEventArgs e)
        {
            if (e.DesiredType != typeof(string)) return;

            string prodNum = e.Value.ToString();
            if (prodNum.Length > 5)
            {
                prodNum = prodNum.Replace("-", string.Empty);
                prodNum = prodNum.Substring(0, 3) + "." + prodNum.Substring(3, 2) + "." + prodNum.Substring(5);
                e.Value = prodNum;
            }

        }

        private void UnFormatProductNumber(object sender, ConvertEventArgs e)
        {
            if (e.DesiredType != typeof(string)) return;

            e.Value = e.Value.ToString().Replace(".", string.Empty);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

            try
            {
                this.productCatSubcatTableAdapter.Fill(this.adventureWorks2014_DataDataSet.ProductCatSubcat);
                this.unitMeasureTableAdapter.Fill(this.adventureWorks2014_DataDataSet.UnitMeasure);
                this.productTableAdapter.Fill(this.adventureWorks2014_DataDataSet.Product);
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
            Binding b = new Binding
                ("Text", productBindingSource, "ProductNumber");

            b.Format += new ConvertEventHandler(FormatProductNumber);
            b.Parse += new ConvertEventHandler(UnFormatProductNumber);
            productNumberTextBox.DataBindings.Add(b);
        }

        private void productBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void moveFirstButton_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveFirst();
            productPositionTextButton.Text = (productBindingSource.Position + 1).ToString();
            productPositionLabel.Text = "of " + productBindingSource.Count;
            try
            {
                DataRowView currentDataRowView = (DataRowView)productBindingSource.Current;
                AdventureWorks2014_DataDataSet.ProductRow currentProductRow =
                    (AdventureWorks2014_DataDataSet.ProductRow)currentDataRowView.Row;
                int productID = currentProductRow.ProductID;
                this.productInventoryLocationTableAdapter.FillByProductID(
                   this.adventureWorks2014_DataDataSet.ProductInventoryLocation, productID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void movePreviousButton_Click(object sender, EventArgs e)
        {
            productBindingSource.MovePrevious();
            productPositionTextButton.Text = (productBindingSource.Position + 1).ToString();
            productPositionLabel.Text = "of " + productBindingSource.Count;
            try
            {
                DataRowView currentDataRowView = (DataRowView)productBindingSource.Current;
                AdventureWorks2014_DataDataSet.ProductRow currentProductRow =
                    (AdventureWorks2014_DataDataSet.ProductRow)currentDataRowView.Row;
                int productID = currentProductRow.ProductID;
                this.productInventoryLocationTableAdapter.FillByProductID(
                    this.adventureWorks2014_DataDataSet.ProductInventoryLocation, productID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void moveNextButton_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveNext();
            productPositionTextButton.Text = (productBindingSource.Position + 1).ToString();
            productPositionLabel.Text = "of " + productBindingSource.Count;
            try
            {
                DataRowView currentDataRowView = (DataRowView)productBindingSource.Current;
                AdventureWorks2014_DataDataSet.ProductRow currentProductRow =
                    (AdventureWorks2014_DataDataSet.ProductRow)currentDataRowView.Row;
                int productID = currentProductRow.ProductID;
                this.productInventoryLocationTableAdapter.FillByProductID(
                    this.adventureWorks2014_DataDataSet.ProductInventoryLocation, productID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void moveLastButton_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveLast();
            productPositionTextButton.Text = (productBindingSource.Position + 1).ToString();
            productPositionLabel.Text = "of " + productBindingSource.Count;
            try
            {
                DataRowView currentDataRowView = (DataRowView)productBindingSource.Current;
                AdventureWorks2014_DataDataSet.ProductRow currentProductRow =
                    (AdventureWorks2014_DataDataSet.ProductRow)currentDataRowView.Row;
                int productID = currentProductRow.ProductID;
                this.productInventoryLocationTableAdapter.FillByProductID(
                    this.adventureWorks2014_DataDataSet.ProductInventoryLocation, productID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void moveProductPositionButton_Click(object sender, EventArgs e)
        {
            int position = 0;
            Int32.TryParse(productPositionTextButton.Text.Trim(), out position);
            position--;
            if (position >= 0 && position < productBindingSource.Count)
            {
                productBindingSource.Position = position;
            }
            else
            {
                MessageBox.Show("Invalid row number. \nEnter a value from 1 to " + productBindingSource.Count);
                productPositionTextButton.Focus();
                productPositionTextButton.SelectAll(); 
            }
            productPositionLabel.Text = "of " + productBindingSource.Count;
            try
            {
                DataRowView currentDataRowView = (DataRowView)productBindingSource.Current;
                AdventureWorks2014_DataDataSet.ProductRow currentProductRow =
                    (AdventureWorks2014_DataDataSet.ProductRow)currentDataRowView.Row;
                int productID = currentProductRow.ProductID;
                this.productInventoryLocationTableAdapter.FillByProductID(
                    this.adventureWorks2014_DataDataSet.ProductInventoryLocation, productID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            productPositionTextButton.Text = (productBindingSource.Position + 1).ToString();
            productPositionLabel.Text = "of " + productBindingSource.Count;

            try
            {
                
                DataRowView currentDataRowView = (DataRowView)productBindingSource.Current;
                AdventureWorks2014_DataDataSet.ProductRow currentProductRow =
                    (AdventureWorks2014_DataDataSet.ProductRow)currentDataRowView.Row;
                int productID = currentProductRow.ProductID;
                this.productInventoryLocationTableAdapter.FillByProductID(
                    this.adventureWorks2014_DataDataSet.ProductInventoryLocation, productID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void productIDToolStripButton_Click(object sender, EventArgs e)
        {
            try {
                int productID = Convert.ToInt32(productIDToolStripTextBox.Text);
                this.productTableAdapter.FillByProductID(this.adventureWorks2014_DataDataSet.Product, productID);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("VendorID must be an integer.", "Entry Error");
            }
            catch (System.InvalidCastException ex)
            {
                MessageBox.Show("VendorID must be an integer.", "Entry Error");
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

        private void loadAllToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.Fill(this.adventureWorks2014_DataDataSet.Product);
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

        private void productNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = productNameToolStripTextBox.Text.Trim().ToLower();
                this.productTableAdapter.FillByProductName(this.adventureWorks2014_DataDataSet.Product, productName);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("VendorID must be an integer.", "Entry Error");
            }
            catch (System.InvalidCastException ex)
            {
                MessageBox.Show("VendorID must be an integer.", "Entry Error");
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

        private void consoleEditToolStripButton_Click(object sender, EventArgs e)
        {
            productBindingSource.CancelEdit();
        }

     
    }
}
