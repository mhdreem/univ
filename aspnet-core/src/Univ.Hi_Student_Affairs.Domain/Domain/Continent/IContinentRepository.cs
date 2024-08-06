using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Univ.Hi_Student_Affairs
{
    public interface IContinentRepository : IRepository<Continent, int>
    {
    }
}