using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReviewsAndRatings.Entities;

namespace ReviewsAndRatings.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        /// <summary>
        /// Add new Entity to the DB
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task Add(TEntity entity);

        /// <summary>
        /// Retrieve Entity by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<TEntity> GetById(Guid Id);

        /// <summary>
        /// Retrieve a Collection of Entity
        /// </summary>
        /// <returns></returns>
        Task<IList<TEntity>> GetAll();

        /// <summary>
        /// Update the Entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task Update(TEntity entity);

        /// <summary>
        /// Remove Entity from DB
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task Remove(Guid Id);

        /// <summary>
        /// Save Changes
        /// </summary>
        /// <returns></returns>
        Task<int> SaveChanges();
    }
}