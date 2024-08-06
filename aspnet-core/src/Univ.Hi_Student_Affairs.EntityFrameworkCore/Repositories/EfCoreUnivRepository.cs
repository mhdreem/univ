using System.Linq;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;


namespace Univ.Hi_Student_Affairs.Repositories
{
    public  class EfCoreUnivRepository : EfCoreRepository<Hi_Student_AffairsDbContext, Univ, int>, IUnivRepository
    {
        public EfCoreUnivRepository(IDbContextProvider<Hi_Student_AffairsDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public override async Task<IQueryable<Univ>> WithDetailsAsync()
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

