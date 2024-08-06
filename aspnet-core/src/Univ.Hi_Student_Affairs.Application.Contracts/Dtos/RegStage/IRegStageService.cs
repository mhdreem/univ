using System;
using System.Collections.Generic;
using System.Text;
using Univ.Hi_Student_Affairs.Dtos;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.RegStage
{
    public interface IRegStageService : ICrudAppService<RegStageDto, int, RegStagePagedAndSortedResultRequestDto, CreateRegStageDto, UpdateRegStageDto>
    {

    }
}
