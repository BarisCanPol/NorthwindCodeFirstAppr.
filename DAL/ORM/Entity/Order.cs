using NorthwindCodeFirst.DAL.ORM.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCodeFirst.DAL.ORM.Entity
{
    public class Order : BaseEntity, IOrder
    {
        public DateTime? OrderDate { get; set ; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal? Freight { get; set; }      
        public string ShipName { get; set; }
        public string ShipAdress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipCountry { get; set; }
        public string ShipPostalCode { get; set; }
     
        public int ShipperID { get; set; }
        public virtual Shipper Shipper { get; set; }

        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }


    }
}
