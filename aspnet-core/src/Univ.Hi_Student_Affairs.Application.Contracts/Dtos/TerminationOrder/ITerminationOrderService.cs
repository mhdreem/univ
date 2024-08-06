using System;
using System.Collections.Generic;
using System.Text;
using Univ.Hi_Student_Affairs.Dtos;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.TerminationOrder
{
    public interface ITerminationOrderService : ICrudAppService<TerminationOrderDto, int, TerminationOrderPagedAndSortedResultRequestDto, CreateTerminationOrderDto, UpdateTerminationOrderDto>
    {

    }


}
