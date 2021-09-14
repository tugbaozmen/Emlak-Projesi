using EstateProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstateProject.DataAccess.EntityFrameworkCore
{
    public class BaseDAL<TEntity> : IBaseDAL<TEntity>
        where TEntity : EntityBase
    {
        DbSet<TEntity> entities;
        EstateProjectDBContext context;
        public BaseDAL()
        {
            context = new EstateProjectDBContext();
            entities = context.Set<TEntity>();
        }

        public int Add(TEntity entity)
        {
            entities.Add(entity);
            return context.SaveChanges();
        }

        public int Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChanges();
        }

        public int Delete(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            return context.SaveChanges();

        }

        public TEntity Get(int id)
        {
            return entities.SingleOrDefault();
        }

        public ICollection<TEntity> GetAll()
        {
            return entities.ToList();
        }

    }
}
