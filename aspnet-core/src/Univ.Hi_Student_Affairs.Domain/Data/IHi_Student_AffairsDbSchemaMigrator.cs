using System.Threading.Tasks;

namespace Univ.Hi_Student_Affairs.Data;

public interface IHi_Student_AffairsDbSchemaMigrator
{
    Task MigrateAsync();
}
