using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OzkirFramework.Northwind.DataAccess.Concrete.NHibernate;
using OzkirFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers;

namespace OzkirFramework.DataAccess.Tests.NHibernateTest
{
    [TestClass]
    public class NHibernateTest
    {

        [TestMethod]
        public void Get_all_returns_all_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());
            var result=productDal.GetList();
            Assert.AreEqual(77, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameters_returns_filtered_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());
            var result = productDal.GetList(x => x.ProductName.Contains("ab"));
            Assert.AreEqual(4, result.Count);
        }

        [TestMethod]
        public void Get_all_returns_all_categories()
        {
            NhCategoryDal categoryDal = new NhCategoryDal(new SqlServerHelper());
            var result = categoryDal.GetList();
            Assert.AreEqual(8, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameters_returns_filtered_category()
        {
            NhCategoryDal categoryDal = new NhCategoryDal(new SqlServerHelper());
            var result = categoryDal.GetList(c => c.Description.Contains("sea"));
            Assert.AreEqual(2, result.Count);
        }

    }
}
