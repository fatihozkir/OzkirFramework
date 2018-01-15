using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzkirFramework.Core.DataAccess.EntityFramework;
using OzkirFramework.Northwind.DataAccess.Abstract;
using OzkirFramework.Northwind.Entities.Concrete;

namespace OzkirFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, NorthwindContext>, IOrderDal
    {
    }
}
