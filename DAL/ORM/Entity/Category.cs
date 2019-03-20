using NorthwindCodeFirst.DAL.ORM.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCodeFirst.DAL.ORM.Entity
{
    public class Category : BaseEntity
    {
        [MaxLength(20)]
        public string CategoryName { get; set; }
        [MaxLength(40)]
        public string Description { get; set; }
        public byte[] Picture { get; set; }
       

        public virtual List<Product> Products { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
