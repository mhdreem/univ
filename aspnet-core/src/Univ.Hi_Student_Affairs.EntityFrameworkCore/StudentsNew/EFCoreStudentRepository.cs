using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Students;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Univ.Hi_Student_Affairs.EntityFrameworkCore
{
    public class EFCoreStudentRepository : EfCoreRepository<Hi_Student_AffairsDbContext, StudentNew, int>, IStudentNewRepository
    {
        public EFCoreStudentRepository(IDbContextProvider<Hi_Student_AffairsDbContext> dbContextProvider) : base(dbContextProvider)
        {
            
        }
        public async Task<(IQueryable<StudentNew> items, int count)> GetListAsync(
            string filterText,
            string firstNameAR = null,
            string firstNameEn = null,
            string lastNameAr = null,
            string lastNameEn = null,
            string identifier = null,
            string stdCollageId = null,
            string examCollageId = null,
            string sorting = null,
            int maxResultCount =int.MaxValue,
            int skipCount = 0,
            CancellationToken cancellationToken = default)
        {
            var query = ApplyFilter((await GetQueryableAsync()), filterText, firstNameAR,
                firstNameEn, lastNameAr, lastNameEn, identifier, stdCollageId, examCollageId);
            //query = query.OrderBy(string.IsNullOrWhiteSpace(sorting) ?StudentConsts.GetDefaultSorting(false) : sorting);
            query = query.OrderBy(string.IsNullOrWhiteSpace(sorting) ? "CreationTime desc" : sorting);
            var count = await query.CountAsync(cancellationToken: cancellationToken);
            return (query.PageBy(skipCount, maxResultCount), count);
        }

        protected virtual IQueryable<StudentNew> ApplyFilter(
            IQueryable<StudentNew> query,
            string filterText,
            string firstNameAR = null,
            string firstNameEn =null,
            string lastNameAr = null,
            string lastNameEn = null,
            string identifier = null,
            string stdCollageId = null,
            string examCollageId = null
            )
        {
            return query.WhereIf(!string.IsNullOrWhiteSpace(filterText),
                s => (s.StudentInfo.FirstNameAR != null && s.StudentInfo.FirstNameAR.Contains(filterText))
                || (s.StudentInfo.FirstNameEn != null && s.StudentInfo.FirstNameEn.Contains(filterText))
                || (s.StudentInfo.LastNameAr != null && s.StudentInfo.LastNameAr.Contains(filterText))
                || (s.StudentInfo.LastNameEn != null && s.StudentInfo.LastNameEn.Contains(filterText))
                || (s.StudentInfo.Identifier != null && s.StudentInfo.Identifier.Contains(filterText))
                || (s.StdCollageId != null && s.StdCollageId.Contains(filterText))
                 || (s.ExamCollageId != null && s.ExamCollageId.Contains(filterText)))
                .WhereIf(!string.IsNullOrWhiteSpace(firstNameAR),
                s=>s.StudentInfo.FirstNameAR != null && s.StudentInfo.FirstNameAR.Contains(firstNameAR))
                .WhereIf(!string.IsNullOrWhiteSpace(firstNameEn),
                s => s.StudentInfo.FirstNameEn != null && s.StudentInfo.FirstNameEn.Contains(firstNameEn))
                 .WhereIf(!string.IsNullOrWhiteSpace(lastNameAr),
                 s => s.StudentInfo.LastNameAr != null && s.StudentInfo.LastNameAr.Contains(lastNameAr))
                 .WhereIf(!string.IsNullOrWhiteSpace(lastNameEn),
                 s => s.StudentInfo.LastNameEn != null && s.StudentInfo.LastNameEn.Contains(lastNameEn))
                 .WhereIf(!string.IsNullOrWhiteSpace(identifier),
                 s => s.StudentInfo.Identifier != null && s.StudentInfo.Identifier.Contains(identifier))
                  .WhereIf(!string.IsNullOrWhiteSpace(stdCollageId),
                 s => s.StdCollageId != null && s.StdCollageId.Contains(stdCollageId))
                  .WhereIf(!string.IsNullOrWhiteSpace(examCollageId),
                  s => s.ExamCollageId != null && s.ExamCollageId.Contains(examCollageId));
                 
        }
        
    }
}
