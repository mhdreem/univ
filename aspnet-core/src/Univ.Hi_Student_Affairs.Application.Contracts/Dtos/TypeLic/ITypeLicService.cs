using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.TypeLic
{
    public interface ITypeLicService : ICrudAppService<TypeLicDto, int, TypeLicPagedAndSortedResultRequestDto, CreateTypeLicDto, UpdateTypeLicDto>
    {

    }



}
