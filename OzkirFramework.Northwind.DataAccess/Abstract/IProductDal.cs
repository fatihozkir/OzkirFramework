using OzkirFramework.Core.DataAccess;
using OzkirFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using OzkirFramework.Core.DataAccess.EntityFramework;
using OzkirFramework.Northwind.DataAccess.Concrete.EntityFramework;
using OzkirFramework.Northwind.Entities.ComplexTypes;

namespace OzkirFramework.Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
   
}
