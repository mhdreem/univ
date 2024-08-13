using System;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.Abstruct;

namespace Univ.Hi_Student_Affairs.Domain.Univ
{
    public class Branch : TEncodeTableEntity<int>
    {
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; private set; }



        private void SetDepartmentId(int departmentId)
        {

            DepartmentId = departmentId;
        }

        public void UpdateDepartmentId(int departmentId)
        {
            SetDepartmentId(departmentId);
        }






        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (Branch)obj;
            return Id == other.Id &&
                   DepartmentId == other.DepartmentId &&
                   NameAr == other.NameAr &&
                   NameEn == other.NameEn &&
                   Ord == other.Ord &&
                   Barcode == other.Barcode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, DepartmentId, NameAr, NameEn, Ord, Barcode);
        }

        public override string ToString()
        {
            return $"[Branch: Id={Id}, DepartmentId={DepartmentId}, NameAr={NameAr}, NameEn={NameEn}, Ord={Ord},Barcode={Barcode} ]";
        }



        public Branch(string nameAr, string? nameEn, int? ord, string? barcode, int departmentId)
            : base(nameAr, nameEn, ord, barcode)

        {
            SetDepartmentId(departmentId);

        }

        public Branch(int id, string nameAr, string nameEn, int? ord, string barcode, int departmentId)
           : base(id, nameAr, nameEn, ord, barcode)
        {
            SetDepartmentId(departmentId);

        }





    }
}


