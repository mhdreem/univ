using System;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.Abstruct;

namespace Univ.Hi_Student_Affairs.Domain.StdPunishment
{
    public class Punishment : TBaseEntity<int>
    {
        public PunishEffect PunishEffect { get; private set; }
        public PunishmentType PunishmentType { get; private set; }


        //نوع الحرمان
        [ForeignKey("Deprivation")]
        public int? DeprivationId { get; private set; }
        public virtual Deprivation? Deprivation { get; private set; }


        public Punishment(int id, string name, int? ord, PunishmentType punishmentType, PunishEffect punishEffect)
         : base(id, name, ord)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Invalid name ", nameof(name));
            }

            SetPunishmentType(punishmentType);
            SetPunishEffect(punishEffect);
        }

        public Punishment(string name, int? ord, PunishmentType punishmentType, PunishEffect punishEffect)
         : base(name, ord)
        {
            SetPunishmentType(punishmentType);
            SetPunishEffect(punishEffect);
        }


        private void SetPunishmentType(PunishmentType punishmentType)
        {
            if (punishmentType <= 0)
            {
                throw new ArgumentException("Invalid punishmentType ", nameof(punishmentType));
            }
            PunishmentType = punishmentType;
        }



        public void UpdatePunishmentType(PunishmentType punishmentType)
        {
            SetPunishmentType(punishmentType);
        }


        private void SetPunishEffect(PunishEffect punishEffect)
        {
            if (punishEffect <= 0)
            {
                throw new ArgumentException("Invalid punishEffect ", nameof(punishEffect));
            }
            PunishEffect = punishEffect;
        }



        public void UpdatePunishEffect(PunishEffect punishEffect)
        {
            SetPunishEffect(punishEffect);
        }



        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (Punishment)obj;
            return Id == other.Id &&
                   Name == other.Name &&
            Ord == other.Ord &&
            PunishmentType == other.PunishmentType;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Ord, PunishmentType);
        }

        public override string ToString()
        {
            return $"[Punishment: Id={Id}, Name={Name}, Ord={Ord},PunishmentType={PunishmentType} ]";
        }


    }

}
