using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbenson2747ex3a_ef.Model
{
    public partial class Employee
    {
        public string LastFirstName
        {
            get
            {
                return this.Person.LastName + ", " + this.Person.FirstName;
            }
        }
    }
}
