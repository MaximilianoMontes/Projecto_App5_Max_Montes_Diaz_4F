using Microsoft.EntityFrameworkCore;
using Projecto_App5_Max_Montes_Diaz_4F.Modelos;

namespace Projecto_App5_Max_Montes_Diaz_4F.Repositorio
{
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        private readonly CatalogoDBContext _context;

        public RepositorioUsuarios(CatalogoDBContext context)
        {
            _context = context;
        }
        public async Task<Usuarios> Add(Usuarios usuarios)
        {
            await _context.Usuario.AddAsync(usuarios);
            await _context.SaveChangesAsync();
            return usuarios;
        }

        public async Task Delete(int id)
        {
            var usuarios = await _context.Usuario.FindAsync(id);
            if (usuarios != null)
            {
                _context.Usuario.Remove(usuarios);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Usuarios?> Get(int id)
        {
            return await _context.Usuario.FindAsync(id);
        }

        public async Task<List<Usuarios>> GetAll()
        {
            return await _context.Usuario.ToListAsync();
        }

        public async Task Update(int id, Usuarios usuarios)
        {
            var usuarioactual = await _context.Usuario.FindAsync(id);
            if (usuarioactual != null)
            {
                usuarioactual.Nombre = usuarios.Nombre;
                usuarioactual.NumeroTelefono = usuarios.NumeroTelefono;
                usuarioactual.Direccion = usuarios.Direccion;
                await _context.SaveChangesAsync();
            }
        }
    }
}
