using Volo.Abp.Modularity;

namespace Univ.Hi_Student_Affairs;

[DependsOn(
    typeof(Hi_Student_AffairsDomainModule),
    typeof(Hi_Student_AffairsTestBaseModule)
)]
public class Hi_Student_AffairsDomainTestModule : AbpModule
{

}
