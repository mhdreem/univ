using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Univ.Hi_Student_Affairs.Data;
using Volo.Abp.DependencyInjection;

namespace Univ.Hi_Student_Affairs.EntityFrameworkCore;

public class EntityFrameworkCoreHi_Student_AffairsDbSchemaMigrator
    : IHi_Student_AffairsDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreHi_Student_AffairsDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the Hi_Student_AffairsDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Hi_Student_AffairsDbContext>()
            .Database
            .MigrateAsync();
    }
}
