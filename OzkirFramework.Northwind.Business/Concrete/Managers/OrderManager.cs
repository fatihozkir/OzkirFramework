using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzkirFramework.Northwind.Business.Abstract;
using OzkirFramework.Northwind.Entities.Concrete;

namespace OzkirFramework.Northwind.Business.Concrete.Managers
{
    public class OrderManager:IOrderService
    {
        private IOrderService _orderService;

        public OrderManager(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public List<Order> getAllOrders()
        {
            return _orderService.getAllOrders();
        }
    }
}
