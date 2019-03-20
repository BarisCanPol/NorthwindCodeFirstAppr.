using NorthwindCodeFirst.DAL.ORM.Enum;
using NorthwindCodeFirst.DAL.ORM.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCodeFirst.DAL.ORM.Entity
{
    public class Employee : BaseEntity, IInfo ,IEmployee
    {
        public string Adress { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public string Phone { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        DateTime? IEmployee.BirthDate { get; set; }
        DateTime? IEmployee.HireDate { get; set; }
        public string Title { get; set; }
        public string TitleName { get; set; }
        public TitleOfCourtesy TitleOfCourtesy { get; set; }
        public int? ReportsTo { get; set; }

        public int TerritoryID { get; set; }
        public virtual Territory Territory { get; set; }


        public virtual List<Employee> Employees { get; set; }    
       

        
        
    }
}
