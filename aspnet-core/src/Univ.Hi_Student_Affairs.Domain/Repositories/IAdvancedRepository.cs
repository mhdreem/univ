using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Univ.Hi_Student_Affairs.Repositories
{
    public interface IAdvancedRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        Task SaveWithTransactionAsync(Func<Task> saveAction);
        Task<List<TEntity>> SearchAsync(Expression<Func<TEntity, bool>> predicate);
    }


    public interface IAdvancedRepository1<TEntity>
    {
        Task<TEntity> GetAsync(Guid id);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> InsertAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task DeleteAsync(Guid id);
        Task<List<TEntity>> SearchAsync(Expression<Func<TEntity, bool>> predicate);

        Task SaveAsync();
        Task ExecuteInTransactionAsync(Func<Task> actions);
    }

}
