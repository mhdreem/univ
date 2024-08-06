using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.FeeCalcType
{
    public interface IFeeCalcTypeService : ICrudAppService<FeeCalcTypeDto, int, FeeCalcTypePagedAndSortedResultRequestDto, CreateFeeCalcTypeDto, UpdateFeeCalcTypeDto>
    {

    }
}

