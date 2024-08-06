using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.Identity;
using Univ.Hi_Student_Affairs.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Univ.Hi_Student_Affairs.Repositories
{
    public class EfCoreContinentRepository : EfCoreRepository<Hi_Student_AffairsDbContext, Continent, int>, IContinentRepository
    {
        public EfCoreContinentRepository(IDbContextProvider<Hi_Student_AffairsDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public override async Task<IQueryable<Continent>> WithDetailsAsync()
        {
            /*
            //1
            return (await GetQueryableAsync())
                .Include(e => e.Countries)
                .ThenInclude(t => t.Cities);
            */
            //2
            return (await GetQueryableAsync()).IncludeDetails();
        }
    }
}
