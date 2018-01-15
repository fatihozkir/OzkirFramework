using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzkirFramework.Core.Entities;

namespace OzkirFramework.Northwind.Entities.Concrete
{
    public class Role:IEntity
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
    }
}
