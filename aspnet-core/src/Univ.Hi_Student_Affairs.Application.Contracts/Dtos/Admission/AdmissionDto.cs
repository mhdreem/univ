using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.Admission
{
    public class AdmissionDto : EntityDto<int>
    {
        [Required]
        [MaxLength(255)]
        public virtual string NameAr { get; set; }


        [Required]
        [MaxLength(255)]
        public virtual string NameEn { get; set; }


        public virtual int? MinistryEncode { get; set; }
        public virtual string? Barcode { get; set; }
        public virtual int? Ord { get; set; }


        public AdmissionDto()
        {
            NameEn = "";
            NameAr = "";
        }
    }

    public class CreateAdmissionDto
    {
        [Required]
        [MaxLength(255)]
        public virtual string NameAr { get; set; }


        [Required]
        [MaxLength(255)]
        public virtual string NameEn { get; set; }


        public virtual int? MinistryEncode { get; set; }
        public virtual string? Barcode { get; set; }
        public virtual int? Ord { get; set; }



    }


    public class UpdateAdmissionDto : CreateAdmissionDto
    {
        public int Id { get; set; }

    }

    public class CheckAdmissionDto : EntityDto<int?>
    {
        public int? id { get; set; }
        public virtual string? nameAr { get; set; }


        [Required]
        [MaxLength(255)]
        public virtual string? nameEn { get; set; }


        public virtual int? ministryEncode { get; set; }
        public virtual string? barcode { get; set; }
        public virtual int? ord { get; set; }



    }


    public class AdmissionPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        public virtual string? NameAr { get; set; }
        public virtual string? NameEn { get; set; }
        public virtual int? MinistryEncode { get; set; }
        public virtual string? Barcode { get; set; }
        public virtual int? Ord { get; set; }

    }

}
