
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.Continent
{

    public class CountryDto :  EntityDto<int>
    {

        //اسم البلد
        public string? NameAr { get; set; }

        //اسم البلد باللغة الانكليزية
        public string? NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }

        public int? ContinentId { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }


     

    }


    public class CreateCountryDto 
    {

        //اسم البلد
        public string? NameAr { get; set; }

        //اسم البلد باللغة الانكليزية
        public string? NameEn { get; set; }

        //الترتيب
        public int? Ord { get; set; }

        public int? ContinentId { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? MinistryEncode { get; set; }


        public virtual string? Barcode { get; set; }




    }


    public class UpdateCountryDto:CreateCountryDto
    {
        public int Id { get; set; }

    }



    public class CheckCountryDto
    {
        public int? id { get; set; }
        //اسم البلد
        public string? nameAr { get; set; }

        //اسم البلد باللغة الانكليزية
        public string? nameEn { get; set; }

        //الترتيب
        public int? ord { get; set; }

        public int? continentId { get; set; }


        //رمز الفرع بوزارة التعليم
        public virtual int? ministryEncode { get; set; }


        public virtual string? barcode { get; set; }




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

