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

namespace dbenson2747SeniorCitizenProj1k
{
    public partial class Form1ex1k : Form
    {
        

        public Form1ex1k()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try {
                this.clientBindingSource.EndEdit();
                this.employeeBindingSource.EndEdit();
                this.employeeTableAdapter.Update(this.seniorCitizenProj2722DataSet);
                this.clientTableAdapter.Update(this.seniorCitizenProj2722DataSet);
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: \nMessage: " + ex.Message,
                    "employeeBindingNavigatorSaveItem_Click(): " + ex.GetType().ToString());
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Error Message: " + ex.Message,
                   "employeeBindingNavigatorSaveItem_Click(): " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message,
                    "employeeBindingNavigatorSaveItem_Click(): " + ex.GetType().ToString());
            }
        }

        private void Form1ex1k_Load(object sender, EventArgs e)
        {
           
            try
            {
                this.clientTableAdapter.Fill(this.seniorCitizenProj2722DataSet.Client);
                this.employeeTableAdapter.Fill(this.seniorCitizenProj2722DataSet.Employee);
                this.residenceTableAdapter.Fill(this.seniorCitizenProj2722DataSet.Residence);
                this.serviceTableAdapter.Fill(this.seniorCitizenProj2722DataSet.Service);
                this.subscribeEventHandlers();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Form1ex1k_Load() " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Form1ex1k_Load() " + ex.GetType().ToString());
            }
        }

        private void employeeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.unSubscribeEventHandler();

            try {
                int empID = (Int32)employeeComboBox.SelectedValue;
                this.clientTableAdapter.FillByEmployeeID(this.seniorCitizenProj2722DataSet.Client, empID);
            }
            catch (System.NullReferenceException ex)
            {
                //ignore
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex.Message,
                    "employeeComboBox_SelectedValueChanged " + ex.GetType().ToString());
            }

            this.subscribeEventHandlers();
        }

        private void subscribeEventHandlers()
        {
            this.employeeComboBox.SelectedValueChanged 
                += new System.EventHandler(this.employeeComboBox_SelectedValueChanged);

            this.serviceComboBox.SelectedValueChanged 
                += new System.EventHandler(this.serviceComboBox_SelectedValueChanged);

            this.hourlyCheckBox.CheckStateChanged 
                += new System.EventHandler(this.hourlyCheckBox_CheckStateChanged);

            this.dailyCheckBox.CheckStateChanged 
                += new System.EventHandler(this.dailyCheckBox_CheckStateChanged);

            this.weeklyCheckBox.CheckedChanged 
                += new System.EventHandler(this.weeklyCheckBox_CheckedChanged);
        }

        private void unSubscribeEventHandler()
        {
            this.employeeComboBox.SelectedValueChanged 
                -= new System.EventHandler(this.employeeComboBox_SelectedValueChanged);

            this.serviceComboBox.SelectedValueChanged 
                -= new System.EventHandler(this.serviceComboBox_SelectedValueChanged);

            this.hourlyCheckBox.CheckStateChanged 
                -= new System.EventHandler(this.hourlyCheckBox_CheckStateChanged);

            this.dailyCheckBox.CheckStateChanged 
                -= new System.EventHandler(this.dailyCheckBox_CheckStateChanged);

            this.weeklyCheckBox.CheckedChanged 
                -= new System.EventHandler(this.weeklyCheckBox_CheckedChanged);
        }

        private void Form1ex1k_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.unSubscribeEventHandler();
        }

        private void serviceComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            hourlyCheckBox.Checked = false;
            dailyCheckBox.Checked = false;
            weeklyCheckBox.Checked = false;
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

        private void weeklyCheckBox_CheckedChanged(object sender, EventArgs e)
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
    }
    
}
