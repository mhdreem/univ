using System;
using Univ.Hi_Student_Affairs.Domain.Abstruct;

namespace Univ.Hi_Student_Affairs.Domain.StdAffiliation
{
    public class AffiliationStage : TBaseStageEntity<int>
    {
        public AffiliationStage(int id, string name, int? ord, StageState stageState)
         : base(id, name, ord, stageState)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Invalid name ", nameof(name));
            }


        }

        public AffiliationStage(string name, int? ord, StageState stageState)
         : base(name, ord, stageState)
        {
            SetStageState(stageState);
        }





        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (AffiliationStage)obj;
            return Id == other.Id &&
                   Name == other.Name &&
            Ord == other.Ord &&
            StageState == other.StageState;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Ord, StageState);
        }

        public override string ToString()
        {
            return $"[AffiliationStage: Id={Id}, Name={Name}, Ord={Ord},StageState={StageState} ]";
        }


    }

}