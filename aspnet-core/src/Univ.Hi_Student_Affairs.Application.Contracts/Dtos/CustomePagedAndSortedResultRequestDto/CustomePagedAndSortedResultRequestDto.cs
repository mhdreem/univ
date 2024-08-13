using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.CustomePagedAndSortedResultRequestDto
{
    public class CustomePagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public Dictionary<string, object> Filters { get; set; } = new Dictionary<string, object>();
    }

}
