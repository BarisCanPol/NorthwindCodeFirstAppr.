using NorthwindCodeFirst.DAL.ORM.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCodeFirst.DAL.ORM.Entity
{
    public class Customer : BaseEntity, ICompanyInfo ,IInfo
    {
        public int Fax { get; set; }
        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactName { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public string Phone { get; set; }
     
        public int CustomerTypeID { get; set; }
        public virtual CustomerDemographic CustomerDemographic { get; set; }

        public virtual List<Order> Orders { get; set; }

    }
}
