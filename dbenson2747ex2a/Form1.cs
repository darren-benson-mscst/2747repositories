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

namespace dbenson2747ex2a
{
    public partial class Form1 : Form
    {

        //private AdventureWorksDataSet adventureWorksDataSet;

        private AdventureWorksDataSetTableAdapters.VendorTableAdapter vendorTableAdapter;
        private AdventureWorksDataSet.VendorDataTable vendorDataTable;
        private AdventureWorksDataSet.VendorRow currentVendorRow;

        private AdventureWorksDataSetTableAdapters.BusinessEntityTableAdapter businessEntityTableAdapter;
        private AdventureWorksDataSet.BusinessEntityDataTable businessEntityDataTable;
        private AdventureWorksDataSet.BusinessEntityRow currentBusinessEntityRow;

        private AdventureWorksDataSetTableAdapters.BusinessEntityAddressTableAdapter businessEntityAddressTableAdapter;
        private AdventureWorksDataSet.BusinessEntityAddressDataTable businessEntityAddressDataTable;
        private AdventureWorksDataSet.BusinessEntityAddressRow currentBusinessEntityAddressRow;

        private AdventureWorksDataSetTableAdapters.AddressTableAdapter addressTableAdapter;
        private AdventureWorksDataSet.AddressDataTable addressDatatable;
        private AdventureWorksDataSet.AddressRow currentAddressRow;

        private int currentVendorPosition = -1;

        private string currentTextBoxText;
        private object previousSender;
        private bool addingNew;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.createDataObjects();
            this.loadStates();

            if (this.stateComboBox.Items.Count > 0)

                try {

                    this.vendorTableAdapter.Fill(this.vendorDataTable);
                    this.currentVendorPosition = 0;
                    this.currentVendorRow =
                        (AdventureWorksDataSet.VendorRow)vendorDataTable.Rows[currentVendorPosition];
                    this.loadCurrentVendorAddress();
                    this.setButtonsEnabled(true);
                    this.clearVendorControls();
                    this.displayVendor();
                }
                
                catch (System.NullReferenceException ex)
                {
                    //ignore
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



        private void createDataObjects()
        {
            //this.adventureWorksDataSet =
            //    new AdventureWorksDataSet();
            //((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).BeginInit();
            //this.adventureWorksDataSet.DataSetName = "AdventureWorksDataSet";
            //this.adventureWorksDataSet.SchemaSerializationMode =
            //    System.Data.SchemaSerializationMode.IncludeSchema;

            //Vendors
            //create the table adapter
            this.vendorTableAdapter =
                new AdventureWorksDataSetTableAdapters.VendorTableAdapter();
            this.vendorTableAdapter.ClearBeforeFill = true;
            //create the data table
            this.vendorDataTable =
                new AdventureWorksDataSet.VendorDataTable();

            //BusinessEntity
            //create the table adapter
            this.businessEntityTableAdapter =
                new AdventureWorksDataSetTableAdapters.BusinessEntityTableAdapter();
            this.businessEntityTableAdapter.ClearBeforeFill = true;
            //create the data table
            this.businessEntityDataTable = new AdventureWorksDataSet.BusinessEntityDataTable();

            //BusinessEntityAddress
            //create the table adapter
            this.businessEntityAddressTableAdapter =
                new AdventureWorksDataSetTableAdapters.BusinessEntityAddressTableAdapter();
            this.businessEntityAddressTableAdapter.ClearBeforeFill = true;
            //create the data table
            this.businessEntityAddressDataTable = new AdventureWorksDataSet.BusinessEntityAddressDataTable();

            //Address
            //create the table adapter
            this.addressTableAdapter =
                new AdventureWorksDataSetTableAdapters.AddressTableAdapter();
            this.addressTableAdapter.ClearBeforeFill = true;
            //create the data table
            this.addressDatatable = new AdventureWorksDataSet.AddressDataTable();
        }

        private void loadStates()
        {

            //StateProvinces
            //create the table adapter
            AdventureWorksDataSetTableAdapters.StateProvinceTableAdapter stateProvinceTableAdapter =
                new AdventureWorksDataSetTableAdapters.StateProvinceTableAdapter();
            stateProvinceTableAdapter.ClearBeforeFill = true;
            //create the data table
            AdventureWorksDataSet.StateProvinceDataTable stateProvinceDataTable =
                new AdventureWorksDataSet.StateProvinceDataTable();

            try
            {
                stateProvinceTableAdapter.Fill(stateProvinceDataTable);
                //binding to state combox box.. need to set 3 properties
                stateComboBox.DataSource = stateProvinceDataTable; // set data source
                stateComboBox.ValueMember = "StateProvinceID"; // set the value member
                stateComboBox.DisplayMember = "StateProvinceCode"; // set the display member               

            }
            catch (System.NullReferenceException ex)
            {
                //ignore
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "loadStates() " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "loadStates() " + ex.GetType().ToString());
            }
        }

