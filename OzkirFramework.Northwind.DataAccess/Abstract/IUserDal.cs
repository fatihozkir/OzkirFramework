using System.Collections.Generic;
using OzkirFramework.Core.DataAccess;
using OzkirFramework.Northwind.Entities.ComplexTypes;
using OzkirFramework.Northwind.Entities.Concrete;

namespace OzkirFramework.Northwind.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<UserRoleItem> GetuserRoles(User user);
    }
}