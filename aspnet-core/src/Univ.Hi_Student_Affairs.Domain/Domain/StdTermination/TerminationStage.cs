using Volo.Abp.Domain.Entities;

namespace Univ.Hi_Student_Affairs.Domain.StdTermination
{
    public class TerminationStage : Entity<int>
    {
        public string? Name { get; private set; }

        public StageState? StageState { get; private set; }

        public int? Ord { get; private set; }

    }
}
