﻿using System;
using Univ.Hi_Student_Affairs.Domain.Abstruct;

namespace Univ.Hi_Student_Affairs.Domain.Student
{

    public class IdentifierType : TEncodeTableEntity<int>
    {

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (IdentifierType)obj;
            return Id == other.Id &&
            NameAr == other.NameAr &&
                   NameEn == other.NameEn &&
                   Ord == other.Ord &&
                   Barcode == other.Barcode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, NameAr, NameEn, Ord, Barcode);
        }

        public override string ToString()
        {
            return $"[IdentifierType: Id={Id},NameAr={NameAr}, NameEn={NameEn}, Ord={Ord},Barcode={Barcode} ]";
        }


        public IdentifierType(string nameAr, string? nameEn, int? ord, string? barcode)
       : base(nameAr, nameEn, ord, barcode)

        {


        }

        public IdentifierType(int id, string nameAr, string? nameEn, int? ord, string? barcode)
           : base(id, nameAr, nameEn, ord, barcode)
        {

        }

    }

}