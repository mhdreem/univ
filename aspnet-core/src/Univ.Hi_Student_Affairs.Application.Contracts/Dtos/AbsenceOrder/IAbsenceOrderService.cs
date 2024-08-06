using System;
using System.Collections.Generic;
using System.Text;
using Univ.Hi_Student_Affairs.Dtos;
using Univ.Hi_Student_Affairs.Dtos.AbsenceOrder;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.IApplicationService
{
   
    public interface IAbsenceOrderService : ICrudAppService<AbsenceOrderDto, int, AbsenceOrderPagedAndSortedResultRequestDto, CreateAbsenceOrderDto,UpdateAbsenceOrderDto>
    {

    }

}
