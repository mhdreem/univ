using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Domain.Abstruct
{
    public abstract class TEncodeTableAggregateRoot<TKey> : BasicAggregateRoot<TKey>
    {
        protected TEncodeTableAggregateRoot(TKey id, string nameAr, string? nameEn, int? ord, string? barcode)
        {
            if (string.IsNullOrEmpty(nameAr))
            {
                throw new ArgumentException("Invalid nameAr ", nameof(nameAr));
            }

            SetNameAr(nameAr);
            NameEn = nameEn;
            SetOrd(ord);
            Id = id;
            Barcode = barcode;
        }

        protected TEncodeTableAggregateRoot(string nameAr, string? nameEn, int? ord, string? barcode)
        {
            if (string.IsNullOrEmpty(nameAr))
            {
                throw new ArgumentException("Invalid nameAr ", nameof(nameAr));
            }

            SetNameAr(nameAr);
            NameEn = nameEn;
            SetOrd(ord);
            Barcode = barcode;
        }

        public string NameAr { get; private set; }
        public string? NameEn { get; private set; }
        public int? Ord { get; private set; }
        public string? Barcode { get; private set; }

        public void SetNameAr(string nameAr)
        {
            if (string.IsNullOrWhiteSpace(nameAr))
            {
                throw new ArgumentException("Arabic name cannot be empty", nameof(nameAr));
            }

            NameAr = nameAr;
        }
        public void UpdateNameAr(string nameAr)
        {
            this.SetNameAr(nameAr);
        }

        public void UpdateNameEn(string nameEn)
        {
            this.SetNameEn(nameEn);
        }

        public void SetBarcode(string barcode)
        {
            Barcode = barcode;
        }

        public void SetNameEn(string nameEn)
        {
            NameEn = nameEn;
        }


        public void UpdateBarcode(string barcode)
        {
            this.SetBarcode(barcode);
        }


        public void SetOrd(int? ord)
        {
            if (ord.HasValue && ord < 0)
            {
                throw new ArgumentException("Order cannot be negative", nameof(ord));
            }

            Ord = ord;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (TEncodeTableAggregateRoot<TKey>)obj;
            return EqualityComparer<TKey>.Default.Equals(Id, other.Id) &&
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
            return $"[TEncodeTableAggregateRoot: Id={Id}, NameAr={NameAr}, NameEn={NameEn}, Ord={Ord},Barcode={Barcode}]";
        }
    }


}
