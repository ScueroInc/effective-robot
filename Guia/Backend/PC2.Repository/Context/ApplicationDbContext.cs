using PC2.Domain;
using Microsoft.EntityFrameworkCore;

namespace PC2.Repository.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Planta> Plantas {get;set;}
        public DbSet<Planta_Vivero> Plantas_Viveros {get;set;}
        public DbSet<Vivero> Viveros {get;set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
    }
}