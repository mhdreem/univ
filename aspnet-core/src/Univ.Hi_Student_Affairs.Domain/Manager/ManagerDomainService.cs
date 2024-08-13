using JetBrains.Annotations;

using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace Univ.Hi_Student_Affairs.Manager
{
    public abstract class ManagerDomainService<TEntity, TPrimaryKey> : DomainService
    {



        public ManagerDomainService()
        {

        }



        public abstract Task<TEntity> CreateAsync(TEntity input);



        public abstract Task<TEntity> UpdateAsync(
            [NotNull] TPrimaryKey id,
            [NotNull] TEntity input
            );


    }
}
