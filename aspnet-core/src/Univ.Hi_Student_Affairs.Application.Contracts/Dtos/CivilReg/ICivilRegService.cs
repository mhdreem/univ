using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.CivilReg
{
    public interface ICivilRegService : ICrudAppService<CivilRegDto, int, CivilRegPagedAndSortedResultRequestDto, CreateCivilRegDto, UpdateCivilRegDto>
    {

    }

}
