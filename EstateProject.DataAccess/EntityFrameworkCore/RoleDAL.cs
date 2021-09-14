using EstateProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstateProject.DataAccess.EntityFrameworkCore
{
    public class RoleDAL<TEntity> : BaseDAL<TEntity>, IBaseDAL<TEntity>
         where TEntity : EntityBase
    {
        EstateProjectDBContext context;
        public RoleDAL()
        {
            context = new EstateProjectDBContext();
        }

        public Role GetRole(int id)
        {
            return context.Roles.SingleOrDefault(a => a.RoleId == id);
        }
    }
}
