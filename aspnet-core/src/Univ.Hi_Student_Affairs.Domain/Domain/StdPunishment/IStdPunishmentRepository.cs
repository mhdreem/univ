using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Univ.Hi_Student_Affairs.Domain.StdPunishment
{
    public interface IStdPunishmentRepository : IRepository<StdPunishment, Guid>
    {
    }
}