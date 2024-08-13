using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.SeqResult
{
    public interface ISeqResultService : ICrudAppService<SeqResultDto, int, SeqResultPagedAndSortedResultRequestDto, CreateSeqResultDto, UpdateSeqResultDto>
    {

    }
}
