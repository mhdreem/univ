using System;
using System.ComponentModel.DataAnnotations.Schema;
using Univ.Hi_Student_Affairs.Domain.Abstruct;



namespace Univ.Hi_Student_Affairs.Domain.Univ
{
    public class StudyPlan : TBaseEntity<int>
    {
        //رقم الكلية التابعة لها الخطة        
        [ForeignKey("CollageId")]
        public virtual int CollageId { get; private set; }


        //وصف الخطة الدراسية        
        public string? Description { get; private set; }

        //تاريخ بداية الخطة
        public DateTime? FireDate { get; private set; }





        public StudyPlan(int id, string name, int? ord, int collageId, string? description, DateTime? FireDate)
         : base(id, name, ord)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Invalid name ", nameof(name));
            }

            SetCollageId(collageId);
        }

        public StudyPlan(string name, int? ord, int collageId, string? description, DateTime? FireDate)
         : base(name, ord)
        {
            SetCollageId(collageId);
        }


        private void SetCollageId(int collageId)
        {
            if (collageId <= 0)
            {
                throw new ArgumentException("Invalid collageId ", nameof(collageId));
            }
            CollageId = collageId;
        }



        public void UpdateCollageId(int collageId)
        {
            SetCollageId(collageId);
        }



        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (StudyPlan)obj;
            return Id == other.Id &&
                   Name == other.Name &&
                   Ord == other.Ord &&
                   CollageId == other.CollageId &&
                   FireDate == other.FireDate &&
                   Description == other.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Ord, CollageId, Description, FireDate);
        }

        public override string ToString()
        {
            return $"[StudyPlan: Id={Id}, Name={Name}, Ord={Ord},CollageId={CollageId}, Description={Description},FireDate={FireDate}]";
        }


    }

}
