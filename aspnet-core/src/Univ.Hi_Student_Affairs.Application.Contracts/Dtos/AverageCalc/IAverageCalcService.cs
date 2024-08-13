using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.AverageCalc
{
    public interface IAverageCalcService : ICrudAppService<AverageCalcDto, int, AverageCalcPagedAndSortedResultRequestDto, CreateAverageCalcDto, UpdateAverageCalcDto>
    {
    }
}
