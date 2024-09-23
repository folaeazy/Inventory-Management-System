using Application.Extensions.Identities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfraService( this IServiceCollection services, IConfiguration config)
        {   //configure database
            services.AddDbContext<AppDbContext>(Db => Db.UseSqlServer(config.GetConnectionString("DefaultConnection")), ServiceLifetime.Scoped);
            services.AddAuthentication(options => {
                options.DefaultScheme = IdentityConstants.ApplicationScheme;
                options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
            }).AddIdentityCookies();
            services.AddIdentityCore<ApplicationUser>()
            .AddEntityFrameworkStores<AppDbContext>()
            .AddSignInManager()
            .AddDefaultTokenProviders();


            services.AddAuthorizationBuilder()
            .AddPolicy("AdministrationPolicy", adp =>
            {
                adp.RequireAuthenticatedUser();
                adp.RequireRole("Admin", "Manager");
            })
            .AddPolicy("UserPolicy", adp =>
            {
                adp.RequireAuthenticatedUser();
                adp.RequireRole("User");
            });
            return services;
        }
    }

} 