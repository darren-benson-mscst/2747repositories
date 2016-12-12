using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbenson2747ex3a_ef.Model
{
    
    public class Company
    {
        private static AdventureWorksEFEntities dbContext =  new AdventureWorksEFEntities();

        public static List<ShipMethod> getShipMethod()
        {
            List<ShipMethod> shipMethodList = new List<ShipMethod>();
            try
            {
                shipMethodList =
                    (from ship in dbContext.ShipMethods
                     orderby ship.Name
                     select ship).ToList();                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return shipMethodList;
        }

        public static List<Vendor> getVendors()
        {
            List<Vendor> vendorList = new List<Vendor>();

            try
            {
                vendorList =
                    (from vend in dbContext.Vendors
                     orderby vend.Name
                     select vend).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return vendorList;
        }
        
        public static List<Employee> getEmployees()
        {
            List<Employee> employeeList = new List<Employee>();

            try
            {
                employeeList =
                    (from emp in dbContext.Employees.Include("Person")
                     orderby emp.Person.LastName, emp.Person.FirstName
                     select emp).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return employeeList;
        }

        public static int saveChanges()
        {
            int countChanges = 0;
            try
            {
                countChanges = dbContext.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return countChanges;
        }

    }
}