        private void loadCurrentVendorAddress()
        {
            try
            {

                if (this.vendorDataTable.Count > 0)
                {
                    
                    this.businessEntityTableAdapter.FillByBusinessEntityID(
                            this.businessEntityDataTable, this.currentVendorRow.BusinessEntityID);
                    if (this.businessEntityDataTable.Count > 0)
                    {
                        this.currentBusinessEntityRow =
                             (AdventureWorksDataSet.BusinessEntityRow)businessEntityDataTable.Rows[0];
                        this.businessEntityAddressTableAdapter.FillByBusinessEntityID(
                            this.businessEntityAddressDataTable, this.currentBusinessEntityRow.BusinessEntityID);
                        if(this.businessEntityAddressDataTable.Count > 0)
                        {
                            this.currentBusinessEntityAddressRow =
                                (AdventureWorksDataSet.BusinessEntityAddressRow)this.businessEntityAddressDataTable.Rows[0];
                            this.addressTableAdapter.FillByAddressID(this.addressDatatable, this.currentBusinessEntityAddressRow.AddressID);                                   
                        }
                            if (this.addressDatatable.Count > 0)
                                {
                                 this.currentAddressRow =
                                    (AdventureWorksDataSet.AddressRow)addressDatatable.Rows[0];

                                }
                    }
                    this.setNavButtonEnabledToFalse();
                    this.clearVendorControls();
                    this.displayVendor();
                }
            }
            catch (System.NullReferenceException ex)
            {
                //ignore
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

        private void displayVendor()
        {
            
            //Display Vendor Fields
            this.vendorNameTextBox.Text = this.currentVendorRow.Name;
            this.businessEntityIDLabel.Text = this.currentVendorRow.BusinessEntityID.ToString();
            this.acctNumberTextBox.Text = this.currentVendorRow.AccountNumber;
            this.creditRatingComboBox.SelectedIndex = this.currentVendorRow.CreditRating - 1;
            this.preferredVendorCheckBox.Checked = this.currentVendorRow.PreferredVendorStatus;
            this.vendorActiveCheckBox.Checked = this.currentVendorRow.ActiveFlag;

            //Display Address Fields
            try {
                this.address1TextBox.Text = this.currentAddressRow.AddressLine1;
                if (this.currentAddressRow.IsAddressLine2Null())
                    this.address2TextBox.Text = string.Empty;
                else
                    this.address2TextBox.Text = this.currentAddressRow.AddressLine2;
                this.cityTextBox.Text = this.currentAddressRow.City;
                this.stateComboBox.SelectedValue = this.currentAddressRow.StateProvinceID;
                this.postalCodeTextBox.Text = this.currentAddressRow.PostalCode;
                this.addressModifiedDateTimePicker.Value = this.currentAddressRow.ModifiedDate;
                
                this.vendorNameTextBox.Focus();

            }
            catch (System.NullReferenceException ex)
            {
                //ignore
            }

            this.currentPositionLabel.Text = ((currentVendorPosition + 1) + " of" + vendorDataTable.Count.ToString());
            this.setButtonsEnabled(true);
            this.vendorNameTextBox.Focus();
        }

        private void clearVendorControls()
        {
            
            this.vendorNameTextBox.Text = string.Empty;
            this.businessEntityIDLabel.Text = string.Empty;
            this.acctNumberTextBox.Text = string.Empty;
            this.creditRatingComboBox.SelectedIndex = -1;
            this.preferredVendorCheckBox.Checked = false;
            this.vendorActiveCheckBox.Checked = false;

            //Display Address Fields

            this.address1TextBox.Text = string.Empty;
            //this.address2TextBox.Text = string.empty;
            this.cityTextBox.Text = string.Empty;
            this.stateComboBox.SelectedValue = -1;
            this.postalCodeTextBox.Text = string.Empty;
            
        }

        private void updateVendorAddressRows()
        {
            //Update vendor fields
            this.currentVendorRow.Name = this.vendorNameTextBox.Text;
            this.currentVendorRow.AccountNumber = this.acctNumberTextBox.Text;
            this.currentVendorRow.CreditRating = (byte)(this.creditRatingComboBox.SelectedIndex + 1);
            this.currentVendorRow.PreferredVendorStatus = this.preferredVendorCheckBox.Checked;
            this.currentVendorRow.ActiveFlag = this.vendorActiveCheckBox.Checked;

            //Update address fields
            this.currentAddressRow.BeginEdit();
            this.currentAddressRow.AddressLine1 = this.address1TextBox.Text;
            if (this.address2TextBox.Text.Trim().Equals(string.Empty))
                this.currentAddressRow.SetAddressLine2Null();
            else
                this.currentAddressRow.AddressLine2 = this.address2TextBox.Text;
            this.currentAddressRow.City = this.cityTextBox.Text;
            this.currentAddressRow.StateProvinceID = (int)(this.stateComboBox.SelectedValue);
            this.currentAddressRow.PostalCode = this.postalCodeTextBox.Text;

        }

        private void navButton_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "moveFirstButton":                   
                    this.currentVendorPosition = 0;                        
                    break;
                case "movePreviousButton":
                    this.currentVendorPosition -= 1;                  
                    break;
                case "moveNextButton":                   
                    this.currentVendorPosition +=  1;
                    break;
                case "moveLastButton":                   
                    this.currentVendorPosition = this.vendorDataTable.Count - 1;
                    break;
            }

            if (currentVendorPosition == 0)
            {
                
                this.currentVendorRow =
                 (AdventureWorksDataSet.VendorRow)vendorDataTable.Rows[currentVendorPosition];
                this.loadCurrentVendorAddress();
                if (this.currentAddressRow != null)
                {
                    this.setNavButtonEnabledToFalse();
                    this.displayVendor();
                }
               
            }
            else
            {
                
                this.currentVendorRow =
                 (AdventureWorksDataSet.VendorRow)vendorDataTable.Rows[currentVendorPosition];
                this.loadCurrentVendorAddress();
                if (this.currentAddressRow != null)
                {
                    this.setNavButtonEnabledToTrue();
                    this.displayVendor();
                }
               
            }

            if (currentVendorPosition == this.vendorDataTable.Count - 1)
            {
                
                this.currentVendorRow =
                 (AdventureWorksDataSet.VendorRow)vendorDataTable.Rows[currentVendorPosition];
                this.setNavButtonLastEnabledToFalse();
                this.displayVendor();
            }
            else
            {
               
                this.currentVendorRow =
                 (AdventureWorksDataSet.VendorRow)vendorDataTable.Rows[currentVendorPosition];
                this.setNavButtonLastEnabledToTrue();
                this.displayVendor();
            }

            

        }

