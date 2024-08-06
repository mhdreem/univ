using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Univ.Hi_Student_Affairs
{
    public class StdCertificate : FullAuditedAggregateRoot<Guid>
    {
        [ForeignKey("StudentId")]
        public Guid? StudentId { get; set; }
        public virtual Student? Student { get; set; }




        [ForeignKey("CountryId")]
        public int? CountryId { get; set; }
        public virtual Country? Country { get; set; }



        [ForeignKey("CityId")]
        public int? CityId { get; set; }
        public virtual City? City { get; set; }


        [ForeignKey("TypeLicId")]
        public int? TypeLicId { get; set; }
        public virtual TypeLic? TypeLic { get; set; }



        [ForeignKey("TypeLicBranchId")]
        public int? TypeLicBranchId { get; set; }
        public virtual TypeLicBranch? TypeLicBranch { get; set; }


        //عام الشهادة
        public int? Year { get; set; }

        //طالب محلي
        public bool? ForeignCert { get; set; }

        //صحة المعلومات
        public bool? IsForeignCertCorrect { get; set; }

        //تصحيح الشهادة
        public string? ForeignCertCorrect { get; set; }




        //رقم الاكتتاب
        public string? No { get; set; }



        //الترتيب
        public int Ord { get; set; }


        //ملاحظات
        public string? Note { get; set; }


        public uint? TotalMark { get; set; }

        public uint? TotalNet { get; set; }




    }
}
