using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzkirFramework.Northwind.Entities.Concrete;

namespace OzkirFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class OrderMap:EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            ToTable(@"Orders", @"dbo");
            HasKey(c => c.OrderID);
            Property(c => c.OrderID).HasColumnName("OrderID");
            Property(c => c.CustomerID).HasColumnName("CustomerID");
            Property(c => c.EmployeeID).HasColumnName("EmployeeID");
            Property(c => c.OrderDate).HasColumnName("OrderDate");
            Property(c => c.ShipAddress).HasColumnName("ShipAddress");
            Property(c => c.ShipName).HasColumnName("ShipName");
        }
    }
}
