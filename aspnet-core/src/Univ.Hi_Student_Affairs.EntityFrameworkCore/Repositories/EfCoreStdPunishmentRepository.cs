using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Domain.StdPunishment;
using Univ.Hi_Student_Affairs.Domain.Univ;
using Univ.Hi_Student_Affairs.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Univ.Hi_Student_Affairs.Repositories
{
    internal class EfCoreStdPunishmentRepository : EfCoreRepository<Hi_Student_AffairsDbContext, StdPunishment, Guid>, IStdPunishmentRepository
    {
        public EfCoreStdPunishmentRepository(IDbContextProvider<Hi_Student_AffairsDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public override async Task<IQueryable<StdPunishment>> WithDetailsAsync()
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