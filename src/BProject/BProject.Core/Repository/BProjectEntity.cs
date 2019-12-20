using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BProject.Core.Repository
{
    public interface IRepository <BProjectEntity> where  BProjectEntity : class
    {
        IEnumerable<BProjectEntity> Get(
           Expression<Func<BProjectEntity, bool>> filter = null,
           Func<IQueryable<BProjectEntity>, IOrderedQueryable<BProjectEntity>> orderBy = null,
           string includeProperties = "");

        /// <summary>  
        /// Gets the specified identifier.  
        /// </summary>  
        /// <param name="id">The identifier.</param>  
        /// <returns></returns>  
        BProjectEntity Get(int id);

        /// <summary>  
        /// Gets all.  
        /// </summary>  
        /// <returns></returns>  
        IEnumerable<BProjectEntity> GetAll();

        /// <summary>  
        /// Finds the specified predicate.  
        /// </summary>  
        /// <param name="predicate">The predicate.</param>  
        /// <returns></returns>  
        IEnumerable<BProjectEntity> Find(System.Linq.Expressions.Expression<Func<BProjectEntity, bool>> predicate);

        /// <summary>  
        /// Adds the specified entity.  
        /// </summary>  
        /// <param name="entity">The entity.</param>  
        void Add(BProjectEntity entity);

        /// <summary>  
        /// Removes the specified entity.  
        /// </summary>  
        /// <param name="entity">The entity.</param>  
        void Remove(BProjectEntity entity);

        /// <summary>  
        /// Update the Entity  
        /// </summary>  
        /// <param name="entityToUpdate"></param>  
        void UpdateEntity(BProjectEntity entityToUpdate);
    }

}
