using BProject.Core.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BProject.Core.Repository.Base
{
    public interface IRepository<BProjectEntity> where  BProjectEntity : BaseEntity
    {
        IEnumerable<BProjectEntity> Get(
           Expression<Func<BProjectEntity, bool>> filter = null,
           Func<IQueryable<BProjectEntity>, IOrderedQueryable<BProjectEntity>> orderBy = null,
           string includeProperties = "");

        BProjectEntity Get(int id);
        IEnumerable<BProjectEntity> GetAll();
        IEnumerable<BProjectEntity> Find(Expression<Func<BProjectEntity, bool>> predicate);
        void Add(BProjectEntity entity);
        void Remove(BProjectEntity entity);
        void UpdateEntity(BProjectEntity entityToUpdate);
    }

}
