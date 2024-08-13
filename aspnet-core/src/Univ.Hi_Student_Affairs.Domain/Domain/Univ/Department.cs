using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Univ.Hi_Student_Affairs.Domain.Abstruct;
using Volo.Abp;

namespace Univ.Hi_Student_Affairs.Domain.Univ
{

    public class Department : TEncodeTableEntity<int>
    {
        public virtual string? DegreeNameAr { get; private set; }
        public virtual string? DegreeNameEn { get; private set; }

        [ForeignKey("CollageId")]
        public int CollageId { get; private set; }


        public virtual ICollection<Branch>? Branchs { get; protected private set; } //Sub collection

        private void SetCollageId(int collageId)
        {
            CollageId = collageId;
        }

        public void UpdateCollageId(int collageId)
        {
            SetCollageId(collageId);
        }

        private void SetDegreeNameAr(string? degreeNameAr)
        {
            DegreeNameAr = degreeNameAr;
        }

        public void UpdateDegreeNameAr(string? degreeNameAr)
        {
            SetDegreeNameAr(degreeNameAr);
        }

        private void SetDegreeNameEn(string? degreeNameEn)
        {
            DegreeNameEn = degreeNameEn;
        }

        public void UpdateDegreeNameEn(string? degreeNameEn)
        {
            SetDegreeNameEn(degreeNameEn);
        }






        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (Department)obj;
            return Id == other.Id &&
                   CollageId == other.CollageId &&
                   NameAr == other.NameAr &&
                   NameEn == other.NameEn &&
                   Ord == other.Ord &&
                   Barcode == other.Barcode &&
                   CollageId == other.CollageId &&
                   DegreeNameAr == other.DegreeNameAr &&
                   DegreeNameEn == other.DegreeNameEn
                   ;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, CollageId, NameAr, NameEn, Ord, Barcode, Branchs);
        }

        public override string ToString()
        {
            return $"[Department: Id={Id}, CollageId={CollageId}, NameAr={NameAr}, NameEn={NameEn}, Ord={Ord},Barcode={Barcode},DegreeNameAr={DegreeNameAr},DegreeNameEn={DegreeNameEn} ,Branchs={Branchs}]";
        }

        public Department(string nameAr, string? nameEn, int? ord, string? barcode, int collageId)
            : base(nameAr, nameEn, ord, barcode)

        {
            SetCollageId(collageId);

        }

        public Department(string nameAr, string? nameEn, int? ord, string? barcode, int collageId, ICollection<Branch>? branchs)
            : base(nameAr, nameEn, ord, barcode)

        {
            SetCollageId(collageId);
            Branchs = branchs ?? new List<Branch>();
        }

        public Department(int id, string nameAr, string nameEn, int? ord, string barcode, int collageId, ICollection<Branch>? branchs)
           : base(id, nameAr, nameEn, ord, barcode)
        {
            SetCollageId(collageId);
            Branchs = branchs ?? new List<Branch>();
        }


        public Department RemoveBranch(int branchId)
        {
            if (Branchs is null ||
                Branchs.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            var Branch = Branchs.SingleOrDefault(x => x.Id == branchId);
            if (Branch is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);
            }
            Branchs.Remove(Branch);

            return this;
        }





        public Department AddBranch(
             string nameAr, string nameEn, int? ord, string? barcode
             )
        {
            if (Branchs is null ||
                Branchs.Count() == 0)
                Branchs = new List<Branch>();


            if (Branchs.Where(x => x.NameAr != null && x.NameAr.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            if (Branchs.Where(x => x.NameEn != null && x.NameEn.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);

            if (!string.IsNullOrWhiteSpace(barcode) &&
                Branchs.Where(x => x.Barcode != null && x.Barcode.Equals(barcode)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            Branchs.Add(new Branch(nameAr, nameEn, ord, barcode, this.Id));

            // Raise domain event
            //AddDomainEvent(new BranchAddedDomainEvent(this, city));

            return this;
        }



        public Department UpdateBranch(
             int branchId,
              string nameAr, string nameEn, int? ord, string? barcode
            )
        {
            if (Branchs is null ||
                Branchs.Count() == 0)
                Branchs = new List<Branch>();

            var Branch = Branchs.Where(x => x.Id == branchId).FirstOrDefault();
            if (Branch is null)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);




            if (Branchs.Where(x => x.NameAr != null && x.Id != branchId && x.NameAr.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            if (Branchs.Where(x => x.NameEn != null && x.Id != branchId && x.NameEn.Equals(nameAr)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            if (!string.IsNullOrWhiteSpace(barcode) &&
                Branchs.Where(x => !string.IsNullOrWhiteSpace(x.Barcode) && x.Id != branchId && x.Barcode.Equals(barcode)).Any())
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);




            Branch.UpdateNameAr(nameAr);
            Branch.UpdateNameEn(nameEn);
            Branch.SetNameEn(nameEn);
            Branch.SetOrd(ord);
            Branch.SetBarcode(barcode);


            // Raise domain event
            //AddDomainEvent(new BranchUpdateDomainEvent(this, city));

            return this;
        }



        public Branch GetBranch(int branchId)
        {
            if (Branchs is null ||
                Branchs.Count == 0)
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);


            var Branch = Branchs.Single(x => x.Id == branchId);
            if (Branch is null)
            {
                throw new BusinessException(Hi_Student_AffairsDomainErrorCodes.CityNameEnAlreadyExists);
            }
            return Branch;
        }


    }

}


