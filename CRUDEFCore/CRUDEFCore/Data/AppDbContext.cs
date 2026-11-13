using CRUDEFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUDEFCore.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Empleado> Empleado { get; set; }

        protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-VTV2C79;Database=Empleado;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.ToTable("Empleado");
                entity.HasKey(e => e.IdEmpleado);
            });
        }
    }
}
