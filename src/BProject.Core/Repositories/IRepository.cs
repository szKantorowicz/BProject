using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BProject.Core.Models.Base;

namespace BProject.Core.Repositories
{
    public interface IRepository<TBProjectEntity> where  TBProjectEntity : BaseEntity
    {
        IEnumerable<TBProjectEntity> Get(
           Expression<Func<TBProjectEntity, bool>> filter = null,
           Func<IQueryable<TBProjectEntity>, IOrderedQueryable<TBProjectEntity>> orderBy = null,
           string includeProperties = "");

        TBProjectEntity Get(int id);
        IEnumerable<TBProjectEntity> GetAll();
        IEnumerable<TBProjectEntity> Find(Expression<Func<TBProjectEntity, bool>> predicate);
        void Add(TBProjectEntity entity);
        void Remove(TBProjectEntity entity);
        void UpdateEntity(TBProjectEntity entityToUpdate);
    }

}
