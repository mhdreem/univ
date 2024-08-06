using Volo.Abp;
using Volo.Abp.Domain.Entities;
using JetBrains.Annotations;

namespace Univ.Hi_Student_Affairs
{
    public class Admission : BasicAggregateRoot<int>
    {
        //نوع القبول
        public virtual string NameAr { get; set; }
        public virtual string? NameEn { get; set; }
        public virtual int? MinistryEncode { get; set; }
        public virtual string? Barcode { get; set; }
        
        //الترتيب
        public virtual int? Ord { get; set; }


        //نوع القبول
        public virtual AdmissionKind? AdmissionKind { get; set; }


        //طريقةاحتساب الرسوم
        public virtual FeeCalcType? FeeCalcType { get; set; }

        /*
         * هام
         */
        //يمكن وضع حقل يحدد طريقة احتساب الرسم



        public Admission(int id, string name_ar, string name_en, int? MinistryEncode, string? Barcode, int? ord)
        {
            Check.NotNullOrWhiteSpace(name_ar, nameof(name_ar), 255, 3);
            Id = id;
            NameAr = name_ar;
            NameEn = name_en;
            Ord = ord;
            this.MinistryEncode = MinistryEncode;
            this.Barcode = Barcode;
        }

        protected Admission()
        {
            NameAr = "";
        }


        internal Admission ChangeNameAr([NotNull] string name)
        {
            SetNameAr(name);
            return this;
        }

        private void SetNameAr([NotNull] string nameAr)
        {
            NameAr = Check.NotNullOrWhiteSpace(
                nameAr,
                nameof(nameAr),
                maxLength: 255
            );
        }

        private void SetNameEn([NotNull] string nameEn)
        {
            NameEn = Check.NotNullOrWhiteSpace(
                nameEn,
                nameof(NameEn),
                maxLength: 255
            );
        }

        internal Admission ChangeNameEn([NotNull] string nameEn)
        {
            SetNameEn(nameEn);
            return this;
        }



    }
}
