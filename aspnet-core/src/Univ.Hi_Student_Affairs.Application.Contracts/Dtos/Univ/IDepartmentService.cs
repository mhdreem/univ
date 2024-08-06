using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.Univ
{
    public interface IDepartmentService : ICrudAppService<DepartmentDto, int, DepartmentPagedAndSortedResultRequestDto, CreateDepartmentDto,UpdateDepartmentDto>
    {

    }
}