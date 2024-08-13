using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.IdentifierType
{
    public interface IIdentifierTypeService : ICrudAppService<IdentifierTypeDto, int, IdentifierTypePagedAndSortedResultRequestDto, CreateIdentifierTypeDto, UpdateIdentifierTypeDto>
    {

    }
}
