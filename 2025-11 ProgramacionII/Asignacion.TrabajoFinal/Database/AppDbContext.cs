using Asignacion.TrabajoFinal.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Asignacion.TrabajoFinal.Database;

public class AppDbContext : DbContext
{
    public DbSet<ProductoEntity> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=pg2trabajofinal;Trusted_Connection=True;");
    }
}