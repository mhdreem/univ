using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Domain.Initialization_Tables.Admission;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;


using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Univ.Hi_Student_Affairs
{
    public class AdmissionRepository(IDbContextProvider<AbpFilterDbContext> dbContextProvider) : EfCoreRepository<AbpFilterDbContext, Admission, int>(dbContextProvider), IAdmissionRepository {
        public async Task<List<Admission>> GetListAsync(int skipCount, int maxResultCount, string sorting= "Name", AdmissionFilter filter= null) 
        { 
            var dbSet = await GetDbSetAsync();
            var Admissions = await dbSet.WhereIf(filter.Id!= null , x => x.Id.ToString().Contains(filter.Id))
                .WhereIf(!filter.NameAr.IsNullOrWhiteSpace(), x => x.NameAr.Contains(filter.NameAr))
                .WhereIf(!filter.NameEn.IsNullOrWhiteSpace(), x => x.NameEn.Contains(filter.NameEn))
                .OrderBy(sorting).Skip(skipCount).Take(maxResultCount).ToListAsync();
            return Admissions;
        } 
        public async Task<int> GetTotalCountAsync(AdmissionFilter filter) {
            var dbSet = await GetDbSetAsync();
            var Admissions = await dbSet.WhereIf(filter.Id!= null , x => x.Id.ToString().Contains(filter.Id))
                .WhereIf(!filter.NameAr.IsNullOrWhiteSpace(), x => x.NameAr.Contains(filter.NameAr))
                .WhereIf(!filter.NameEn.IsNullOrWhiteSpace(), x => x.NameEn.Contains(filter.NameEn))
                .ToListAsync();

            
                return Admissions.Count; 
        }
    }
}

