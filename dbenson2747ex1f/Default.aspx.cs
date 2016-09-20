using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dbenson2747ex1fData;
using dbenson2747ex1fData.AdventureWorksDataSetTableAdapters;

namespace dbenson2747ex1f
{
    public partial class _Default : Page
    {
        private AdventureWorksDataSet adventureWorksDataSet;
        private VendorTableAdapter vendorTableAdapter;
        private PurchaseOrderDescriptionTableAdapter purchaseOrderDescriptionTableAdapter;
        private PurchaseOrderHeaderTableAdapter purchaseOrderHeaderTableAdapter;
        private ShipMethodTableAdapter shipMethodTableAdapter;
        private PersonTableAdapter personTableAdapter;
        private PurchaseOrderDetailTableAdapter purchaseOrderDetailTableAdapter;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.adventureWorksDataSet = new AdventureWorksDataSet();

            if (!this.IsPostBack)
            {
                this.loadEmployeeName();
                this.loadShipMethod();
                this.loadVendors();
                this.loadPurchaseOrderDescriptions();
                this.loadSelectedPurchaseOrder();
         
            }

            
        }

       
        protected void vendorsDropDownList_SelectedIndexChanged1(object sender, EventArgs e)
        {
            this.loadPurchaseOrderDescriptions();
            this.loadSelectedPurchaseOrder();
            
        }

        private void loadVendors()
        {
            this.vendorTableAdapter = new VendorTableAdapter();
            this.vendorTableAdapter.ClearBeforeFill = true;
            this.vendorTableAdapter.Fill(adventureWorksDataSet.Vendor);

            this.vendorsDropDownList.DataSource = this.adventureWorksDataSet.Vendor;
            this.vendorsDropDownList.DataTextField = "Name";
            this.vendorsDropDownList.DataValueField = "BusinessEntityID";
            this.vendorsDropDownList.DataBind();

            this.vendorsDropDownList.SelectedIndex = 1;
        }

        private void loadPurchaseOrderDescriptions()
        {
            this.purchaseOrderDescriptionTableAdapter = new PurchaseOrderDescriptionTableAdapter();
            this.purchaseOrderDescriptionTableAdapter.ClearBeforeFill = true;
            int vendorID = Convert.ToInt32(this.vendorsDropDownList.SelectedValue);
            this.purchaseOrderDescriptionTableAdapter.FillByVendorID(adventureWorksDataSet.PurchaseOrderDescription, vendorID);

            this.purchaseOrderIDDropDownList.DataSource = this.adventureWorksDataSet.PurchaseOrderDescription;
            this.purchaseOrderIDDropDownList.DataTextField = "Description";
            this.purchaseOrderIDDropDownList.DataValueField = "PurchaseOrderID";
            this.purchaseOrderIDDropDownList.DataBind();
        }

        
        protected void purchaseOrderIDDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.loadSelectedPurchaseOrder();
        }

        private void loadSelectedPurchaseOrder()
        {
            this.purchaseOrderHeaderTableAdapter = new PurchaseOrderHeaderTableAdapter();
            this.purchaseOrderHeaderTableAdapter.ClearBeforeFill = true;
            int vendorID = Convert.ToInt32(this.purchaseOrderIDDropDownList.SelectedValue);
            this.purchaseOrderHeaderTableAdapter.FillByPurchaseOrderID(adventureWorksDataSet.PurchaseOrderHeader, vendorID);
            AdventureWorksDataSet.PurchaseOrderHeaderRow purchaseOrderRow =
                this.adventureWorksDataSet.PurchaseOrderHeader.First();

            this.revisionNumberTextBox.Text = purchaseOrderRow.RevisionNumber.ToString();
            this.statusTextBox.Text = purchaseOrderRow.Status.ToString();
            //this.employeeIDTextBox.Text = purchaseOrderRow.EmployeeID.ToString();
            this.employeeNameDropDownList.SelectedValue = purchaseOrderRow.EmployeeID.ToString();
            this.shipDateTextBox.Text = purchaseOrderRow.ShipDate.ToShortDateString();
            //this.shipMethodIDTextBox.Text = purchaseOrderRow.ShipMethodID.ToString();
            this.shipMethodDropDownList.SelectedValue = purchaseOrderRow.ShipMethodID.ToString();
            this.subtotalLabel.Text = purchaseOrderRow.SubTotal.ToString("n2");
            this.taxAmtLabel.Text = purchaseOrderRow.TaxAmt.ToString("n2");
            this.freightTextBox.Text = purchaseOrderRow.Freight.ToString("n2");
            this.totalDueLabel.Text = purchaseOrderRow.TotalDue.ToString("n2");

            this.loadPurchaseOrderDetails();

        }

        private void loadShipMethod()
        {
            this.shipMethodTableAdapter = new ShipMethodTableAdapter();
            this.shipMethodTableAdapter.ClearBeforeFill = true;
            this.shipMethodTableAdapter.Fill(adventureWorksDataSet.ShipMethod);

            this.shipMethodDropDownList.DataSource = this.adventureWorksDataSet.ShipMethod;
            this.shipMethodDropDownList.DataTextField = "Name";
            this.shipMethodDropDownList.DataValueField = "ShipMethodID";
            this.shipMethodDropDownList.DataBind();
        }

        private void loadEmployeeName()
        {
            this.personTableAdapter = new PersonTableAdapter();
            this.personTableAdapter.ClearBeforeFill = true;
            this.personTableAdapter.Fill(adventureWorksDataSet.Person);

            this.employeeNameDropDownList.DataSource = this.adventureWorksDataSet.Person;
            this.employeeNameDropDownList.DataTextField = "LastFirstName";
            this.employeeNameDropDownList.DataValueField = "BusinessEntityID";
            this.employeeNameDropDownList.DataBind();
        }

        private void loadPurchaseOrderDetails()
        {
            this.purchaseOrderDetailTableAdapter = new PurchaseOrderDetailTableAdapter();
            this.purchaseOrderDetailTableAdapter.ClearBeforeFill = true;
            int purchaseOrderID = Convert.ToInt32(purchaseOrderIDDropDownList.SelectedValue);
            this.purchaseOrderDetailTableAdapter.FillByPurchaseOrderID(adventureWorksDataSet.PurchaseOrderDetail, purchaseOrderID);

            this.purchaseOrderDetailsGridView.DataSource = this.adventureWorksDataSet.PurchaseOrderDetail;
            this.purchaseOrderDetailsGridView.DataBind();
        }
    }
}