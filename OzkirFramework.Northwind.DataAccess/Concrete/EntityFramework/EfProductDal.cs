using OzkirFramework.Northwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzkirFramework.Northwind.Entities.Concrete;
using System.Linq.Expressions;
using OzkirFramework.Core.DataAccess.EntityFramework;
using OzkirFramework.Northwind.Entities.ComplexTypes;

namespace OzkirFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (var context=new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.CategoryID
                             select new ProductDetail
                             {
                                 ProductID=p.ProductId,
                                 CategoryName=c.CategoryName,
                                 ProductName=p.ProductName
                             };
                return result.ToList();
            }
        }
    }
}
