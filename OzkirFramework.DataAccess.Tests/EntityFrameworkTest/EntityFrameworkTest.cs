using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OzkirFramework.Northwind.DataAccess.Concrete.EntityFramework;

namespace OzkirFramework.DataAccess.Tests.EntityFrameworkTest
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();
            var result = productDal.GetList();
            Assert.AreEqual(77, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameters_returns_filtered_products()
        {
            EfProductDal productDal = new EfProductDal();
            var result = productDal.GetList(p => p.ProductName.Contains("ab"));
            Assert.AreEqual(4, result.Count);
        }

        [TestMethod]
        public void Get_all_returns_all_categories()
        {
            EfCategoryDal categoryDal = new EfCategoryDal();
            var result = categoryDal.GetList();
            Assert.AreEqual(8, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameters_returns_filtered_category()
        {
            EfCategoryDal categoryDal = new EfCategoryDal();
            var result = categoryDal.GetList(c => c.Description.Contains("sea"));
            Assert.AreEqual(2, result.Count);
        }
        [TestMethod]
        public void MyTestMethod()
        {
            EfProductDal productDal = new EfProductDal();
            var result=productDal.GetProductDetails();
            Assert.AreEqual(77, result.Count);
        }

        

    }
}
