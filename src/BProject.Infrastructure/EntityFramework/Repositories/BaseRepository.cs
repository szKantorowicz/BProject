using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using BProject.Core.Models.Base;
using BProject.Core.Repositories;

namespace BProject.Infrastructure.EntityFramework.Repositories
{
    public class BaseRepository<BProjectEntity> : IRepository<BProjectEntity> 
        where BProjectEntity : BaseEntity
    {
        protected readonly BProjectContext Context;
        protected DbSet<BProjectEntity> Entities;

        protected BaseRepository()
        {
            Context = new BProjectContext();
            Entities = Context.Set<BProjectEntity>();
        }

        public BProjectEntity Get(int id)
        {
            return Entities.Find(id);
        }

        public BProjectEntity FindSpecific(Expression<Func<BProjectEntity, bool>> predicate)
        {
            return Entities.SingleOrDefault(predicate);
        }

        public IEnumerable<BProjectEntity> GetAll()
        {
            return Entities.ToList();
        }

        public IEnumerable<BProjectEntity> Find(Expression<Func<BProjectEntity, bool>> predicate)
        {
            return Entities.Where(predicate);
        }


        public IEnumerable<BProjectEntity> GetMany(
            Expression<Func<BProjectEntity, bool>> filter = null,
            Func<IQueryable<BProjectEntity>, IOrderedQueryable<BProjectEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<BProjectEntity> query = Entities;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }

            return query.ToList();
        }

        public void Add(BProjectEntity entity)
        {
            Entities.Add(entity);
        }

        public void Update(BProjectEntity entityToUpdate)
        {
            Entities.Attach(entityToUpdate);
            Context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public void Remove(BProjectEntity entity)
        {
            Entities.Remove(entity);
        }
    }  
}
            

        
