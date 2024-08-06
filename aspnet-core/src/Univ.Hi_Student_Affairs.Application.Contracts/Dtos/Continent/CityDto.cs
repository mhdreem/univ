using System;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.Continent
{

    public class CityDto : EntityDto<int>
    {
        public int CountryId { get; set; }

        //اسم المدينة بالعربي
        public string NameAr { get; set; }= string.Empty;

        //اسم المدينة بالانكليزي
        public string NameEn { get; set; } = string.Empty;

      

        //الترتيب
        public int? Ord { get; set; }

        //رمز نداء المدينة
        public string? PhoneCode { get; set; }


        //رمز المدينة بوزارة التعليم
        public string? Barcode { get; set; }


        //رمز المدينة بوزارة التعليم
        public int? MinistryEncode { get; set; }

        

    }



    public class CreateCityDto 
    {
        public int CountryId { get; set; }

        //اسم المدينة بالعربي
        public string NameAr { get; set; } = string.Empty;

        //اسم المدينة بالانكليزي
        public string NameEn { get; set; } = string.Empty;



        //الترتيب
        public int? Ord { get; set; }

        //رمز نداء المدينة
        public string? PhoneCode { get; set; }


        //رمز المدينة بوزارة التعليم
        public string? Barcode { get; set; }


        //رمز المدينة بوزارة التعليم
        public int? MinistryEncode { get; set; }



    }


    public class UpdateCityDto : CreateCityDto
    {
        public int Id { get; set; }
    }


    public class CheckCityDto
    {
        public int? Id { get; set; }
        public string? NameAr { get; set; }

        public string? NameEn { get; set; }

        public int? Ord { get; set; }




    }


}
