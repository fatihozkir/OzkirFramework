using OzkirFramework.Core.DataAccess.NHibernate;
using OzkirFramework.Northwind.DataAccess.Abstract;
using OzkirFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzkirFramework.Northwind.Entities.ComplexTypes;
using NHibernate.Linq;

namespace OzkirFramework.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDal
    {
        private NHibernateHelper _nHibernameHelper;
        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernameHelper = nHibernateHelper;
        }

        public List<ProductDetail> GetProductDetails()
        {
            using (var session=_nHibernameHelper.OpenSession())
            {
                var result = from p in session.Query<Product>()
                             join c in session.Query<Category>() on p.CategoryId equals c.CategoryID
                             select new ProductDetail
                             {
                                 CategoryName = c.CategoryName,
                                 ProductID = p.ProductId,
                                 ProductName = p.ProductName
                             };
                return result.ToList();
            }
        }
    }
}
