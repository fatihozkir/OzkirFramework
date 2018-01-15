using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OzkirFramework.Northwind.Business.Abstract;
using OzkirFramework.Northwind.Entities.Concrete;
using OzkirFramework.Northwind.MVCWebUI.Models;

namespace OzkirFramework.Northwind.MVCWebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Products = _productService.getAll()
            };
            return View(model);
        }

        public string Add()
        {
            _productService.Insert(new Product
                {
                    ProductName = "Asus Fx553VD-DM160",
                    CategoryId = 1,
                    QuantityPerUnit = "1",
                    UnitPrice = 3600,
                    UnitsInStock = 1
                    
                }
            );
            return "Added";
        }

        public string AddUpdate()
        {
            _productService.TransactionalOperation(new Product
                {
                    ProductName = "Computer1234",
                    CategoryId = 1,
                    QuantityPerUnit = "1",
                    UnitPrice = 220,
                    UnitsInStock = 1

                },
                new Product
                {
                    ProductName = "Cascade",
                    CategoryId = 1,
                    QuantityPerUnit = "1",
                    UnitPrice = 30,
                    UnitsInStock = 1,
                    ProductId = 2
                }
            );
            return "DONE";
        }
    }

   
}