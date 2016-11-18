using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dbenson2747ex2c
{
    public class PurchaseOrderHeader
    {
        private int purchaseOrderID;
        private int revisionNumber;
        private int status;
        private int employeeID;
        private int vendorID;
        private int shipMethodID;
        private DateTime orderDate;
        private DateTime? shipDate;
        private decimal subTotal;
        private decimal taxAmt;
        private decimal freight;
        private decimal totalDue;
        private DateTime modifiedDate;

        public PurchaseOrderHeader(int purchaseOrderID, int revisionNumber, int status, int employeeID, 
            int shipMethodID, DateTime orderDate, DateTime? shipDate, decimal subTotal, 
            decimal taxAmt, decimal freight, decimal totalDue)
        {
            this.purchaseOrderID = purchaseOrderID;
            this.revisionNumber = revisionNumber;
            this.status = status;
            this.employeeID = employeeID;
            this.shipMethodID = shipMethodID;
            this.orderDate = orderDate;
            this.shipDate = shipDate;
            this.subTotal = subTotal;
            this.taxAmt = taxAmt;
            this.freight = freight;
            this.totalDue = totalDue;
        }

        public int PurchaseOrderID
        {
            get
            {
                return this.purchaseOrderID;
            }

            set
            {
                this.purchaseOrderID = value;
            }
        }

        public int RevisionNumber
        {
            get
            {
                return this.revisionNumber;
            }

            set
            {
                this.revisionNumber = value;
            }
        }

        public int Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.status = value;
            }
        }

        public int EmployeeID
        {
            get
            {
                return this.employeeID;
            }

            set
            {
                this.employeeID = value;
            }
        }

        public int VendorID
        {
            get
            {
                return this.vendorID;
            }

            set
            {
                this.vendorID = value;
            }
        }

        public int ShipMethodID
        {
            get
            {
                return this.shipMethodID;
            }

            set
            {
                this.shipMethodID = value;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return this.orderDate;
            }

            set
            {
                this.orderDate = value;
            }
        }

        public DateTime? ShipDate
        {
            get
            {
                return this.shipDate;
            }

            set
            {
                this.shipDate = value;
            }
        }

        public decimal SubTotal
        {
            get
            {
                return this.subTotal;
            }

            set
            {
                this.subTotal = value;
            }
        }

        public decimal TaxAmt
        {
            get
            {
                return this.taxAmt;
            }

            set
            {
                this.taxAmt = value;
            }
        }

        public decimal Freight
        {
            get
            {
                return this.freight;
            }

            set
            {
                this.freight = value;
            }
        }

        public decimal TotalDue
        {
            get
            {
                return this.totalDue;
            }

            set
            {
                this.totalDue = value;
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
    }
}