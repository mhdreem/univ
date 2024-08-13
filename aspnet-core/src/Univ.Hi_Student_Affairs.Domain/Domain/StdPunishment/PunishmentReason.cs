using System;
using Univ.Hi_Student_Affairs.Domain.Abstruct;

namespace Univ.Hi_Student_Affairs.Domain.StdPunishment
{
    public class PunishmentReason : TBaseEntity<int>
    {
        public PunishmentReason(int id, string name, int? ord)
         : base(id, name, ord)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Invalid name ", nameof(name));
            }


        }

        public PunishmentReason(string name, int? ord)
         : base(name, ord)
        {

        }





        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (PunishmentReason)obj;
            return Id == other.Id &&
                   Name == other.Name &&
            Ord == other.Ord;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Ord);
        }

        public override string ToString()
        {
            return $"[PunishmentReason: Id={Id}, Name={Name}, Ord={Ord} ]";
        }


    }

}