        private void setNavButtonEnabledToFalse()
        {
            this.moveFirstButton.Enabled = false;
            this.movePreviousButton.Enabled = false;
        }

        private void setNavButtonEnabledToTrue()
        {
            this.moveFirstButton.Enabled = true;
            this.movePreviousButton.Enabled = true;
        }

        private void setNavButtonLastEnabledToFalse()
        {
            this.moveNextButton.Enabled = false;
            this.moveLastButton.Enabled = false;
        }

        private void setNavButtonLastEnabledToTrue()
        {
            this.moveNextButton.Enabled = true;
            this.moveLastButton.Enabled = true;
        }

        private void textBox_validateNull(object sender, CancelEventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;
            if (currentTextBox.Text.Trim().Equals(string.Empty))
            {
                currentTextBox.BackColor = Color.LightBlue;
                e.Cancel = true;
            }
            else
            {
                currentTextBox.BackColor = SystemColors.Window;
                e.Cancel = false;
            }
        }

       

        private void bufferCurrentText(object sender, EventArgs e)
        {
            if (sender != this.previousSender)
            {
                this.previousSender = sender;
                TextBox currentTextBox = (TextBox)sender;
                this.currentTextBoxText = currentTextBox.Text;
            }            
        }

        private void textBox_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                TextBox currentTextBox = (TextBox)sender;
                currentTextBox.Text = this.currentTextBoxText;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (vendorAddressCountrolsAreValid())
            {
                this.currentVendorRow.BeginEdit();
                this.currentAddressRow.BeginEdit();
                this.updateVendorAddressRows();
                this.currentVendorRow.EndEdit();
                this.currentAddressRow.EndEdit();

                try
                {
                    this.vendorTableAdapter.Update(this.vendorDataTable);
                    this.addressTableAdapter.Update(this.addressDatatable);
                    this.addingNew = false;
                    setButtonsEnabled(true);
                }
                catch (System.NullReferenceException ex)
                {
                    //ignore
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " +
                        "\nMessage: " + ex.Message,
                        "saveButton_Click() " + ex.GetType().ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " +
                        "\nMessage: " + ex.Message,
                        "saveButton_Click() " + ex.GetType().ToString());
                }
              }

