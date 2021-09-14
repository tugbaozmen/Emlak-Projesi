using EstateProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstateProject.DataAccess.EntityFrameworkCore
{
    public class UserRoleDAL<TEntity> : BaseDAL<TEntity>, IBaseDAL<TEntity>
         where TEntity : EntityBase
    {
        EstateProjectDBContext context;
        public UserRoleDAL()
        {
            context = new EstateProjectDBContext();
        }

        public UserRole GetUserRole(int id)
        {
            return context.UserRoles.SingleOrDefault(a => a.UserRoleId == id);
        }
    }
}
