using OzkirFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzkirFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CategoryMap:EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"Categories", "dbo");
            HasKey(c => c.CategoryID);
            Property(c => c.CategoryName).HasColumnName("CategoryName");
            Property(c => c.Description).HasColumnName("Description");
        }
    }
}
