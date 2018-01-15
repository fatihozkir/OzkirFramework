using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzkirFramework.Northwind.Entities.ComplexTypes
{
    public class ProductDetail
    {
        public virtual int ProductID { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string CategoryName { get; set; }

    }
}
