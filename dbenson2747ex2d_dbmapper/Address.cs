using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dbenson2747ex2d_dbmapper
{
    public class Address
    {
        private int addressID;
        private string addressLine1;
        private string addressLine2;
        private string city;       
        private int stateProvinceID;
        private string postalCode;
        private DateTime modifiedDate;
        private int businessEntityID;



        public Address(int addressID, string addressLine1, string addressLine2,
          string city, int stateProvinceID, string postalCode, DateTime modifiedDate)
        {

            this.addressID = addressID;
            this.addressLine1 = addressLine1;
            this.addressLine2 = addressLine2;
            this.city = city;
            this.stateProvinceID = stateProvinceID;
            this.postalCode = postalCode;
            this.modifiedDate = modifiedDate;
        }

        public Address(int businessEntityID, int addressID, string addressLine1, string addressLine2, 
            string city, int stateProvinceID, string postalCode, DateTime modifiedDate)
        {
            this.businessEntityID = businessEntityID;
            this.addressID = addressID;
            this.addressLine1 = addressLine1;
            this.addressLine2 = addressLine2;
            this.city = city;
            this.stateProvinceID = stateProvinceID;
            this.postalCode = postalCode;
            this.modifiedDate = modifiedDate;
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
        public int AddressID
        {
            get
            {
                return this.addressID;
            }
            set
            {
                this.addressID = value;
            }
        }
        public string AddressLine1
        {
            get
            {
                return this.addressLine1;
            }
            set
            {
                this.addressLine1 = value;
            }
        }
        public string AddressLine2
        {
            get
            {
                return this.addressLine2;
            }
            set
            {
                this.addressLine2 = value;
            }
        } 
        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        } 
        public int StateProvinceID
        {
            get
            {
                return this.stateProvinceID;
            }
            set
            {
                this.stateProvinceID = value;
            }
        }
        public string PostalCode
        {
            get
            {
                return this.postalCode;
            }
            set
            {
                this.postalCode = value;
            }
        }
        public DateTime ModifiedDate
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