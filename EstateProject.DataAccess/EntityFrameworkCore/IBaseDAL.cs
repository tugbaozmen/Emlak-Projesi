using EstateProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstateProject.DataAccess.EntityFrameworkCore
{
    public interface IBaseDAL<TEntity>
      where TEntity : EntityBase
    {
        int Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
        TEntity Get(int id);
        ICollection<TEntity> GetAll();
    }
}
