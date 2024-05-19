using Microsoft.EntityFrameworkCore;
using Projecto_App5_Max_Montes_Diaz_4F.Components.Pages;
using Projecto_App5_Max_Montes_Diaz_4F.Modelos;

namespace Projecto_App5_Max_Montes_Diaz_4F.Repositorio
{
    public class RepositorioRservas : IRepositorioReservas
    {

        private readonly CatalogoDBContext _context;

        public RepositorioRservas(CatalogoDBContext context)
        {
            _context = context;
        }
        public async Task<Reservas> Add(Reservas reservas)
        {
            await _context.Reserva.AddAsync(reservas);
            await _context.SaveChangesAsync();
            return reservas;
        }

        public async Task Delete(int id)
        {
            var reservas = await _context.Reserva.FindAsync(id);
            if (reservas != null)
            {
                _context.Reserva.Remove(reservas);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Reservas?> Get(int id)
        {
            return await _context.Reserva.FindAsync(id);
        }

        public async Task<List<Reservas>> GetAll()
        {
            return await _context.Reserva.ToListAsync();
        }

        public async Task Update(int id, Reservas reservas)
        {
            var reservaactal = await _context.Reserva.FindAsync(id);
            if (reservaactal != null)
            {
                reservaactal.Usuario = reservas.Usuario;
                reservaactal.Vehiculo = reservas.Vehiculo;
                reservaactal.FechaPrestamo = reservas.FechaPrestamo;
                reservaactal.FechaFin = reservas.FechaFin;
                reservaactal.Monto = reservas.Monto;
                await _context.SaveChangesAsync();
            }
        }
    }
}
