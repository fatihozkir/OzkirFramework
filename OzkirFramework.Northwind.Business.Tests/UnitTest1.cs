using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OzkirFramework.Northwind.Business.Concrete.Managers;
using OzkirFramework.Northwind.DataAccess.Abstract;
using OzkirFramework.Northwind.DataAccess.Concrete.EntityFramework;
using OzkirFramework.Northwind.Entities.Concrete;

namespace OzkirFramework.Northwind.Business.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(mock.Object);
            productManager.Insert(new Product {ProductName = "Asus",CategoryId = 1,QuantityPerUnit = "one box",UnitPrice = 3620});
        }

        [TestMethod]
        public void Test()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(mock.Object);
            productManager.getAll();
        }
    }
}
