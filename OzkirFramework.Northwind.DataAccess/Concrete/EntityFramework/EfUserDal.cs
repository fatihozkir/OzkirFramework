using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzkirFramework.Core.DataAccess.EntityFramework;
using OzkirFramework.Northwind.DataAccess.Abstract;
using OzkirFramework.Northwind.Entities.ComplexTypes;
using OzkirFramework.Northwind.Entities.Concrete;

namespace OzkirFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,NorthwindContext>,IUserDal
    {
        public List<UserRoleItem> GetuserRoles(User user)
        {
            using (var context=new NorthwindContext())
            {
                var result = from ur in context.UserRoles
                    join r in context.Roles
                        on ur.UserId equals user.UserId
                    where ur.UserId == user.UserId
                    select new UserRoleItem {RoleName = r.Name};
                return result.ToList();
            }
        }
    }
}
