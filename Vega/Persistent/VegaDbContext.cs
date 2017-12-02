using Microsoft.EntityFrameworkCore;
using Vega.Model;

namespace Vega.Persistent
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)
        {
            //System.configuration.ConfigurationManager

        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Modell> Modells { get; set; }
     }
}
