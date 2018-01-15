using Ninject.Modules;
using OzkirFramework.Core.DataAccess;
using OzkirFramework.Core.DataAccess.EntityFramework;
using OzkirFramework.Core.DataAccess.NHibernate;
using OzkirFramework.Northwind.Business.Abstract;
using OzkirFramework.Northwind.Business.Concrete.Managers;
using OzkirFramework.Northwind.DataAccess.Abstract;
using OzkirFramework.Northwind.DataAccess.Concrete.EntityFramework;
using OzkirFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzkirFramework.Northwind.DataAccess.Concrete.NHibernate;

namespace OzkirFramework.Northwind.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind<IUserService>().To<UserManager>();
            Bind<IUserDal>().To<EfUserDal>();

            Bind<IOrderService>().To<OrderManager>().InSingletonScope();
            Bind<IOrderDal>().To<EfOrderDal>().InSingletonScope();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<NorthwindContext>();
            Bind<NHibernateHelper>().To<SqlServerHelper>();
        }
    }

}
