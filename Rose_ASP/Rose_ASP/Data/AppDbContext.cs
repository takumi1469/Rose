using Microsoft.EntityFrameworkCore;
using Rose_ASP.Data;

namespace Rose_ASP.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
        {
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryData> CountryDatas { get; set; }

    }
}
