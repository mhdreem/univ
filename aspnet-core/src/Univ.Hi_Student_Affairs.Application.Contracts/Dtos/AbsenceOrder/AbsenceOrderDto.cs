using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.AbsenceOrder
{

    public class AbsenceOrderDto : EntityDto<int>
    {
        [Required]
        [MaxLength(255)]
        public virtual string Name { get; set; }


        public virtual AbsenceType? AbsenceType { get; set; }

        public virtual int? Ord { get; set; }

    }

    public class CreateAbsenceOrderDto
    {
        [Required]
        [MaxLength(255)]
        public virtual string Name { get; set; }


        public virtual AbsenceType? AbsenceType { get; set; }

        public virtual int? Ord { get; set; }

    }


    public class UpdateAbsenceOrderDto : CreateAbsenceOrderDto
    {
        public int Id { get; set; }

    }


    public class CheckAbsenceOrderDto : EntityDto<int?>
    {
        public string? Name { get; set; }

        public virtual AbsenceType? AbsenceType { get; set; }

        public int? Ord { get; set; }

    }


    public class AbsenceOrderPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        public virtual string? Name { get; set; }

        public virtual AbsenceType? AbsenceType { get; set; }

        public virtual int? Ord { get; set; }

    }
}
