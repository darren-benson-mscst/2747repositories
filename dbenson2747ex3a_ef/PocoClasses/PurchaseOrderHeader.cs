using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbenson2747ex3a_ef.Model
{
    public partial class PurchaseOrderHeader
    {
        public decimal TotalDue
        {
            get
            {       
                                        
                {
                                                        
                    return this.SubTotal + this.TaxAmt + this.Freight;                    
                }
                
            }
        }
    }
}
