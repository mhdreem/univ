using Volo.Abp.Modularity;

namespace Univ.Hi_Student_Affairs;

[DependsOn(
    typeof(Hi_Student_AffairsApplicationModule),
    typeof(Hi_Student_AffairsDomainTestModule)
)]
public class Hi_Student_AffairsApplicationTestModule : AbpModule
{

}
