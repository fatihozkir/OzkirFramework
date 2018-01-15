using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzkirFramework.Northwind.Business.Abstract;
using OzkirFramework.Northwind.DataAccess.Abstract;
using OzkirFramework.Northwind.Entities.ComplexTypes;
using OzkirFramework.Northwind.Entities.Concrete;

namespace OzkirFramework.Northwind.Business.Concrete.Managers
{
    public class UserManager:IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetByUsernameAndPassword(string userName, string password)
        {
            return _userDal.Get(u => u.UserName == userName & u.Password == password);
        }

        public List<UserRoleItem> GetUserRoles(User user)
        {
            return _userDal.GetuserRoles(user);
        }
    }
}
