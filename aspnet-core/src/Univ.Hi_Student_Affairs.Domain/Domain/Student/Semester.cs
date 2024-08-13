using System;
using Univ.Hi_Student_Affairs.Domain.Abstruct;

namespace Univ.Hi_Student_Affairs.Domain.Student
{

    public class Semester : TEncodeTableEntity<int>
    {
        //فصل الشهادة
        public virtual string? GradeNameAr { get; private set; }
        public virtual string? GradeNameEn { get; private set; }





        private void SetGradeNameAr(string? gradeNameAr)
        {
            GradeNameAr = gradeNameAr;
        }

        public void UpdateGradeNameAr(string? gradeNameAr)
        {
            SetGradeNameAr(gradeNameAr);
        }

        private void SetGradeNameEn(string? gradeNameEn)
        {
            GradeNameEn = gradeNameEn;
        }

        public void UpdateGradeNameEn(string? gradeNameEn)
        {
            SetGradeNameEn(gradeNameEn);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (Semester)obj;
            return Id == other.Id &&
                   NameAr == other.NameAr &&
                   NameEn == other.NameEn &&
                   Ord == other.Ord &&
                   Barcode == other.Barcode &&
                   GradeNameAr == other.GradeNameAr &&
                   GradeNameEn == other.GradeNameEn;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, NameAr, NameEn, Ord, Barcode, GradeNameAr, GradeNameEn);
        }

        public override string ToString()
        {
            return $"[Semester: Id={Id},NameAr={NameAr}, NameEn={NameEn}, Ord={Ord},Barcode={Barcode} ,GradeNameAr={GradeNameAr},GradeNameEn={GradeNameEn}]";
        }


        public Semester(string nameAr, string? nameEn, int? ord, string? barcode, string? gradeNameAr, string? gradeNameEn)
       : base(nameAr, nameEn, ord, barcode)

        {
            SetGradeNameAr(gradeNameAr);
            SetGradeNameEn(gradeNameEn);

        }

        public Semester(int id, string nameAr, string? nameEn, int? ord, string? barcode, string? gradeNameAr, string? gradeNameEn)
           : base(id, nameAr, nameEn, ord, barcode)
        {
            SetGradeNameAr(gradeNameAr);
            SetGradeNameEn(gradeNameEn);

        }





    }

}

