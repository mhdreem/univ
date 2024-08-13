using System.Collections.ObjectModel;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.TypeLic
{

    public class TypeLicDto : EntityDto<int>
    {
        //الشهادة الثانوية
        public virtual string NameAr { get; set; }


        //الشهادة باللغة الاجنبية
        public virtual string NameEn { get; set; }




        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }


        public virtual int? Ord { get; set; }

        public virtual Collection<TypeLicBranchDto> TypeLicBranchs { get; protected set; } //Sub collection



    }


    public class CreateTypeLicDto
    {
        //الشهادة الثانوية
        public virtual string NameAr { get; set; }


        //الشهادة باللغة الاجنبية
        public virtual string NameEn { get; set; }

        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }


        public virtual int? Ord { get; set; }

        public virtual Collection<TypeLicBranchDto> TypeLicBranchs { get; protected set; } //Sub collection

    }


    public class UpdateTypeLicDto : CreateTypeLicDto
    {
        public int Id { get; set; }

    }

    public class CheckTypeLicDto : EntityDto<int?>
    {
        public int? Id { get; set; }
        //الشهادة الثانوية
        public virtual string NameAr { get; set; }


        //الشهادة باللغة الاجنبية
        public virtual string NameEn { get; set; }




        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }


        public virtual int? Ord { get; set; }



    }


    public class TypeLicPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        //الشهادة الثانوية
        public virtual string? NameAr { get; set; }


        //الشهادة باللغة الاجنبية
        public virtual string? NameEn { get; set; }




        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }

    }

}
