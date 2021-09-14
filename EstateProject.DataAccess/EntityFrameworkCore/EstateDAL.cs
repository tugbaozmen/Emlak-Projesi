using EstateProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstateProject.DataAccess.EntityFrameworkCore
{
    public class EstateDAL<TEntity> : BaseDAL<TEntity>, IBaseDAL<TEntity>
         where TEntity : EntityBase
    {
        EstateProjectDBContext context;
        public EstateDAL()
        {
            context = new EstateProjectDBContext();
        }

        public Estate GetEstate(int id)
        {
            return context.Estates.SingleOrDefault(a => a.EstateId == id);
        }
    }
}
