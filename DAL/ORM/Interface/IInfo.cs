using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCodeFirst.DAL.ORM.Interface
{
     public interface IInfo
    {
  
        string Adress { get; set; }       
        string City { get; set; }
        string Region { get; set; }
        string Country { get; set; }
        int PostalCode { get; set; }
        string Phone { get; set; }
      

    }
}
