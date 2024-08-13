using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs.Domain.StdCertificate
{
    public class StdCertificate : FullAuditedAggregateRoot<Guid>
    {
        [ForeignKey("StudentId")]
        public Guid? StudentId { get; private set; }





        [ForeignKey("CountryId")]
        public int? CountryId { get; private set; }
        public virtual Country.Country? Country { get; private set; }



        [ForeignKey("CityId")]
        public int? CityId { get; private set; }
        public virtual Country.City? City { get; private set; }


        [ForeignKey("TypeLicId")]
        public int? TypeLicId { get; private set; }




        [ForeignKey("TypeLicBranchId")]
        public int? TypeLicBranchId { get; private set; }



        //عام الشهادة
        public int? Year { get; private set; }

        //طالب محلي
        public bool? ForeignCert { get; private set; }

        //صحة المعلومات
        public bool? IsForeignCertCorrect { get; private set; }

        //تصحيح الشهادة
        public string? ForeignCertCorrect { get; private set; }




        //رقم الاكتتاب
        public string? No { get; private set; }



        //الترتيب
        public int Ord { get; private set; }


        //ملاحظات
        public string? Note { get; private set; }


        public uint? TotalMark { get; private set; }

        public uint? TotalNet { get; private set; }




    }
}
