using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Univ.Hi_Student_Affairs.Domain.Initialization_Tables.Admission
{
    public interface IAdmissionRepository : IRepository<Admission, int>
    {
        Task<Admission> FindByNameArAsync(string nameAr);

        Task<List<Admission>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            AdmissionFilter filter = null
        );
    }
}
