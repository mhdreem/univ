using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Univ.Hi_Student_Affairs.Students
{
    public interface IStudentNewRepository : IRepository<StudentNew, int>
    {
        Task<(IQueryable<StudentNew> items, int count)> GetListAsync(
            string filterText,
            string firstNameAR = null,
            string firstNameEn = null,
            string lastNameAr = null,
            string lastNameEn = null,
            string identifier = null,
            string stdCollageId = null,
            string examCollageId = null,
            string sorting = null,
            int maxResultCount = int.MaxValue,
            int skipCount = 0,
            CancellationToken cancellationToken = default);
    }
}
