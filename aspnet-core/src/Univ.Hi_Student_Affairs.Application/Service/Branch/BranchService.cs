using AutoMapper;
using Univ.Hi_Student_Affairs.Base;
using Univ.Hi_Student_Affairs.Dtos.Univ;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace Univ.Hi_Student_Affairs.Service
{
    public class BranchService :GenericAppService<Branch, BranchDto, int, PagedResultRequestDto, CreateBranchDto, UpdateBranchDto>
    {
        public BranchService(IRepository<Branch, int> repository, IMapper mapper)
            : base(repository)
        {
            // You can use the injected repository and mapper here
        }

       
    }
}