using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCodeFirst.DAL.ORM.Interface
{
    public interface IEmployee
    {
        
        string LastName { get; set; }
        string FirstName { get; set; }
        DateTime? BirthDate { get; set; }
        string Title { get; set; }
        string TitleName { get; set; }
        DateTime? HireDate { get; set; }
        int? ReportsTo { get; set; }

    }
}
