using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OzkirFramework.Northwind.Business.Abstract;
using OzkirFramework.Northwind.Business.DependencyResolvers.Ninject;
using OzkirFramework.Northwind.Entities.Concrete;

/// <summary>
/// Summary description for ProductService
/// </summary>
public class ProductService:IProductService
{
    public ProductService()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private IProductService _productService = InstanceFactory.GetInstance<IProductService>();
    public List<Product> getAll()
    {
        return _productService.getAll();
    }

    public Product getById(int productId)
    {
        return _productService.getById(productId);
    }

    public Product Insert(Product product)
    {
        return _productService.Insert(product);
    }

    public void TransactionalOperation(Product product1, Product product2)
    {
        _productService.TransactionalOperation(product1,product2);
    }

    public Product Update(Product product)
    {
        return _productService.Update(product);
    }
}