using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCodeFirst.DAL.ORM.Interface
{
    public interface ICompanyInfo
    {
        int Fax { get; set; }        
        string CompanyName { get; set; }    
        string ContactTitle { get; set; }       
        string ContactName { get; set; }
    }
}
