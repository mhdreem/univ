using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.EntityFrameworkCore;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Uow;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.Uow;

namespace Univ.Hi_Student_Affairs.Repositories
{
    public class AdvancedRepository<TEntity> : EfCoreRepository<Hi_Student_AffairsDbContext, TEntity>, IAdvancedRepository<TEntity>
    where TEntity : class,IEntity
    {
        public AdvancedRepository(IDbContextProvider<Hi_Student_AffairsDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

       

        [UnitOfWork]
        public virtual async Task SaveWithTransactionAsync(Func<Task> saveAction)
        {
            /*
            using (var unitOfWork = this. BeginTransaction())
            {
                try
                {
                    await saveAction();
                    unitOfWork.Commit();
                }
                catch (Exception ex)
                {
                    unitOfWork.Rollback();
                    // Log the error or return it as needed
                    throw new Exception("An error occurred while saving the transaction.", ex);
                }
            }
            */
        }
      

        public async Task<List<TEntity>> SearchAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var dbSet = await GetDbSetAsync();
            return dbSet.Where(predicate).ToList(); // Consider using async methods if preferred
        }
    }


    public class AdvancedRepository1<TEntity> : IAdvancedRepository1<TEntity> where TEntity : class,IEntity<Guid>
    {
        private readonly IRepository<TEntity, Guid> _repository;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public AdvancedRepository1(IRepository<TEntity, Guid> repository, IUnitOfWorkManager unitOfWorkManager)
        {
            _repository = repository;
            _unitOfWorkManager = unitOfWorkManager;
        }

        public async Task<TEntity> GetAsync(Guid id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _repository.GetListAsync();
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            return await _repository.InsertAsync(entity);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            return await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<List<TEntity>> SearchAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _repository.GetListAsync(predicate);
        }

        public async Task SaveAsync()
        {
            // This method can be used if you want to save some custom changes.
        }

        public async Task ExecuteInTransactionAsync(Func<Task> actions)
        {
            using (var uow = _unitOfWorkManager.Begin())
            {
                try
                {
                    await actions();
                    await uow.CompleteAsync(); // Commit transaction
                }
                catch (Exception ex)
                {
                    // Handle the exception and rollback transaction
                    throw new Exception("Transaction failed", ex);
                }
            }
        }
    }

}
