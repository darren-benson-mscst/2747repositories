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

namespace dbenson2747SeniorCitizenProject2B
{
    public partial class Form1 : Form
    {

        private SeniorCitizensDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private SeniorCitizensDataSet.EmployeeDataTable employeeDataTable;
        private SeniorCitizensDataSet.EmployeeRow currentEmployeeRow;

        private SeniorCitizensDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private SeniorCitizensDataSet.ServiceDataTable serviceDataTable;
        private SeniorCitizensDataSet.ServiceRow currentServiceRow;

        private int currentEmployeePosition = -1;
        private int currentServicePosition = -1;
        private bool addingNew;
        private string currentTextBoxText;
        private object previousSender;


        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

            this.loadClient();

            if (clientComboBox.Items.Count > 0)
            {
                this.employeeTableAdapter = new SeniorCitizensDataSetTableAdapters.EmployeeTableAdapter();
                this.employeeTableAdapter.ClearBeforeFill = true;
                this.employeeDataTable = new SeniorCitizensDataSet.EmployeeDataTable();

                this.employeeTableAdapter.Fill(employeeDataTable);
                this.currentEmployeePosition = 0;
                this.currentEmployeeRow =
                        (SeniorCitizensDataSet.EmployeeRow)employeeDataTable.Rows[currentEmployeePosition];

                this.serviceTableAdapter = new SeniorCitizensDataSetTableAdapters.ServiceTableAdapter();
                this.serviceTableAdapter.ClearBeforeFill = true;
                this.serviceDataTable = new SeniorCitizensDataSet.ServiceDataTable();

                this.serviceTableAdapter.Fill(serviceDataTable);
                this.currentServicePosition = 0;
                this.currentServiceRow =
                    (SeniorCitizensDataSet.ServiceRow)serviceDataTable.Rows[currentServicePosition];

                this.loadEmployee();
                this.loadServices();
                this.setNavButtonEnabledToFalse();
               
           }

        }

