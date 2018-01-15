using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OzkirFramework.Northwind.Business.Abstract;
using OzkirFramework.Northwind.Business.Concrete.Managers;
using OzkirFramework.Northwind.DataAccess.Abstract;
using OzkirFramework.Northwind.Entities.Concrete;

namespace OzkirFramework.Northwind.MVCWebUI.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void ExceptionLog()
        {
            Mock<IProductDal> service=new Mock<IProductDal>();
            ProductManager productManager=new ProductManager(service.Object);
            productManager.TransactionalOperation(new Product
                {
                    ProductName = "Computer",
                    CategoryId = 1,
                    QuantityPerUnit = "1",
                    UnitPrice = 10,
                    UnitsInStock = 1

                },
                new Product
                {
                    ProductName = "Computer 2",
                    CategoryId = 1,
                    QuantityPerUnit = "1",
                    UnitPrice = 30,
                    UnitsInStock = 1,
                    ProductId = 2
                }
            );
        }
    }
}
