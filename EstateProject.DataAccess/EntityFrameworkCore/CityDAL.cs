using EstateProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstateProject.DataAccess.EntityFrameworkCore
{
    public class CityDAL<TEntity> : BaseDAL<TEntity>, IBaseDAL<TEntity>
         where TEntity : EntityBase
    {
        EstateProjectDBContext context;
        public CityDAL()
        {
            context = new EstateProjectDBContext();
        }

        public City GetCity(int id)
        {
            return context.Cities.SingleOrDefault(a => a.CityId == id);
        }
    }
}
