using Microsoft.EntityFrameworkCore;
using Projecto_App5_Max_Montes_Diaz_4F.Modelos;

namespace Projecto_App5_Max_Montes_Diaz_4F.Repositorio
{
    public class RepositorioVehiculos : IRepositorioVehiculo
    {
        private readonly CatalogoDBContext _context;

        public RepositorioVehiculos(CatalogoDBContext context)
        {
            _context = context;
        }
        public async Task<Vehiculos> Add(Vehiculos vehiculos)
        {
            await _context.Vehiculo.AddAsync(vehiculos);
            await _context.SaveChangesAsync();
            return vehiculos;
        }

        public async Task Delete(int id)
        {
            var vehiculos = await _context.Vehiculo.FindAsync(id);
            if (vehiculos != null)
            {
                _context.Vehiculo.Remove(vehiculos);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Vehiculos?> Get(int id)
        {
            return await _context.Vehiculo.FindAsync(id);
        }

        public async Task<List<Vehiculos>> GetAll()
        {
            return await _context.Vehiculo.ToListAsync();
        }

        public async Task Update(int id, Vehiculos vehiculos)
        {
            var vehiculoactual = await _context.Vehiculo.FindAsync(id);
            if (vehiculoactual != null)
            {
                vehiculoactual.Tipo = vehiculos.Tipo;
                vehiculoactual.Modelo = vehiculos.Modelo;
                vehiculoactual.Placa = vehiculos.Placa;
                vehiculoactual.Tarifa = vehiculos.Tarifa;
                await _context.SaveChangesAsync();
            }
        }
    }
}