        private void loadClient()
        {
            SeniorCitizensDataSetTableAdapters.ClientTableAdapter clientTableAdapter =
                new SeniorCitizensDataSetTableAdapters.ClientTableAdapter();
            clientTableAdapter.ClearBeforeFill = true;

            SeniorCitizensDataSet.ClientDataTable clientDataTable =
                new SeniorCitizensDataSet.ClientDataTable();

            try
            {
                clientTableAdapter.Fill(clientDataTable);
                clientComboBox.DataSource = clientDataTable;
                clientComboBox.ValueMember = "ClientID";
                clientComboBox.DisplayMember = "ClientFirstName";
                
            }
            catch (System.NullReferenceException ex)
            {
                //ignore
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "loadClient() " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "loadClient() " + ex.GetType().ToString());
            }

        }

       private void loadEmployee()
        {
            this.employeeIDLabelText.Text = this.currentEmployeeRow.EmployeeID.ToString();
            this.empFirstNameTextBox.Text = this.currentEmployeeRow.EmpFirstName;
            this.empLastNameTextBox.Text = this.currentEmployeeRow.EmpLastName;
            this.empAgeTextBox.Text = this.currentEmployeeRow.EmpAge.ToString();
            this.empGenderTextBox.Text = this.currentEmployeeRow.EmpGender;
            this.empDateOfBirthDateTimePicker.Value = this.currentEmployeeRow.EmpDateOfBirth;

            this.currentPositionLabel.Text = ((currentEmployeePosition + 1) + " of " + employeeDataTable.Count.ToString());
        }

        private void loadServices()
        {

            SeniorCitizensDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter =
                new SeniorCitizensDataSetTableAdapters.ServiceTableAdapter();
            serviceTableAdapter.ClearBeforeFill = true;

            SeniorCitizensDataSet.ServiceDataTable serviceDataTable =
                new SeniorCitizensDataSet.ServiceDataTable();

            try
            {
                serviceTableAdapter.Fill(serviceDataTable);
                servicesComboBox.DataSource = serviceDataTable;
                servicesComboBox.ValueMember = "ServiceID";
                servicesComboBox.DisplayMember = "ServiceID";

            }
            catch (System.NullReferenceException ex)
            {
                //ignore
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "loadServices() " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "loadServices() " + ex.GetType().ToString());
            }

            this.serviceDescriptionTextBox.Text = this.currentServiceRow.ServiceDescription;
            this.serviceRateHourlyTextBox.Text = this.currentServiceRow.ServiceRateHourly.ToString();
            this.serviceRateDailyTextBox.Text = this.currentServiceRow.ServiceRateDaily.ToString();
            this.serviceRateWeeklyTextBox.Text = this.currentServiceRow.ServiceRateWeekly.ToString();
        }

        private void updateAllRows()
        {
           
            this.currentEmployeeRow.EmpFirstName = this.empFirstNameTextBox.Text;
            this.currentEmployeeRow.EmpLastName = this.empLastNameTextBox.Text;
            this.currentEmployeeRow.EmpAge = Int32.Parse(this.empAgeTextBox.Text);
            this.currentEmployeeRow.EmpGender = this.empGenderTextBox.Text;
            this.currentEmployeeRow.EmpDateOfBirth = this.empDateOfBirthDateTimePicker.Value;

            this.currentServiceRow.ServiceDescription = this.serviceDescriptionTextBox.Text;
            this.currentServiceRow.ServiceRateHourly = Decimal.Parse(this.serviceRateHourlyTextBox.Text);
            this.currentServiceRow.ServiceRateDaily = Decimal.Parse(this.serviceRateDailyTextBox.Text);
            this.currentServiceRow.ServiceRateWeekly = Decimal.Parse(this.serviceRateWeeklyTextBox.Text);

        }

        private void controlValueChanged(object sender, EventArgs e)
        {
            if (this.moveFirstButton.Focused || this.moveNextButton.Focused || this.movePreviousButton.Focused || this.moveLastButton.Focused){
                this.setButtonsEnabled(true);
            }
            
            
        }

        private void navButton_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "moveFirstButton":
                    this.currentEmployeePosition = 0;
                    break;
                case "movePreviousButton":
                    this.currentEmployeePosition -= 1;
                    break;
                case "moveNextButton":
                    this.currentEmployeePosition += 1;
                    break;
                case "moveLastButton":
                    this.currentEmployeePosition = this.employeeDataTable.Count - 1;
                    break;
            }

            try
            {
                if (this.currentEmployeePosition == 0)
                {
                    this.setNavButtonEnabledToFalse();
                }
                else
                {
                    this.setNavButtonEnabledToTrue();
                }

                if (this.currentEmployeePosition == this.employeeDataTable.Count - 1)
                {
                    this.setNavButtonLastEnabledToFalse();
                    this.setButtonsEnabled(true);    
                }
                else
                {
                    this.setNavButtonLastEnabledToTrue();
                }
            }
            catch (System.NullReferenceException ex)
            {
                //ignore
            }

            this.currentEmployeeRow =
                 (SeniorCitizensDataSet.EmployeeRow)employeeDataTable.Rows[currentEmployeePosition];
                this.loadEmployee();

            this.empFirstNameTextBox.Focus();          
            this.hourlyCheckBox.Checked = false;
            this.dailyCheckBox.Checked = false;
            this.weeklyCheckBox.Checked = false;
                            
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

        private void setButtonsEnabled(bool value)
        {
            
            this.deleteButton.Enabled = value;
            this.newButton.Enabled = value;
        }

        private void textBox_validateNull(object sender, CancelEventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;
            if (currentTextBox.Text.Trim().Equals(string.Empty))
            {
                currentTextBox.BackColor = Color.LightBlue;
                e.Cancel = true;
                this.setButtonsEnabled(false);
            }
            else
            {
                currentTextBox.BackColor = SystemColors.Window;
                e.Cancel = false;
                this.setButtonsEnabled(true);    
            }
        }

        private bool employeeCountrolsAreValid()
        {
            bool controlsAreValid = true;


            return controlsAreValid;
        }

        private void servicesComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                if (servicesComboBox.SelectedIndex != -1)
                {
                    this.currentServiceRow =
                          (SeniorCitizensDataSet.ServiceRow)serviceDataTable.Rows[this.servicesComboBox.SelectedIndex];

                    this.serviceDescriptionTextBox.Text = this.currentServiceRow.ServiceDescription;
                    this.serviceRateHourlyTextBox.Text = this.currentServiceRow.ServiceRateHourly.ToString();
                    this.serviceRateDailyTextBox.Text = this.currentServiceRow.ServiceRateDaily.ToString();
                    this.serviceRateWeeklyTextBox.Text = this.currentServiceRow.ServiceRateWeekly.ToString();
                }
                else
                {
                    this.currentServiceRow =
                          (SeniorCitizensDataSet.ServiceRow)serviceDataTable.Rows[0];

                    this.serviceDescriptionTextBox.Text = this.currentServiceRow.ServiceDescription;
                    this.serviceRateHourlyTextBox.Text = this.currentServiceRow.ServiceRateHourly.ToString();
                    this.serviceRateDailyTextBox.Text = this.currentServiceRow.ServiceRateDaily.ToString();
                    this.serviceRateWeeklyTextBox.Text = this.currentServiceRow.ServiceRateWeekly.ToString();
                }
                 

            }
            catch (System.NullReferenceException ex)
            {
                //ignore
            }

            this.hourlyCheckBox.Checked = false;
            this.dailyCheckBox.Checked = false;
            this.weeklyCheckBox.Checked = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (employeeCountrolsAreValid())
            {            
                this.currentEmployeeRow.BeginEdit();
                this.currentServiceRow.BeginEdit();
                this.updateAllRows();
                this.currentServiceRow.EndEdit();
                this.currentEmployeeRow.EndEdit();
                
                try
                {
                    this.employeeTableAdapter.Update(this.employeeDataTable);
                    this.serviceTableAdapter.Update(this.serviceDataTable);               
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
        }

        private void hourlyCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (hourlyCheckBox.Checked == true)
            {
                dailyCheckBox.Enabled = false;
                weeklyCheckBox.Enabled = false;
            }
            else
            {
                dailyCheckBox.Enabled = true;
                weeklyCheckBox.Enabled = true;
            }
        }

        private void dailyCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (dailyCheckBox.Checked == true)
            {
                hourlyCheckBox.Enabled = false;
                weeklyCheckBox.Enabled = false;
            }
            else
            {
                hourlyCheckBox.Enabled = true;
                weeklyCheckBox.Enabled = true;
            }
        }

        private void weeklyCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (weeklyCheckBox.Checked == true)
            {
                hourlyCheckBox.Enabled = false;
                dailyCheckBox.Enabled = false;
            }
            else
            {
                hourlyCheckBox.Enabled = true;
                dailyCheckBox.Enabled = true;
            }
        }

        private void clearAllControls()
        {
            this.employeeIDLabelText.Text = string.Empty;
            this.empFirstNameTextBox.Text = string.Empty;
            this.empLastNameTextBox.Text = string.Empty;
            this.empAgeTextBox.Text = string.Empty;
            this.empGenderTextBox.Text = string.Empty;
            this.empDateOfBirthDateTimePicker.Value = System.DateTime.Today;

            this.clientComboBox.SelectedValue = -1;
            this.servicesComboBox.SelectedIndex = -1;

            this.serviceDescriptionTextBox.Text = string.Empty;
            this.serviceRateHourlyTextBox.Text = string.Empty;
            this.serviceRateDailyTextBox.Text = string.Empty;
            this.serviceRateWeeklyTextBox.Text = string.Empty;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (this.addingNew == true)
            {
                this.deleteButton_Click(null, null);
                this.addingNew = false;
            }
            else
            {
                this.clearAllControls();
                this.loadEmployee();
                this.loadClient();
                this.loadServices();
                this.setButtonsEnabled(true);
                MessageBox.Show("Update Cancelled", "Operation Cancelled");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.currentEmployeeRow.Delete();
            
            try
            {
                this.employeeTableAdapter.Update(
                    this.employeeDataTable);
                
                this.currentEmployeePosition = currentEmployeePosition - 1;
                this.currentEmployeeRow =
                    (SeniorCitizensDataSet.EmployeeRow)employeeDataTable.Rows[currentEmployeePosition];

                this.loadEmployee();
                this.loadServices();
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

        private void newButton_Click(object sender, EventArgs e)
        {
            //Create copies of the initial row values. Helpful incase anything blows up within the try block. Program can revert back to original data.
            SeniorCitizensDataSet.EmployeeRow bakEmployeeRow =
                this.currentEmployeeRow;
            SeniorCitizensDataSet.ServiceRow bakServiceRow =
                this.currentServiceRow;

            try
            {
                //Create the new row object
                this.currentEmployeeRow =
                    this.employeeDataTable.NewEmployeeRow();

                //initialize the fields
                this.currentEmployeeRow.EmployeeID = this.currentEmployeeRow.EmployeeID + 1;
                this.currentEmployeeRow.EmpFirstName = string.Empty;
                this.currentEmployeeRow.EmpLastName = string.Empty;
                this.currentEmployeeRow.EmpAge = 0;
                this.currentEmployeeRow.EmpGender = string.Empty;
                this.currentEmployeeRow.EmpDateOfBirth = System.DateTime.Today;
                this.currentEmployeeRow.EmpPhone = "123-111-1111";

                //Add the row to the data table
                this.employeeDataTable.AddEmployeeRow(this.currentEmployeeRow);

                //Use table adapter to perform the update
                int countNew = this.employeeTableAdapter.Update(this.employeeDataTable);

                this.addingNew = true;
                this.currentEmployeePosition = this.employeeDataTable.Count - 1;
                this.loadEmployee();
                this.loadServices();
                this.setNavButtonLastEnabledToFalse();
                this.setButtonsEnabled(false);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "newButton_Click() " + ex.GetType().ToString());
                //revert back to original row data if error in try block occurs
                this.currentEmployeeRow = bakEmployeeRow;
                this.currentServiceRow = bakServiceRow;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "newButton_Click() " + ex.GetType().ToString());
                this.currentEmployeeRow = bakEmployeeRow;
                this.currentServiceRow = bakServiceRow;
                
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.newButton.Enabled)
            {
                DialogResult saveChanges =
                MessageBox.Show("Save changes?", "Employee Updates",
                 MessageBoxButtons.OKCancel);

                if (saveChanges == DialogResult.OK)
                {
                    this.saveButton_Click(sender, e);
                }
                else
                {
                    this.cancelButton_Click(sender, e);
                }
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                TextBox currentTextBox = (TextBox)sender;
                currentTextBox.Text = this.currentTextBoxText;
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
    }
}
