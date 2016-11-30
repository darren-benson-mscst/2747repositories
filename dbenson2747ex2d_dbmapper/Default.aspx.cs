using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dbenson2747ex2d_dbmapper;

namespace dbenson2747ex2d
{
    public partial class _Default : Page
    {
        private Vendor selectedVendor = null;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.loadVendors();
            }
        }

        protected void loadVendors()
        {
            List<Vendor> vendorList = new List<Vendor>();
            vendorList = VendorDB.getVendors();

            this.vendorsDropDownList.DataSource = vendorList;
            this.vendorsDropDownList.DataTextField = "ShortString";
            this.vendorsDropDownList.DataValueField = "BusinessEntityID";
            this.vendorsDropDownList.DataBind();

            if (vendorList.Count > 0)
            {
                this.vendorsDropDownList.SelectedIndex = 0;
                this.selectedVendor = vendorList.ElementAt(0);
                this.displaySelectedVendor();
            }
            
        }

        protected void displaySelectedVendor()
        {
            this.addressIDLabel.Text = this.selectedVendor.Address.AddressID.ToString();
            this.accountNumberTextBox.Text = this.selectedVendor.AccountNumber;
            this.nameTextBox.Text = this.selectedVendor.Name;
            this.addressLine1TextBox.Text = this.selectedVendor.Address.AddressLine1;
            this.addressLine2TextBox.Text = this.selectedVendor.Address.AddressLine2;
            this.cityTextBox.Text = this.selectedVendor.Address.City;
            this.stateTextBox.Text = this.selectedVendor.Address.StateProvinceID.ToString();
            this.zipTextBox.Text = this.selectedVendor.Address.PostalCode;
            this.creditRatingDropDownList.SelectedValue = this.selectedVendor.CreditRating.ToString();
            this.preferredVendorCheckBox.Checked = this.selectedVendor.PreferredVendorStatus;
            this.activeCheckBox.Checked = this.selectedVendor.ActiveFlag;
            this.webServiceTextBox.Text = this.selectedVendor.PurchasingWebServiceURL;
            this.modifiedDateCalendar.SelectedDate = this.selectedVendor.ModifiedDate;
            this.modifiedDateCalendar.VisibleDate = this.selectedVendor.ModifiedDate;

           
        }

        protected void vendorsDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedVendor = VendorDB.getVendor(Int32.Parse(vendorsDropDownList.SelectedValue));
            this.displaySelectedVendor();
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Address address = new Address(
                Int32.Parse(this.addressIDLabel.Text),
                this.addressLine1TextBox.Text.Trim(),
                this.addressLine2TextBox.Text.Trim(),
                this.cityTextBox.Text.Trim(),
                Int32.Parse(this.stateTextBox.Text.Trim()),
                this.zipTextBox.Text.Trim(),
                DateTime.Now);

            Vendor vendor = new Vendor(
                Int32.Parse(this.vendorsDropDownList.SelectedValue),
                this.accountNumberTextBox.Text.Trim(),
                this.nameTextBox.Text.Trim(),
                Int16.Parse(this.creditRatingDropDownList.SelectedValue),
                this.preferredVendorCheckBox.Checked, this.activeCheckBox.Checked,
                this.webServiceTextBox.Text.Trim(),
                this.modifiedDateCalendar.SelectedDate, address);

            selectedVendor = VendorDB.updateVendor(vendor);
            this.displaySelectedVendor();                  
        }
    }
}