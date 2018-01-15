using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzkirFramework.Northwind.Entities.ComplexTypes;
using OzkirFramework.Northwind.Entities.Concrete;

namespace OzkirFramework.Northwind.Business.Abstract
{
    public interface IUserService
    {
        User GetByUsernameAndPassword(string userName,string password);
        List<UserRoleItem> GetUserRoles(User user);
    }
}
