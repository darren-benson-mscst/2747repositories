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

namespace dbenson2747SeniorCitizenProj1J
{
    public partial class Form1ex1j : Form
    {
        

        public Form1ex1j()
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

        private void Form1ex1i_Load(object sender, EventArgs e)
        {
            
           
            try
            {
                this.clientTableAdapter.Fill(this.seniorCitizenProj2722DataSet.Client);
                this.employeeTableAdapter.Fill(this.seniorCitizenProj2722DataSet.Employee);
                this.residenceTableAdapter.Fill(this.seniorCitizenProj2722DataSet.Residence);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Form1ex1i_Load() " + ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +
                    "\nMessage: " + ex.Message,
                    "Form1ex1i_Load() " + ex.GetType().ToString());
            }
        }

        private void employeeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
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
            
        }

        
        
    }
    
}
