using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.Semester
{
    public interface ISemesterService : ICrudAppService<SemesterDto, int, SemesterPagedAndSortedResultRequestDto, CreateSemesterDto, UpdateSemesterDto>
    {

    }
}

