using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OzkirFramework.Northwind.Business.Abstract;
using OzkirFramework.Northwind.Business.DependencyResolvers.Ninject;
using OzkirFramework.Northwind.Business.ServiceContracts.Wcf;
using OzkirFramework.Northwind.Entities.Concrete;

/// <summary>
/// Summary description for ProductDetailService
/// </summary>
public class ProductDetailService:IProductDetailService
{
    private IProductService _productService=InstanceFactory.GetInstance<IProductService>();
    public List<Product> getAll()
    {
        return _productService.getAll();
    }
}