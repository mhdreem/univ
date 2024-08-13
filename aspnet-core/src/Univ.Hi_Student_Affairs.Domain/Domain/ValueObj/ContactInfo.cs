using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Values;
namespace Univ.Hi_Student_Affairs.Domain.ValueObj
{

    public class ContactInfo : ValueObject
    {

        //العنوان
        [MaxLength(250)]
        public string? Address { get; private set; }


        //مكان الميلاد
        public string? BirthPlaceAr { get; private set; }
        //مكان الولادة بالانكليزية
        public string? BirthPlaceEn { get; private set; }


        //الهاتف الارضي
        [MaxLength(250)]
        public string? Phone { get; private set; }


        //الموبايل
        [MaxLength(250)]
        public string? Mobile { get; private set; }





        [MaxLength(250)]
        public string? Email { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Address;
            yield return BirthPlaceAr;
            yield return BirthPlaceEn;
            yield return Phone;
            yield return Mobile;

        }

    }
}
