using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCodeFirst.DAL.ORM.Interface
{
   public interface IOrder
    {

         DateTime? OrderDate { get; set; }
         DateTime? RequiredDate { get; set; }
         DateTime? ShippedDate { get; set; }
         decimal? Freight  { get; set; }
         string ShipName  { get; set; }
         string ShipAdress  { get; set; }
         string ShipCity  { get; set; }
         string ShipRegion  { get; set; }
         string ShipCountry  { get; set; }
         string ShipPostalCode { get; set; }
    }
}
