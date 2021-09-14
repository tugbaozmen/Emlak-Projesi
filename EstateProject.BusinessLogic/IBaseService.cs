using System;
using System.Collections.Generic;
using System.Text;

namespace EstateProject.BusinessLogic
{
    public interface IBaseService<TEntity>
    {
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        TEntity GetById(int id);
        List<TEntity> GetAll();
    }
}
