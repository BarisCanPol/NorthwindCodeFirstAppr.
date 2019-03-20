using NorthwindCodeFirst.DAL.ORM.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace NorthwindCodeFirst.DAL.ORM.Entity
{
    public   class OrderDetail :BaseEntity
    {
     

        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
      
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }

       public int ProductID { get; set; }
        public virtual Product Product { get; set; }


    }
}
