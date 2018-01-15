using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OzkirFramework.Northwind.Entities.Concrete;

namespace OzkirFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserRoleMap:EntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            ToTable(@"UserRoles", @"dbo");
            HasKey(ur => ur.UserRoleId);
            Property(ur => ur.UserRoleId).HasColumnName("UserRoleId");
            Property(ur => ur.RoleId).HasColumnName("RoleId");
            Property(ur => ur.UserId).HasColumnName("UserId");
        }
    }
}
