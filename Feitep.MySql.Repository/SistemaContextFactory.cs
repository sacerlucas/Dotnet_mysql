using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Feitep.MySql.Repository;

public class SistemaContextFactory : IDesignTimeDbContextFactory<SistemaContext>
{
    public SistemaContext CreateDbContext(string[]? args = null)
    {
        var host = "sql10.freesqldatabase.com";
        var senha = "2Kl5vIJERW";
        var user = "sql10807828";
        var database = "sql10807828";

        var connectionString = $"server={host};user={user};password={senha};database={database};";

        var builder = new DbContextOptionsBuilder<SistemaContext>();

        builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

        return new SistemaContext(builder.Options);
        
    }

}