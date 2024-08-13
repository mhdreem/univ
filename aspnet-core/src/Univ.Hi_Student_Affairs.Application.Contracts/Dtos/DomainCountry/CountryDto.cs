
using Univ.Hi_Student_Affairs.enums;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.DomainCountry
{

    public class CountryDto : EntityDto<int>
    {
        public Continent Continent { get; set; }

        //اسم البلد
        public string NameAr { get; set; } = "";

        //اسم البلد باللغة الانكليزية
        public string? NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }

        public virtual string? Barcode { get; set; }


    }


    public class CreateCountryDto
    {

        public Continent Continent { get; set; }

        //اسم البلد
        public string NameAr { get; set; } = "";

        //اسم البلد باللغة الانكليزية
        public string? NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }

        public virtual string? Barcode { get; set; }



    }


    public class UpdateCountryDto : CreateCountryDto
    {
        public int Id { get; set; }

    }



    public class CheckCountryDto : EntityDto<int?>
    {
        public Continent Continent { get; set; }

        //اسم البلد
        public string NameAr { get; set; } = "";

        //اسم البلد باللغة الانكليزية
        public string? NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }

        public virtual string? Barcode { get; set; }

    }


    public class CountryPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public virtual int? Id { get; set; }
        //اسم البلد
        public string? NameAr { get; set; }

        //اسم البلد باللغة الانكليزية
        public string? NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }

    }

}

