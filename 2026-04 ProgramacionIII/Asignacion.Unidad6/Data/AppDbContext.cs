using Asignacion.Unidad6.Models;
using Microsoft.EntityFrameworkCore;

namespace Asignacion.Unidad6.Data;

public class AppDbContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; }

    public AppDbContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 44));
            optionsBuilder.UseMySql("Server=localhost;User=root;Password=123456;Database=prg3_task6;", serverVersion);
        }
    }
}
