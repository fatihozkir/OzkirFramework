using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OzkirFramework.Northwind.Business.Abstract;

namespace OzkirFramework.Northwind.MVCWebUI.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public ActionResult Index()
        {
            return View(_orderService.getAllOrders());
        }
    }
}