                this.setButtonsEnabled(true);
            
            }

        private bool vendorAddressCountrolsAreValid()
        {
            bool controlsAreValid = true;
            

            return controlsAreValid;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (this.addingNew)
            {
                this.deleteButton_Click(null, null);
                this.addingNew = false;
            }
            else
            {
                this.clearVendorControls();
                this.displayVendor();
                MessageBox.Show("Update Cancelled", "Operation Cancelled");
            }            
        }

        private void controlValueChanged(object sender, EventArgs e)
        {
            
            this.setButtonsEnabled(false);
        }

        private void setButtonsEnabled(bool value)
        {
            this.moveFirstButton.Enabled = value;
            this.movePreviousButton.Enabled = value;
            this.moveNextButton.Enabled = value;
            this.moveLastButton.Enabled = value;
            this.deleteButton.Enabled = value;
            this.newButton.Enabled = value;

        }

        private void newButton_Click(object sender, EventArgs e)
        {

            //Create copies of the initial row values. Helpful incase anything blows up within the try block. Program can revert back to original data.
            AdventureWorksDataSet.BusinessEntityRow bakBusinessEntityRow =
                this.currentBusinessEntityRow;
            AdventureWorksDataSet.VendorRow bakVendorRow =
                this.currentVendorRow;
            AdventureWorksDataSet.AddressRow bakAddressRow =
                this.currentAddressRow;
            AdventureWorksDataSet.BusinessEntityAddressRow bakBusinessEntityAddressRow =
                this.currentBusinessEntityAddressRow;

            try {
                //Create the new row object
                this.currentBusinessEntityRow =
                    this.businessEntityDataTable.NewBusinessEntityRow();

                //Add the row to the data table
                this.businessEntityDataTable.AddBusinessEntityRow(this.currentBusinessEntityRow);

                //Use table adapter to perform the update
                int countNew = this.businessEntityTableAdapter.Update(this.businessEntityDataTable);

                //create the new row object
                this.currentVendorRow =
                    this.vendorDataTable.NewVendorRow();
                //initialize the fields
                this.currentVendorRow.BusinessEntityID = this.currentBusinessEntityRow.BusinessEntityID;
                this.currentVendorRow.AccountNumber = string.Empty;
                this.currentVendorRow.Name = string.Empty;
                this.currentVendorRow.CreditRating = 1;
                this.currentVendorRow.PreferredVendorStatus = false;
                this.currentVendorRow.ActiveFlag = true;

                //add the row to the data table
                this.vendorDataTable.AddVendorRow(this.currentVendorRow);
                //use the table adapter to perform the update
                this.vendorTableAdapter.Update(this.vendorDataTable);
                

                this.currentAddressRow =
                    this.addressDatatable.NewAddressRow();
                this.currentAddressRow.AddressLine1 = string.Empty;
                this.currentAddressRow.SetAddressLine2Null();
                this.currentAddressRow.City = string.Empty;
                this.currentAddressRow.StateProvinceID = 9;
                this.currentAddressRow.PostalCode = string.Empty;
                this.currentAddressRow.ModifiedDate = System.DateTime.Now;

                this.addressDatatable.AddAddressRow(this.currentAddressRow);
                this.addressTableAdapter.Update(this.addressDatatable);

                this.currentBusinessEntityAddressRow =
                    this.businessEntityAddressDataTable.NewBusinessEntityAddressRow();
                this.currentBusinessEntityAddressRow.BusinessEntityID = this.currentBusinessEntityRow.BusinessEntityID;
                this.currentBusinessEntityAddressRow.AddressID = this.currentAddressRow.AddressID;
                this.currentBusinessEntityAddressRow.AddressTypeID = 3;
                this.businessEntityAddressDataTable.AddBusinessEntityAddressRow(this.currentBusinessEntityAddressRow);
                this.businessEntityAddressTableAdapter.Update(this.businessEntityAddressDataTable);

                this.addingNew = true;
                this.currentVendorPosition = this.vendorDataTable.Count - 1;
                this.displayVendor();
                this.setButtonsEnabled(false);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "newButton_Click() " + ex.GetType().ToString());
                //revert back to original row data if error in try block occurs
                this.currentBusinessEntityRow = bakBusinessEntityRow;
                this.currentVendorRow = bakVendorRow;
                this.currentAddressRow = bakAddressRow;
                this.currentBusinessEntityAddressRow = bakBusinessEntityAddressRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "newButton_Click() " + ex.GetType().ToString());
                this.currentBusinessEntityRow = bakBusinessEntityRow;
                this.currentVendorRow = bakVendorRow;
                this.currentAddressRow = bakAddressRow;
                this.currentBusinessEntityAddressRow = bakBusinessEntityAddressRow;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.currentBusinessEntityAddressRow.Delete();
            this.currentAddressRow.Delete();
            this.currentVendorRow.Delete();
            this.currentBusinessEntityRow.Delete();

            try {
                this.businessEntityAddressTableAdapter.Update(
                    this.businessEntityAddressDataTable);
                this.addressTableAdapter.Update(this.addressDatatable);
                this.vendorTableAdapter.Update(this.vendorDataTable);
                this.businessEntityTableAdapter.Update(
                    this.businessEntityDataTable);

                this.currentVendorPosition = currentVendorPosition - 1;
                this.currentVendorRow =
                    (AdventureWorksDataSet.VendorRow)vendorDataTable.Rows[currentVendorPosition];
                this.loadCurrentVendorAddress();

                this.displayVendor();
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Error: " +
                               "\nMessage: " + ex.Message,
                               "deleteButton_Click() " + ex.GetType().ToString());
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "deleteButton_Click() " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "deleteButton_Click() " + ex.GetType().ToString());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.newButton.Enabled)
            {
                DialogResult saveChanges =
                MessageBox.Show("Save changes?", "Vendor Updates",
                 MessageBoxButtons.OKCancel);

                if (saveChanges == DialogResult.OK)
                {
                    this.saveButton_Click(sender,e);
                }
                else
                {
                    this.cancelButton_Click(sender, e);
                }
            }
        }
    }
}
