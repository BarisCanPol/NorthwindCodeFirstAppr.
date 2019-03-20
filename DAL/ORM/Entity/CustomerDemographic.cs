using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCodeFirst.DAL.ORM.Entity
{
    public class CustomerDemographic : BaseEntity
    {
        public string CustomerDesc { get; set; }


      public virtual List<Customer> Customers { get; set; }      
    }
}
