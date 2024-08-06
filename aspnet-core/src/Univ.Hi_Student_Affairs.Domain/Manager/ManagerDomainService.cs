using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Domain.Admission;
using Volo.Abp.Domain.Repositories;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace Univ.Hi_Student_Affairs.Manager
{
    public abstract class ManagerDomainService<TEntity, TPrimaryKey>:DomainService
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
