using Projecto_App5_Max_Montes_Diaz_4F.Modelos;

namespace Projecto_App5_Max_Montes_Diaz_4F.Repositorio
{
    public interface IRepositorioUsuarios
    {
        Task<List<Usuarios>> GetAll();
        Task<Usuarios?> Get(int id);
        Task<Usuarios> Add(Usuarios usuarios);
        Task Update(int id, Usuarios usuarios);
        Task Delete(int id);
    }
}
