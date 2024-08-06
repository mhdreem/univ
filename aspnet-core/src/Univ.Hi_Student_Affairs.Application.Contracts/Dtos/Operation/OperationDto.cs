using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.Operation
{
    public class OperationDto : EntityDto<int>
    {
        
        public virtual string? Name { get; set; }


    }

    public class CreateOperationDto 
    {

        public virtual string? Name { get; set; }


    }

    public class UpdateOperationDto:CreateOperationDto
    {

        public int Id { get; set; }


    }



    public class CheckOperationDto : EntityDto<int>
    {
        public string? Name { get; set; }



    }
    public class OperationPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public int? Id { get; set; }
        public virtual string? Name { get; set; }



    }
}
