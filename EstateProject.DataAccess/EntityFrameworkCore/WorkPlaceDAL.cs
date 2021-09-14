using EstateProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstateProject.DataAccess.EntityFrameworkCore
{
    public class WorkPlaceDAL<TEntity> : BaseDAL<TEntity>, IBaseDAL<TEntity>
         where TEntity : EntityBase
    {
        EstateProjectDBContext context;
        public WorkPlaceDAL()
        {
            context = new EstateProjectDBContext();
        }

        public WorkPlace GetWorkPlace(int id)
        {
            return context.WorkPlaces.SingleOrDefault(a => a.WorkPlaceId == id);
        }
    }
}
