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

namespace dbenson2747ex1c
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
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adventureWorksDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
          
            try
            {
                this.unitMeasureTableAdapter.Fill(this.adventureWorksDataSet.UnitMeasure);
                this.productCategoryTableAdapter.Fill(this.adventureWorksDataSet.ProductCategory);
                this.productSubcategoryTableAdapter.Fill(this.adventureWorksDataSet.ProductSubcategory);
                this.productTableAdapter.Fill(this.adventureWorksDataSet.Product);
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

            productNumberBoundLabel2.DataBindings.Add(b);


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

        private void productBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            int position = productBindingSource.Position;
            int prodSubcategoryID = adventureWorksDataSet.Product.ElementAt(position).ProductSubcategoryID;
            AdventureWorksDataSet.ProductSubcategoryRow subcategoryRow =
                adventureWorksDataSet.ProductSubcategory.FindByProductSubcategoryID(prodSubcategoryID);
            productSubCategoryNameLabel.Text = subcategoryRow.Name;

            productCategoryIDLabel.Text = subcategoryRow.ProductCategoryID.ToString();

            int prodCategoryID = subcategoryRow.ProductCategoryID;
            AdventureWorksDataSet.ProductCategoryRow categoryRow =
                adventureWorksDataSet.ProductCategory.FindByProductCategoryID(prodCategoryID);
            productCategoryNameLabel.Text = categoryRow.Name;
            try {
                string measureCodeID = adventureWorksDataSet.Product.ElementAt(productBindingSource.Position).WeightUnitMeasureCode;
                AdventureWorksDataSet.UnitMeasureRow measureCodeNameRow =
                    adventureWorksDataSet.UnitMeasure.FindByUnitMeasureCode(measureCodeID);
                unitMeasureNameLabel.Text = measureCodeNameRow.Name;
            }
            catch (Exception ex) { }
        }
    }
}
