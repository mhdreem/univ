using Volo.Abp.Application.Services;

namespace Univ.Hi_Student_Affairs.Dtos.Admission
{
    public interface IAdmissionService : ICrudAppService<AdmissionDto, int, AdmissionPagedAndSortedResultRequestDto, CreateAdmissionDto, UpdateAdmissionDto>
    { }
}
