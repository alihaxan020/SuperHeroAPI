using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<SuperHero> SuperHeroes => Set<SuperHero>(); 
    }
}
