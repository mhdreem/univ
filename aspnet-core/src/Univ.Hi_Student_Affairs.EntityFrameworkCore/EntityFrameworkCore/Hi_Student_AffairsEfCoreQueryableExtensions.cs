using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Univ.Hi_Student_Affairs.Domain.Country;
using Univ.Hi_Student_Affairs.Domain.StdPunishment;

namespace Univ.Hi_Student_Affairs.EntityFrameworkCore
{
    public static class Hi_Student_AffairsEfCoreQueryableExtensions
    {
        public static IQueryable<StdPunishment> IncludeDetails(this IQueryable<StdPunishment> queryable, bool include = true)
        {
            if (queryable == null)
                throw new ArgumentNullException(nameof(queryable));

            if (!include)
            {
                return queryable;
            }

            return queryable
                .Include(x => x.Punishment)
                .Include(x => x.PunishmentReason)
                .Include(x => x.Class)
                .Include(x => x.Semester)
                .Include(x => x.SemesterEnd)

                .Include(x => x.StdPunishmentStages)
                .ThenInclude(x => x.PunishmentStage)

                .Include(x => x.StdPunishmentStages)
                .ThenInclude(x => x.Punishment);            
        }





        public static IQueryable<Country> IncludeDetails(this IQueryable<Country> queryable, bool include = true)
        {
            if (queryable == null)
                throw new ArgumentNullException(nameof(queryable));

            if (!include)
            {
                return queryable;
            }

            return queryable
                .Include(x => x.Cities);

        }

        public static IQueryable<Univ.Hi_Student_Affairs.Domain.Univ.Univ> IncludeDetails(this IQueryable<Univ.Hi_Student_Affairs.Domain.Univ.Univ> queryable, bool include = true)
        {
            if (queryable == null)
                throw new ArgumentNullException(nameof(queryable));

            if (!include)
            {
                return queryable;
            }

            return queryable
                .Include(x => x.UnivSections)
                .ThenInclude(x => x.Collages)
                .ThenInclude(x => x.Departments)
                .ThenInclude(x => x.Branchs)
                ;

        }



    }
}
