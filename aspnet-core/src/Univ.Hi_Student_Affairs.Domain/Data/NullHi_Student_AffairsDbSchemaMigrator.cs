using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Univ.Hi_Student_Affairs.Data;

/* This is used if database provider does't define
 * IHi_Student_AffairsDbSchemaMigrator implementation.
 */
public class NullHi_Student_AffairsDbSchemaMigrator : IHi_Student_AffairsDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
