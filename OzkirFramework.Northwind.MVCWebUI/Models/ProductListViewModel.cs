using System.Collections.Generic;
using OzkirFramework.Northwind.Entities.Concrete;

namespace OzkirFramework.Northwind.MVCWebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
    }
}