
using System;
using Univ.Hi_Student_Affairs.Domain.Abstruct;

namespace Univ.Hi_Student_Affairs.Domain.StdAbsence
{
    public class AbsenceOrder : TBaseEntity<int>
    {
        public virtual AbsenceType AbsenceType { get; private set; }

        public AbsenceOrder(int id, string name, int? ord, AbsenceType absenceType)
         : base(id, name, ord)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Invalid name ", nameof(name));
            }

            SetAbsenceType(absenceType);
        }

        public AbsenceOrder(string name, int? ord, AbsenceType absenceType)
         : base(name, ord)
        {
            SetAbsenceType(absenceType);
        }


        private void SetAbsenceType(AbsenceType absenceType)
        {
            if (absenceType <= 0)
            {
                throw new ArgumentException("Invalid absenceType ", nameof(absenceType));
            }
            AbsenceType = absenceType;
        }



        public void UpdateAbsenceType(AbsenceType absenceType)
        {
            SetAbsenceType(absenceType);
        }



        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (AbsenceOrder)obj;
            return Id == other.Id &&
                   Name == other.Name &&
                   Ord == other.Ord &&
                   AbsenceType == other.AbsenceType;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Ord, AbsenceType);
        }

        public override string ToString()
        {
            return $"[AbsenceOrder: Id={Id}, Name={Name}, Ord={Ord},AbsenceType={AbsenceType} ]";
        }


    }

}

