using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Values;
using Univ.Hi_Student_Affairs.enums;
using System.Net;
using System.Numerics;
using System.Reflection;

namespace Univ.Hi_Student_Affairs.ValueObjects
{
    public class StudentInfo : ValueObject
    {
       
        // الاسم
        [MaxLength(250)]
        public string? FirstNameAR { get; set; }

        [MaxLength(250)]
        public string? FirstNameEn { get; set; }

        // الكنية
        [MaxLength(250)]
        public string? LastNameAr { get; set; }
        // الكنية
        [MaxLength(250)]
        public string? LastNameEn { get; set; }


        // اسم الأب
        [MaxLength(250)]
        public string? FatherNameAr { get; set; }

        // اسم الأب
        [MaxLength(250)]
        public string? FatherNameEn { get; set; }

        // اسم الأم
        [MaxLength(250)]
        public string? MotherNameAr { get; set; }
        // اسم الأم
        [MaxLength(250)]
        public string? MotherNameEn { get; set; }
        //الميلاد
        public DateTime? BirthDate { get; set; }

        //الجنس
       public Gender? Gender { get; set; }



        //شعبة التجنيد
        [ForeignKey("MilitaryId")]
        public int? MilitaryId { get; set; }
        public virtual Military? Military { get; set; }





        //الرقم الوطني

        [ForeignKey("IdentifierTypeId")]
        public int? IdentifierTypeId { get; set; }
        public virtual IdentifierType? IdentifierType { get; set; }


        //الرقم الوطني
        [MaxLength(250)]
        public string? Identifier { get; set; }


        //الهاتف الارضي
        [MaxLength(250)]
        public string? Phone { get; set; }


        //الموبايل
        [MaxLength(250)]
        public string? Mobile { get; set; }



        



        //العنوان
        [MaxLength(250)]
        public string? Address { get; set; }


        //مكان الميلاد
        public string? BirthPlaceAr { get; set; }
        //مكان الولادة بالانكليزية
        public string? BirthPlaceEn { get; set; }






        [MaxLength(250)]
        public string? Email { get; set; }

        public bool? IsForeign { get; set; }

        public bool? IsArab { get; set; }


        public byte[]? PhotoData { get; set; }
        public StudentInfo()
        {
            
        }
        private StudentInfo(string firstNameAR, string firstNameEn, string lastNameAr, string lastNameEn,
            string fatherNameAr, string fatherNameEn, string motherNameAr, string motherNameEn,
            DateTime birthDate, Gender gender, int militaryId, int identifierTypeId, string identifier,
            string phone, string mobile, string address, string birthPlaceAr, string birthPlaceEn,
              string email, bool isForeign, bool isArab, byte[] photoData)
        {
           
            FirstNameAR = firstNameAR;
            FirstNameEn = firstNameEn;
            LastNameAr = lastNameAr;
            LastNameEn = lastNameEn;
            FatherNameAr = fatherNameAr;
            FatherNameEn = fatherNameEn;
            MotherNameAr = motherNameAr;
            MotherNameEn = motherNameEn;
            BirthDate = birthDate;
            Gender = gender;
            MilitaryId = militaryId;
            IdentifierTypeId = identifierTypeId;
            Identifier = identifier;
            Phone = phone;
            Mobile = mobile;
           
            Address = address;
            BirthPlaceAr = birthPlaceAr;
            BirthPlaceEn = birthPlaceEn;
           
            Email = email;
            IsForeign = isForeign;
            IsArab = isArab;
            PhotoData = photoData;
        }
        public static StudentInfo create(string firstNameAR, string firstNameEn, string lastNameAr, string lastNameEn,
            string fatherNameAr, string fatherNameEn, string motherNameAr, string motherNameEn,
           DateTime birthDate, Gender gender, int militaryId, int identifierTypeId, string identifier,
            string phone, string mobile, string address, string birthPlaceAr, string birthPlaceEn,
             string email, bool isForeign, bool isArab, byte[] photoData)
        {
            return new StudentInfo(firstNameAR,
               firstNameEn, lastNameAr, lastNameEn, fatherNameAr, fatherNameEn, motherNameAr,
              motherNameEn, birthDate, gender, militaryId, identifierTypeId, identifier,
             phone, mobile, address, birthPlaceAr, birthPlaceEn, email,
             isForeign, isArab,  photoData);
        }
        public void update(string firstNameAR, string firstNameEn, string lastNameAr, string lastNameEn,
            string fatherNameAr, string fatherNameEn, string motherNameAr, string motherNameEn,
           DateTime birthDate, Gender gender, int militaryId, int identifierTypeId, string identifier,
            string phone, string mobile, string address, string birthPlaceAr, string birthPlaceEn,
             string email, bool isForeign, bool isArab, byte[] photoData)
        {
           
            FirstNameAR = firstNameAR;
            FirstNameEn = firstNameEn;
            LastNameAr = lastNameAr;
            LastNameEn = lastNameEn;
            FatherNameAr = fatherNameAr;
            FatherNameEn = fatherNameEn;
            MotherNameAr = motherNameAr;
            MotherNameEn = motherNameEn;
            BirthDate = birthDate;
            Gender = gender;
            MilitaryId = militaryId;
            IdentifierTypeId = identifierTypeId;
            Identifier = identifier;
            Phone = phone;
            Mobile = mobile;
            Address = address;
            BirthPlaceAr = birthPlaceAr;
            BirthPlaceEn = birthPlaceEn;
            Email = email;
            IsForeign = isForeign;
            IsArab = isArab;
            PhotoData = photoData;
        }
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return FirstNameAR ;
            yield return FirstNameEn;
            yield return LastNameAr;
            yield return LastNameEn;
            yield return FatherNameAr ;
            yield return FatherNameEn ;
            yield return MotherNameAr;
            yield return MotherNameEn;
            yield return BirthDate ;
            yield return Gender;
            yield return MilitaryId;
            yield return IdentifierTypeId;
            yield return Identifier;
            yield return Phone;
            yield return Mobile;
            yield return Address;
            yield return BirthPlaceAr;
            yield return BirthPlaceEn ;
            yield return Email;
            yield return IsForeign;
            yield return IsArab;
            yield return PhotoData;
        }
    }
}
