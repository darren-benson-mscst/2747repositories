using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dbenson2747ex2e_dbmapper
{
    public class Vendor
    {
        private int businessEntityID;
        private string accountNumber;
        private string name;
        private short creditRating;
        private bool preferredVendorStatus;
        private bool activeFlag;
        private System.DateTime modifiedDate;
        private string purchasingWebServiceURL;
        private Address address;

        public Vendor(int businessEntityID, string accountNumber, 
            string name, short creditRating, bool preferredVendorStatus, 
            bool activeFlag, System.DateTime modifiedDate)
        {
            this.businessEntityID = businessEntityID;
            this.accountNumber = accountNumber;
            this.name = name;
            this.creditRating = creditRating;
            this.preferredVendorStatus = preferredVendorStatus;
            this.activeFlag = activeFlag;
            this.modifiedDate = modifiedDate;
        }

        public Vendor(int businessEntityID, string accountNumber, 
            string name, short creditRating, bool preferredVendorStatus, 
            bool activeFlag, string purchasingWebServiceURL, System.DateTime modifiedDate, Address address )
        {
            this.businessEntityID = businessEntityID;
            this.accountNumber = accountNumber;
            this.name = name;
            this.creditRating = creditRating;
            this.preferredVendorStatus = preferredVendorStatus;
            this.activeFlag = activeFlag;
            this.purchasingWebServiceURL = purchasingWebServiceURL;
            this.modifiedDate = modifiedDate;
            this.address = address;
        }

        public int BusinessEntityID
        {
            get
            {
                return this.businessEntityID;
            }

            set
            {
                this.businessEntityID = value;
            }
        }

        public string AccountNumber
        {
            get
            {
                return this.accountNumber;
            }

            set
            {
                this.accountNumber = value;
            }
        }

        public short CreditRating
        {
            get
            {
                return this.creditRating;
            }

            set
            {
                this.creditRating = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public bool PreferredVendorStatus
        {
            get
            {
                return this.preferredVendorStatus;
            }

            set
            {
                this.preferredVendorStatus = value;
            }
        }

        public bool ActiveFlag
        {
            get
            {
                return this.activeFlag;
            }

            set
            {
                this.activeFlag = value;
            }
        }

        public System.DateTime ModifiedDate
        {
            get
            {
                return this.modifiedDate;
            }

            set
            {
                this.modifiedDate = value;
            }
        }

        public string ShortString
        {
            get
            {
                return this.businessEntityID.ToString()
                    + " " + this.name;
            }

        }

        public string LongString
        {
            get
            {
                return this.businessEntityID.ToString()
                    + " " + this.name + " " + this.accountNumber
                    + " " + "Credit Rating=" + this.creditRating.ToString() + " " + "Preferred=" + this.preferredVendorStatus.ToString()
                    + " " + "Active=" + this.activeFlag.ToString() + " " + "Modified=" + this.modifiedDate.ToShortDateString();
            }
           
        }

        public string PurchasingWebServiceURL
        {
            get
            {
                return this.purchasingWebServiceURL;
            }

            set
            {
                this.purchasingWebServiceURL = value;
            }
        }

        public Address Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        
    }
}