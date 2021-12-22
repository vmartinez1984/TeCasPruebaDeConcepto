using Microsoft.EntityFrameworkCore;
using System;

namespace TeCAS.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<CuentaDeAhorro> CuentaDeAhorro { get; set; }
        public DbSet<CuentaDeAhorroDetalle> CuentaDeAhorroDetalle { get; set; }
        public DbSet<CuentaDeAhorroTransaccion> CuentaDeAhorroTransaccion { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=VMARTINEZ-PCH;Database=Tecas;User Id=sa;Password=123456;");
                //optionsBuilder.UseSqlServer("Server=DESKTOP-9CVRRTC\\SQLEXPRESS;Database=RollCall;User Id=sa;Password=123456;");
                //optionsBuilder.UseSqlServer("workstation id=ProyectoDeIntegracion.mssql.somee.com;packet size=4096;user id=vmartinez84_SQLLogin_2;pwd=3ciwfqn2az;data source=ProyectoDeIntegracion.mssql.somee.com;persist security info=False;initial catalog=ProyectoDeIntegracion");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CuentaDeAhorroTransaccion>().HasData(
                new CuentaDeAhorroTransaccion { Id = 1, Nombre = "Depósito" },
                new CuentaDeAhorroTransaccion { Id = 2, Nombre = "Retiro" }
            );

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = 1,
                    Nombre = "Víctor",
                    Paterno = "Martínez",
                    Rfc = "MABV8412056TA",
                    Usuario = "vmartinez",
                    Contrasenia = "123456",
                    FechaDeRegistro = DateTime.Now,
                    NumeroDeEmpleado = "202101"
                }
            );
        }
    }
}
