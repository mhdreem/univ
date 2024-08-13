using System;
using Univ.Hi_Student_Affairs.Domain.Abstruct;

namespace Univ.Hi_Student_Affairs.Domain.StdPunishment
{
    public class PunishmentStage : TBaseStageEntity<int>
    {


        public PunishmentStage(int id, string name, int? ord, StageState stageState)
         : base(id, name, ord, stageState)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Invalid name ", nameof(name));
            }


        }

        public PunishmentStage(string name, int? ord, StageState stageState)
         : base(name, ord, stageState)
        {

        }





        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (PunishmentStage)obj;
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
            return $"[PunishmentStage: Id={Id}, Name={Name}, Ord={Ord},StageState={StageState} ]";
        }


    }

}