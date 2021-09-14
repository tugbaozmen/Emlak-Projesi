using EstateProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstateProject.DataAccess.EntityFrameworkCore
{
    public class UserDAL<TEntity> : BaseDAL<TEntity>, IBaseDAL<TEntity>
         where TEntity : EntityBase
    {
        EstateProjectDBContext context;
        public UserDAL()
        {
            context = new EstateProjectDBContext();
        }

        public User GetUser(int id)
        {
            return context.Users.SingleOrDefault(a => a.UserId == id);
        }
    }
}
