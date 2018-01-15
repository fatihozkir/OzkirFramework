using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzkirFramework.Northwind.Entities.Concrete;

namespace OzkirFramework.Northwind.Business.Abstract
{
    public interface IOrderService
    {
        List<Order> getAllOrders();
    }
}
