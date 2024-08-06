using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Identity;

namespace Univ.Hi_Student_Affairs.EntityFrameworkCore
{
    public static class Hi_Student_AffairsEfCoreQueryableExtensions
    {
        public static IQueryable<Continent> IncludeDetails(this IQueryable<Continent> queryable, bool include = true)
        {
            if (queryable== null)
                throw new ArgumentNullException(nameof(queryable));

            if (!include)
            {
                return queryable;
            }

            return queryable
                .Include(x => x.Countries)
                .ThenInclude(x => x.Cities);
                
        }

        public static IQueryable<Univ> IncludeDetails(this IQueryable<Univ> queryable, bool include = true)
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
