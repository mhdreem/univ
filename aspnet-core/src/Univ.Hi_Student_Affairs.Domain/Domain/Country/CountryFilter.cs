using Univ.Hi_Student_Affairs.enums;

namespace Univ.Hi_Student_Affairs.Domain.Country
{
    public class CountryFilter
    {
        //اسم البلد
        public string? NameAr { get; set; }

        //اسم البلد باللغة الانكليزية
        public string? NameEn { get; set; }

        public Continent Continent { get; set; }


        //الترتيب
        public int? Ord { get; set; }





        public virtual string? Barcode { get; set; }

    }
}
