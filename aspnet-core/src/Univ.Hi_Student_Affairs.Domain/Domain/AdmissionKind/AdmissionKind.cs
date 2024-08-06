using System.Collections.ObjectModel;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs
{
    public class AdmissionKind : BasicAggregateRoot<int>
    {
        public virtual string NameAr { get; set; }
        public virtual string NameEn { get; set; }
        public virtual int? Ord { get; set; }

        public virtual Collection<Admission>? Admissions { get; protected set; } //Sub collection

        public AdmissionKind(int id, string name_ar, string name_en, int? ord)
        {
            Check.NotNullOrWhiteSpace(name_ar, nameof(name_ar), 255, 3);
            Id = id;
            NameAr = name_ar;
            NameEn = name_en;
            Ord = ord;
            Admissions = new Collection<Admission>();
        }

        protected AdmissionKind()
        {
            NameAr = "";
            NameEn = "";
            Admissions = new Collection<Admission>();
        }
    }
}
