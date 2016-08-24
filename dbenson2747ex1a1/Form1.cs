using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbenson2747ex1a1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void shipMethodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shipMethodBindingSource.EndEdit();
            try { 
            this.tableAdapterManager.UpdateAll(this.adventureWorksDataSet);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorksDataSet.ShipMethod' table. You can move, or remove it, as needed.
            this.shipMethodTableAdapter.Fill(this.adventureWorksDataSet.ShipMethod);

        }

        private void detailsFormButton_Click(object sender, EventArgs e)
        {
            ShipDetailsForm shipDetailsForm = new ShipDetailsForm();
            shipDetailsForm.Show();
        }

        private void personFormButton_Click(object sender, EventArgs e)
        {
            PersonForm personForm = new PersonForm();
            personForm.Show();
        }
    }
}
