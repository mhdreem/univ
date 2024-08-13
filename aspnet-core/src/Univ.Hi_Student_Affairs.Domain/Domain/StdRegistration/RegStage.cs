using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Domain.StdRegistration
{
    public class RegStage : Entity<int>
    {

        public string? Name { get; private set; }

        public StageState? StageState { get; private set; }

        public int? Ord { get; private set; }
    }
}
