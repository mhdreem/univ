using System;
using Univ.Hi_Student_Affairs.Domain.Abstruct;

namespace Univ.Hi_Student_Affairs.Domain.StdAffiliation
{
    public class AffiliationOrder : TBaseEntity<int>
    {
        public virtual AffiliationType AffiliationType { get; private set; }

        public AffiliationOrder(int id, string name, int? ord, AffiliationType affiliationType)
         : base(id, name, ord)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Invalid name ", nameof(name));
            }

            SetAffiliationType(affiliationType);
        }

        public AffiliationOrder(string name, int? ord, AffiliationType affiliationType)
         : base(name, ord)
        {
            SetAffiliationType(affiliationType);
        }


        private void SetAffiliationType(AffiliationType affiliationType)
        {
            if (affiliationType <= 0)
            {
                throw new ArgumentException("Invalid affiliationType ", nameof(affiliationType));
            }
            AffiliationType = affiliationType;
        }



        public void UpdateAffiliationType(AffiliationType affiliationType)
        {
            SetAffiliationType(affiliationType);
        }



        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (AffiliationOrder)obj;
            return Id == other.Id &&
                   Name == other.Name &&
            Ord == other.Ord &&
            AffiliationType == other.AffiliationType;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Ord, AffiliationType);
        }

        public override string ToString()
        {
            return $"[AffiliationOrder: Id={Id}, Name={Name}, Ord={Ord},AffiliationType={AffiliationType} ]";
        }


    }

}
