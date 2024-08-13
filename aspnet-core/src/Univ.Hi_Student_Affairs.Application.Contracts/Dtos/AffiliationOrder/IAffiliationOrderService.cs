using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.AffiliationOrder
{
    public interface IAffiliationOrderService : ICrudAppService<AffiliationOrderDto, int, AffiliationOrderPagedAndSortedResultRequestDto, CreateAffiliationOrderDto, UpdateAffiliationOrderDto>
    {

    }
}
