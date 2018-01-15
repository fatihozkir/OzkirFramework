using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OzkirFramework.Core.CrossCuttingConcerns.Security.Web;
using OzkirFramework.Northwind.Business.Abstract;


namespace OzkirFramework.Northwind.MVCWebUI.Controllers
{
    
    public class AccountController : Controller
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        public ActionResult Login(string userName,string password)
        {
            var user = _userService.GetByUsernameAndPassword(userName, password);
            if (user!=null)
            {
                AuthenticationHelper.CreateAuthCookie(new Guid(),user.UserName,user.Email,DateTime.Now.AddDays(15),_userService.GetUserRoles(user).Select(u=>u.RoleName).ToArray(),false,user.FirstName,user.LastName);
                return RedirectToAction("Index","Product");
            }
            return new HttpStatusCodeResult(401);
        }
    }

   
}