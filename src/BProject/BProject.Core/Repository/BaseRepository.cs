using BProject.Core.Model.Base;
using BProject.Core.Repository.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace BProject.Core.Repository
{
    public class BaseRepository<BProjectEntity> : IRepository<BProjectEntity> 
        where BProjectEntity : BaseEntity
    {
        private readonly BProjectContext Context;
        protected DbSet<BProjectEntity> Entities;

        public BaseRepository()
        {
            Context = new BProjectContext();
            Entities = Context.Set<BProjectEntity>();
        }

        public void eeeee(int id)
        {
            Get(filter: u => u.ID == id, orderBy: u => u.OrderByDescending(x => x.ID), includeProperties: "Customer");
        }

        public virtual IEnumerable<BProjectEntity> Get(
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
            else
            {
                return query.ToList();
            }
        }

        public virtual BProjectEntity Get(int id)
        {

            return Entities.Find(id);
        }

        public IEnumerable<BProjectEntity> GetAll()
        {
            return Entities.ToList();
        }

        public IEnumerable<BProjectEntity> Find(Expression<Func<BProjectEntity, bool>> predicate)
        {
            return Entities.Where(predicate);
        }

        public BProjectEntity SingleOrDefault(Expression<Func<BProjectEntity, bool>> predicate)
        {
            return Entities.Where(predicate).SingleOrDefault();
        }

        public void Add(BProjectEntity entity)
        {
            Entities.Add(entity);
            Context.SaveChanges();
        }

        public void Remove(BProjectEntity entity)
        {
            Entities.Remove(entity);
            Context.SaveChanges();
        }

        public virtual void UpdateEntity(BProjectEntity entityToUpdate)
        {
            Entities.Attach(entityToUpdate);
            Context.Entry(entityToUpdate).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }  
}
            

        
