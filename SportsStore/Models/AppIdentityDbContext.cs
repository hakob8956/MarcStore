using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SportsStore.Models
{
    public class AppIdentityDbContext:IdentityDbContext<User>
    {
        public AppIdentityDbContext (DbContextOptions<AppIdentityDbContext> options):base(options) { }
        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppIdentityDbContext>
        {
            public AppIdentityDbContext CreateDbContext(string[] args)
            {

                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var builder = new DbContextOptionsBuilder<AppIdentityDbContext>();

                var connectionString = configuration["Data:SportStoreIdentity:ConnectionString"];

                builder.UseSqlServer(connectionString);

                return new AppIdentityDbContext(builder.Options);
            }

       
        }
    }
}
