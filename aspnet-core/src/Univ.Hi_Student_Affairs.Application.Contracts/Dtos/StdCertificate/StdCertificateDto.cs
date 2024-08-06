using System;
using System.Collections.Generic;
using System.Text;
using Univ.Hi_Student_Affairs.Dtos.Continent;
using Univ.Hi_Student_Affairs.Dtos.TypeLic;
using Volo.Abp.Application.Dtos;

namespace Univ.Hi_Student_Affairs.Dtos.StdCertificate
{
    public class StdCertificateDto : FullAuditedEntityDto<Guid>
    {
        
        public Guid? StudentId { get; set; }
        public virtual StudentDto? Student { get; set; }




        
        public int? CountryId { get; set; }
        public virtual CountryDto? Country { get; set; }


        
        public int? CityId { get; set; }
        public virtual CityDto? City { get; set; }


        
        public int? TypeLicId { get; set; }
        public virtual TypeLicDto? TypeLic { get; set; }



        
        public int? TypeLicBranchId { get; set; }
        public virtual TypeLicBranchDto? TypeLicBranch { get; set; }

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
