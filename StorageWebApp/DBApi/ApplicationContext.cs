using DBApi.Models;
using Microsoft.EntityFrameworkCore;
namespace DBApi
{
    public class ApplicationContext : DbContext 
    {

            public DbSet<Resurce> Resurces { get; set; } = null!;
            public DbSet<AdmisDoc> AdmisDocs { get; set; } = null!;
            public DbSet<AdmisResurce> AdmisResurces { get; set; } = null!;
            public DbSet<Balance> Balances { get; set; } = null!;
            public DbSet<Client> Clients { get; set; } = null!;
            public DbSet<ShipDoc> ShipDocs { get; set; } = null!;
            public DbSet<ShipRes> ShipRes { get; set; } = null!;
            public DbSet<Unit> Units { get; set; } = null!;
            public ApplicationContext()
            {
            Database.EnsureCreated();
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=LEGIONVI;Initial Catalog=StorageDB;Integrated Security=True;Encrypt=False");
            }
        
    }

}
