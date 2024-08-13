using System;
using Univ.Hi_Student_Affairs.Domain.Abstruct;
using Univ.Hi_Student_Affairs.enums;

namespace Univ.Hi_Student_Affairs.Domain.Student.Admission
{
    public class Admission : TEncodeTableEntity<int>
    {
        public virtual Ministry? Ministry { get; private set; }
        //نوع القبول
        public virtual AdmissionKind AdmissionKind { get; private set; }

        //طريقةاحتساب الرسوم
        public virtual FeeCalcType FeeCalcType { get; private set; }

        private void SetAdmissionKind(AdmissionKind admissionKind)
        {
            AdmissionKind = admissionKind;
        }

        public void UpdateAdmissionKind(AdmissionKind admissionKind)
        {
            SetAdmissionKind(admissionKind);
        }

        private void SetFeeCalcType(FeeCalcType feeCalcType)
        {
            FeeCalcType = feeCalcType;
        }

        public void UpdateFeeCalcType(FeeCalcType feeCalcType)
        {
            SetFeeCalcType(feeCalcType);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (Admission)obj;
            return Id == other.Id &&
                   AdmissionKind == other.AdmissionKind &&
                   FeeCalcType == other.FeeCalcType &&
                   NameAr == other.NameAr &&
                   NameEn == other.NameEn &&
                   Ord == other.Ord &&
                   Barcode == other.Barcode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, AdmissionKind, FeeCalcType, NameAr, NameEn, Ord, Barcode);
        }

        public override string ToString()
        {
            return $"[Admission: Id={Id},NameAr={NameAr}, NameEn={NameEn}, Ord={Ord},Barcode={Barcode} ,AdmissionKind={AdmissionKind},FeeCalcType={FeeCalcType}]";
        }


        public Admission(string nameAr, string? nameEn, int? ord, string? barcode, AdmissionKind admissionKind, FeeCalcType feeCalcType)
       : base(nameAr, nameEn, ord, barcode)

        {
            SetAdmissionKind(admissionKind);
            SetFeeCalcType(feeCalcType);

        }

        public Admission(int id, string nameAr, string? nameEn, int? ord, string? barcode, AdmissionKind admissionKind, FeeCalcType feeCalcType)
           : base(id, nameAr, nameEn, ord, barcode)
        {
            SetAdmissionKind(admissionKind);
            SetFeeCalcType(feeCalcType);

        }





    }

}
