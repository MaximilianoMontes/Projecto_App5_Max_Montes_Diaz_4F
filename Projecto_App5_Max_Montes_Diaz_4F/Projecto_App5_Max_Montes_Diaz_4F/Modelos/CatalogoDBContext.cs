using Microsoft.EntityFrameworkCore;

namespace Projecto_App5_Max_Montes_Diaz_4F.Modelos
{
    public class CatalogoDBContext : DbContext
    {
        public CatalogoDBContext(DbContextOptions<CatalogoDBContext> options) : base(options)
        { 
        }
        public DbSet<Persona>Personas { get; set; }
        public DbSet<Reservas>Reserva { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Vehiculos> Vehiculo { get; set;}

    }
}
