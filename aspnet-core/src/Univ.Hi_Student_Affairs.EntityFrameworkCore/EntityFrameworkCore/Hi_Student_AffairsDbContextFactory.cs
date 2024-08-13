using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Univ.Hi_Student_Affairs.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class Hi_Student_AffairsDbContextFactory : IDesignTimeDbContextFactory<Hi_Student_AffairsDbContext>
{
    public Hi_Student_AffairsDbContext CreateDbContext(string[] args)
    {
        Hi_Student_AffairsEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = (DbContextOptionsBuilder<Hi_Student_AffairsDbContext>)new DbContextOptionsBuilder<Hi_Student_AffairsDbContext>()
            .UseOracle(configuration.GetConnectionString("Default"));

        return new Hi_Student_AffairsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Univ.Hi_Student_Affairs.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
