using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.Student;
using Univ.Hi_Student_Affairs.enums;
using Volo.Abp.Domain.Values;


namespace Univ.Hi_Student_Affairs.Domain.ValueObj
{

    public class StudentProfile : ValueObject
    {
        //الجنسية

        public virtual Nationality? Nationality { get; private set; }


        //بلد الولادة
        [ForeignKey("CountryId")]
        public int? CountryId { get; private set; }
        public virtual Country.Country? Country { get; private set; }


        // الاسم
        [MaxLength(250)]
        public string FirstNameAR { get; private set; } = "";

        [MaxLength(250)]
        public string? FirstNameEn { get; private set; }

        // الكنية
        [MaxLength(250)]
        public string LastNameAr { get; private set; } = "";
        // الكنية
        [MaxLength(250)]
        public string? LastNameEn { get; private set; }


        // اسم الأب
        [MaxLength(250)]
        public string FatherNameAr { get; private set; } = "";

        // اسم الأب
        [MaxLength(250)]
        public string? FatherNameEn { get; private set; }

        // اسم الأم
        [MaxLength(250)]
        public string MotherNameAr { get; private set; } = "";
        // اسم الأم
        [MaxLength(250)]
        public string? MotherNameEn { get; private set; }


        //عام الميلاد
        public int? YearBirth { get; private set; }
        //شهر الميلاد
        public int? MonthBirth { get; private set; }
        //يوم الميلاد
        public int? DayBirth { get; private set; }


        //الجنس
        public Jender? Jender { get; private set; }


        //نوع المعرف

        [ForeignKey("IdentifierTypeId")]
        public int? IdentifierTypeId { get; private set; }
        public virtual IdentifierType? IdentifierType { get; private set; }


        //الرقم الوطني
        [MaxLength(250)]
        public string? Identifier { get; private set; }


        public byte[]? Data { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {

            yield return Nationality;
            yield return CountryId;
            yield return Country;
            yield return FirstNameAR;
            yield return FirstNameEn;
            yield return LastNameAr;
            yield return LastNameEn;
            yield return FatherNameAr;
            yield return FatherNameEn;
            yield return MotherNameAr;
            yield return MotherNameEn;
            yield return YearBirth;
            yield return MonthBirth;
            yield return DayBirth;
            yield return Jender;
            yield return IdentifierTypeId;
            yield return IdentifierType;
            yield return Identifier;



        }

    }
}


