using ELearning.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Data.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        /// <summary>
        /// Get all records
        /// </summary>
        /// <returns>A list of all records of type T</returns>
        Task<List<T>> GetAllAsync();

        /// <summary>
        /// Get record by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The record with the specified ID, or null if not found</returns>
        Task<T> GetByIdAnsync(int? id);

        /// <summary>
        /// Create a new record
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> CreateAsync(T entity);

        /// <summary>
        /// Update a existing record
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> UpdateASync(T entity);

        /// <summary>
        /// Delete a record
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> DeleteAsync(T entity);
    }
}
