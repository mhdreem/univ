using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.AdmissionKind
{
    public class AdmissionKindDto : EntityDto<int>
    {
        [Required]
        [MaxLength(255)]
        public virtual string NameAr { get; set; }

        [Required]
        [MaxLength(255)]
        public virtual string NameEn { get; set; }

        public virtual int? Ord { get; set; }
    }

    public class CreateAdmissionKindDto
    {
        [Required]
        [MaxLength(255)]
        public virtual string NameAr { get; set; }

        [Required]
        [MaxLength(255)]
        public virtual string NameEn { get; set; }

        public virtual int? Ord { get; set; }
    }


    public class UpdateAdmissionKindDto : CreateAdmissionKindDto
    {
        public int Id { get; set; }

    }

    public class AdmissionKindPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }
        public virtual int? Ord { get; set; }

    }

    public class CheckAdmissionKindDto : EntityDto<int?>
    {
        public string? NameAr { get; set; }

        public string? NameEn { get; set; }

        public int? Ord { get; set; }
    }
}
