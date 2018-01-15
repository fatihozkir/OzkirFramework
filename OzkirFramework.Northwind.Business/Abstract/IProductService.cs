using OzkirFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OzkirFramework.Northwind.Business.Abstract
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        List<Product> getAll();
        [OperationContract]
        Product getById(int productId);
        [OperationContract]
        Product Insert(Product product);
        [OperationContract]
        Product Update(Product product);
        [OperationContract]
        void TransactionalOperation(Product product1,Product product2);

    }
}
