using Volo.Abp.Modularity;

namespace Univ.Hi_Student_Affairs;

/* Inherit from this class for your domain layer tests. */
public abstract class Hi_Student_AffairsDomainTestBase<TStartupModule> : Hi_Student_AffairsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
