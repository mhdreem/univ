using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.Class
{
    public interface IClassService : ICrudAppService<ClassDto, int, ClassPagedAndSortedResultRequestDto, CreateClassDto, UpdateClassDto>
    {
    }
}

