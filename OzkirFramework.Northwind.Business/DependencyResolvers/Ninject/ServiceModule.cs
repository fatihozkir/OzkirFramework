using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using OzkirFramework.Core.Utilities.Common;
using OzkirFramework.Northwind.Business.Abstract;

namespace OzkirFramework.Northwind.Business.DependencyResolvers.Ninject
{
    public class ServiceModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().ToConstant(WcfProxy<IProductService>.CreateChannel());

        }
    }
}
