using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.FeeCalcType
{
    public interface IFeeCalcTypeService : ICrudAppService<FeeCalcTypeDto, int, FeeCalcTypePagedAndSortedResultRequestDto, CreateFeeCalcTypeDto, UpdateFeeCalcTypeDto>
    {

    }
}

