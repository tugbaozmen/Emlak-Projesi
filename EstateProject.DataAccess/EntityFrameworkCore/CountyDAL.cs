using EstateProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstateProject.DataAccess.EntityFrameworkCore
{
    public class CountyDAL<TEntity> : BaseDAL<TEntity>, IBaseDAL<TEntity>
         where TEntity : EntityBase
    {
        EstateProjectDBContext context;
        public CountyDAL()
        {
            context = new EstateProjectDBContext();
        }

        public County GetCounty(int id)
        {
            return context.Counties.SingleOrDefault(a => a.CountyId == id);
        }
    }
}
