using Application.Extensions.Identities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;



namespace Infrastructure.DataAccess
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
    }

    
    // public class AppDbContext(DbContextOptions<AppDbContext> options)
    // : IdentityDbContext<ApplicationUser>(options)
    // {

    // }


    // public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    // {
    //     public AppDbContext CreateDbContext(string[]? args = null)
    //     {
    //         var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

    //         // Load the connection string from appsettings.json
    //         var configuration = new ConfigurationBuilder()
    //             .SetBasePath(Directory.GetCurrentDirectory())
    //             .AddJsonFile("appsettings.json")
    //             .Build();

    //         optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

    //         return new AppDbContext(optionsBuilder.Options);
    //     }
    // }

    
}



