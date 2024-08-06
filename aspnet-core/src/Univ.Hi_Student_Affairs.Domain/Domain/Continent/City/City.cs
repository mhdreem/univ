using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities;
using System;
using Volo.Abp;
namespace Univ.Hi_Student_Affairs
{

    public class City : Entity<int>
    {



        [ForeignKey("CountryId")]        
        public Country Country { get; set; }
        public int CountryId { get; private set; }


        //اسم المدينة بالعربي
        public string NameAr { get; set; }

        //اسم المدينة بالانكليزي
        public string NameEn { get; set; }




        //الترتيب
        public int? Ord { get; set; }

        //رمز نداء المدينة
        public string? PhoneCode { get; set; }


        //رمز المدينة بوزارة التعليم
        public string? Barcode { get; set; }


        //رمز المدينة بوزارة التعليم
        public int? MinistryEncode { get; set; }



        public City()
        {
            NameAr = "";
            NameEn = "";
        }

        public City(int id, int countryId, string nameAr, string nameEn, int? ord, string? phoneCode, string? barcode, int? ministryEncode)
            : base(id)
        {
            NameAr = Check.NotNullOrWhiteSpace(nameAr, nameof(nameAr), CityConsts.MaxNameArLength, 2);
            NameEn = Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn), CityConsts.MaxNameArLength, 2);
            CountryId = countryId;
            Ord = ord;
            PhoneCode = phoneCode;
            Barcode = barcode;
            MinistryEncode = ministryEncode;
        }


      




    }
}
