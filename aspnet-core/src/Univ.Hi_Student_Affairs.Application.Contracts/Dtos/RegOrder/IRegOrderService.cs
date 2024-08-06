using System;
using System.Collections.Generic;
using System.Text;
using Univ.Hi_Student_Affairs.Dtos;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.RegOrder
{
    public interface IRegOrderService : ICrudAppService<RegOrderDto, int, RegOrderPagedAndSortedResultRequestDto, CreateRegOrderDto, UpdateRegOrderDto>
    {

    }
}
