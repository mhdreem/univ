using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.TypeLic
{
    public class TypeLicBranchDto : EntityDto<int>
    {

        public int? TypeLicId { get; set; }

        //فرع الشهادة

        public string? NameAr { get; set; }
        public string? NameEn { get; set; }



        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }

        public virtual string? Barcode { get; set; }



    }


    public class CreateTypeLicBranchDto
    {

        public int? TypeLicId { get; set; }

        //فرع الشهادة

        public string? NameAr { get; set; }
        public string? NameEn { get; set; }



        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }

        public virtual string? Barcode { get; set; }



    }


    public class UpdateTypeLicBranchDto : CreateTypeLicBranchDto
    {

        public int Id { get; set; }

    }

    public class CheckTypeLicBranchDto : EntityDto<int?>
    {
        public int? TypeLicId { get; set; }


        //فرع الشهادة

        public string? NameAr { get; set; }
        public string? NameEn { get; set; }

        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }

        public virtual string? Barcode { get; set; }



    }


    public class TypeLicBranchPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        //فرع الشهادة

        public string? NameAr { get; set; }
        public string? NameEn { get; set; }



        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }

        public virtual string? Barcode { get; set; }

        public virtual TypeLicDto? TypeLic { get; set; }
    }

}
