using OzkirFramework.Northwind.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OzkirFramework.Northwind.Entities.Concrete;
using OzkirFramework.Northwind.DataAccess.Abstract;
using OzkirFramework.Core.CrossCuttingConcerns.Validation.FluentValidation;
using OzkirFramework.Northwind.Business.ValidationRules.FluentValidation;
using OzkirFramework.Core.Aspects.Postsharp;
using System.Transactions;
using AutoMapper;
using OzkirFramework.Core.Aspects.Postsharp.AuthorizationAspect;
using OzkirFramework.Core.Aspects.Postsharp.CacheAspect;
using OzkirFramework.Core.Aspects.Postsharp.LogAspects;
using OzkirFramework.Core.Aspects.Postsharp.PerformanceAspects;
using OzkirFramework.Core.Aspects.Postsharp.ValidationAspects;
using OzkirFramework.Core.Aspects.Postsharp.TransactionAspects;
using OzkirFramework.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using OzkirFramework.Core.CrossCuttingConcerns.Security.Web;
using OzkirFramework.Core.CrossCuttingConcerns.Validation.Caching.Microsoft;
using OzkirFramework.Core.Utilities.Mappings;

namespace OzkirFramework.Northwind.Business.Concrete.Managers
{

    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        private readonly IMapper _mapper;

        public ProductManager(IProductDal productDal,IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        [PerformanceCounterAspect(2)]
       // [SecuredOperation(Roles = "Admin,Editor,Student")]
        public List<Product> getAll()
        {
            //AutoMapper for WebApi
            var products = _mapper.Map<List<Product>>(_productDal.GetList());
            return products;
        }

        public Product getById(int productId)
        {
            return _productDal.Get(x => x.ProductId == productId);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
       
        public Product Insert(Product product)
        {
            return _productDal.Add(product);
        }

        [TransactionScopeAspect]
        [FluentValidationAspect(typeof(ProductValidator))]
        public void TransactionalOperation(Product product1, Product product2)
        {
            _productDal.Add(product1);
            _productDal.Update(product2);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
    }
}
