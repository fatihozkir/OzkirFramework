using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzkirFramework.Core.Entities;

namespace OzkirFramework.Northwind.Entities.Concrete
{
    public class Order:IEntity
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipName  { get; set; }
        public string ShipAddress { get; set; }
    }
}
