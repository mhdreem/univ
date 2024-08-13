using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.Language
{
    public interface ILanguageService : ICrudAppService<LanguageDto, int, LanguagePagedAndSortedResultRequestDto, CreateLanguageDto, UpdateLanguageDto>
    {

    }
}


