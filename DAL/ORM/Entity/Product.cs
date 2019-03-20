using NorthwindCodeFirst.DAL.ORM.Enum;
using NorthwindCodeFirst.DAL.ORM.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCodeFirst.DAL.ORM.Entity
{
    public class Product : BaseEntity, IProduct
    {
     
        public string ProductName { get ; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short QuantityInStock { get; set; }
        public short UnitInOrder { get; set; }
        public short ReorderLevel { get; set; }
        public bool Discounted { get; set; }

        public int SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; } 
    }
}
