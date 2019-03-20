using NorthwindCodeFirst.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCodeFirst.DAL.ORM.Context
{
    public class ProjectContext :DbContext
    {

        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=NorthwindE;UID=bcp;PWD=123;";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        DbSet<Category> Categories { get; set; }
        DbSet<Customer> Customers  { get; set; }
        DbSet<CustomerCustomerDemo> CustomerCustomerDemos  { get; set; }
        DbSet<CustomerDemographic> CustomerDemographics  { get; set; }
        DbSet<Employee> Employees  { get; set; }
        DbSet<EmployeeTerritory> EmployeeTerritories  { get; set; }
        DbSet<Order> Orders  { get; set; }
        DbSet<OrderDetail> OrderDetails  { get; set; }
        DbSet<Product> Products   { get; set; }
        DbSet<Region> Regions   { get; set; }
        DbSet<Supplier> Suppliers   { get; set; }
        DbSet<Shipper> Shippers   { get; set; }
        DbSet<Territory> Territories    { get; set; }
    }
}
