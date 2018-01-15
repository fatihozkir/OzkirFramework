using FluentNHibernate.Mapping;
using OzkirFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzkirFramework.Northwind.DataAccess.Concrete.NHibernate.Mappings
{
    public class CategoryMap:ClassMap<Category>
    {
        public CategoryMap()
        {
            Table(@"Categories");
            Id(x => x.CategoryID);
            Map(x => x.CategoryName).Column("CategoryName");
            Map(x => x.Description).Column("Description");
        }
    }
}
