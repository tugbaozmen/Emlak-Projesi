using EstateProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstateProject.DataAccess.EntityFrameworkCore
{
    public class EstateTypeDAL<TEntity> : BaseDAL<TEntity>, IBaseDAL<TEntity>
         where TEntity : EntityBase
    {
        EstateProjectDBContext context;
        public EstateTypeDAL()
        {
            context = new EstateProjectDBContext();
        }

        public EstateType GetEstateType(int id)
        {
            return context.EstateTypes.SingleOrDefault(a => a.EstateTypeId == id);
        }
    }
}
