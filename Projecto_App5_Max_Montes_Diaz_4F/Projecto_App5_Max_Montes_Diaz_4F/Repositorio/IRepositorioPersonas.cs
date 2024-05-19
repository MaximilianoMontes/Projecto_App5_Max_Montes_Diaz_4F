using Projecto_App5_Max_Montes_Diaz_4F.Modelos;

namespace Projecto_App5_Max_Montes_Diaz_4F.Repositorio
{
    public interface IRepositorioPersonas
    {
        Task<List<Persona>> GetAll();
        Task<Persona?> Get(int id);
        Task<Persona> Add(Persona persona);
        Task Update(int id, Persona persona);
        Task Delete (int id);
    }
}
