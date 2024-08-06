using System;
using System.Collections.Generic;
using System.Text;
using Univ.Hi_Student_Affairs.Dtos;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.SubExamStatus
{

    public interface ISubExamStatusService : ICrudAppService<SubExamStatusDto, int, SubExamStatusPagedAndSortedResultRequestDto, CreateSubExamStatusDto, UpdateSubExamStatusDto>
    {

    }

}
