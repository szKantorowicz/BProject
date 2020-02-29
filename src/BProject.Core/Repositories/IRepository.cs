using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BProject.Core.Models.Base;

namespace BProject.Core.Repositories
{
    public interface IRepository<TBProjectEntity> where  TBProjectEntity : BaseEntity
    {
        TBProjectEntity Get(int id);
        TBProjectEntity FindSpecific(Expression<Func<TBProjectEntity, bool>> predicate);
        IEnumerable<TBProjectEntity> GetAll();
        IEnumerable<TBProjectEntity> Find(Expression<Func<TBProjectEntity, bool>> predicate);

        IEnumerable<TBProjectEntity> GetMany(
            Expression<Func<TBProjectEntity, bool>> filter = null,
            Func<IQueryable<TBProjectEntity>, IOrderedQueryable<TBProjectEntity>> orderBy = null,
            string includeProperties = "");

        void Add(TBProjectEntity entity);
        void Update(TBProjectEntity entityToUpdate);
        void Remove(TBProjectEntity entity);
    }

}
