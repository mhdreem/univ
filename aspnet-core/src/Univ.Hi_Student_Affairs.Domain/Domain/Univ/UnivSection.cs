using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Univ.Hi_Student_Affairs.Domain.Abstruct;
using Univ.Hi_Student_Affairs.enums;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Univ
{

    public class UnivSection : TEncodeTableEntity<int>
    {


        [ForeignKey("UnivId")]
        public int UnivId { get; private set; }


        public virtual ICollection<Collage>? Collages { get; protected private set; } //Sub collection

        private void SetUnivId(int univId)
        {
            UnivId = univId;
        }

        public void UpdateUnivId(int univId)
        {
            SetUnivId(univId);
        }




        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (UnivSection)obj;
            return Id == other.Id &&
                   UnivId == other.UnivId &&
                   NameAr == other.NameAr &&
                   NameEn == other.NameEn &&
                   Ord == other.Ord &&
                   Barcode == other.Barcode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, UnivId, NameAr, NameEn, Ord, Barcode, Collages);
        }

        public override string ToString()
        {
            return $"[UnivSection: Id={Id}, UnivId={UnivId}, NameAr={NameAr}, NameEn={NameEn}, Ord={Ord},Barcode={Barcode},Collages={Collages}]";
        }

        public UnivSection(string nameAr, string? nameEn, int? ord, string? barcode, int univId)
           : base(nameAr, nameEn, ord, barcode)

        {
            SetUnivId(univId);

        }

        public UnivSection(string nameAr, string? nameEn, int? ord, string? barcode, int univId, ICollection<Collage>? collages)
            : base(nameAr, nameEn, ord, barcode)

        {
            SetUnivId(univId);
            Collages = collages ?? new List<Collage>();
        }

        public UnivSection(int id, string nameAr, string nameEn, int? ord, string barcode, int univId, ICollection<Collage>? collages)
           : base(id, nameAr, nameEn, ord, barcode)
        {
            SetUnivId(univId);
            Collages = collages ?? new List<Collage>();
        }


        public UnivSection RemoveCollage(int collageId)
        {
            if (Collages is null ||
                Collages.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            var Collage = Collages.SingleOrDefault(x => x.Id == collageId);
            if (Collage is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);
            }
            Collages.Remove(Collage);

            return this;
        }





        public UnivSection AddCollage(
             string nameAr, string? nameEn, int? ord, string? barcode, int univSectionId, string? deanAr, string? deanEn, int? numYear, Degree degree, string? degreeNameAr, string? degreeNameEn, ColType colType, ColClassification colClassification, ICollection<Department>? departments, ICollection<StudyPlan>? studyPlans
             )
        {
            if (Collages is null ||
                Collages.Count() == 0)
                Collages = new List<Collage>();


            if (Collages.Where(x => x.NameAr != null && x.NameAr.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            if (Collages.Where(x => x.NameEn != null && x.NameEn.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            if (!string.IsNullOrWhiteSpace(barcode) &&
                Collages.Where(x => x.Barcode != null && x.Barcode.Equals(barcode)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            Collages.Add(new Collage(nameAr, nameEn, ord, barcode, univSectionId, deanAr, deanEn, numYear, degree, degreeNameAr, degreeNameEn, colType, colClassification, departments, studyPlans));

            // Raise domain event
            //AddDomainEvent(new CollageAddedDomainEvent(this, city));

            return this;
        }



        public UnivSection UpdateCollage(
             int collageId,
              string nameAr, string? nameEn, int? ord, string? barcode, int univSectionId, string? deanAr, string? deanEn, int? numYear, Degree degree, string? degreeNameAr, string? degreeNameEn, ColType colType, ColClassification colClassification, ICollection<Department>? departments, ICollection<StudyPlan>? studyPlans
            )
        {
            if (Collages is null ||
                Collages.Count() == 0)
                Collages = new List<Collage>();

            var Collage = Collages.Where(x => x.Id == collageId).FirstOrDefault();
            if (Collage is null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);




            if (Collages.Where(x => x.NameAr != null && x.Id != collageId && x.NameAr.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            if (Collages.Where(x => x.NameEn != null && x.Id != collageId && x.NameEn.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            if (!string.IsNullOrWhiteSpace(barcode) &&
                Collages.Where(x => !string.IsNullOrWhiteSpace(x.Barcode) && x.Id != collageId && x.Barcode.Equals(barcode)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);



            Collage.UpdateNameAr(nameAr);
            Collage.UpdateNameEn(nameEn);
            Collage.SetNameEn(nameEn);
            Collage.SetOrd(ord);
            Collage.SetBarcode(barcode);


            // Raise domain event
            //AddDomainEvent(new CollageUpdateDomainEvent(this, city));

            return this;
        }



        public Collage GetCollage(int collageId)
        {
            if (Collages is null ||
                Collages.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            var Collage = Collages.Single(x => x.Id == collageId);
            if (Collage is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);
            }
            return Collage;
        }


    }

}
