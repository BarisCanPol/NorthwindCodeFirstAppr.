using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCodeFirst.DAL.ORM.Interface
{
    public interface IProduct
    {
       
        string ProductName { get; set; }
        string QuantityPerUnit { get; set; }
        decimal?  UnitPrice { get; set; }
        short QuantityInStock { get; set; }
        short UnitInOrder { get; set; }
        short ReorderLevel { get; set; }
        bool Discounted { get; set; }


    }
}
