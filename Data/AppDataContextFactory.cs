using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using LojaApi.Data;

namespace LojaApi.Data;

public class AppDataContextFactory : IDesignTimeDbContextFactory<AppDataContext>
{
    public AppDataContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDataContext>();
        optionsBuilder.UseMySql(
            "server=localhost;database=LojaDb;user=root;password=Mortadela65@",
            new MySqlServerVersion(new Version(8, 0, 36))
        );

        return new AppDataContext(optionsBuilder.Options);
    }
}

