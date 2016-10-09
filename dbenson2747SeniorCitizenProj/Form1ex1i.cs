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

namespace dbenson2747SeniorCitizenProj
{
    public partial class Form1ex1i : Form
    {
        public Form1ex1i()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try {
                this.employeeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.seniorCitizenProj2722DataSet);
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
            // TODO: This line of code loads data into the 'seniorCitizenProj2722DataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.seniorCitizenProj2722DataSet.Client);
            try
            {
                this.employeeTableAdapter.Fill(this.seniorCitizenProj2722DataSet.Employee);
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
    }
}
