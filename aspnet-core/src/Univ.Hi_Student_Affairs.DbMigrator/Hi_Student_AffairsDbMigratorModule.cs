using Univ.Hi_Student_Affairs.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Univ.Hi_Student_Affairs.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Hi_Student_AffairsEntityFrameworkCoreModule),
    typeof(Hi_Student_AffairsApplicationContractsModule)
    )]
public class Hi_Student_AffairsDbMigratorModule : AbpModule
{
}
