using Projecto_App5_Max_Montes_Diaz_4F.Modelos;

namespace Projecto_App5_Max_Montes_Diaz_4F.Repositorio
{
    public interface IRepositorioReservas
    {
        Task<List<Reservas>> GetAll();
        Task<Reservas?> Get(int id);
        Task<Reservas> Add(Reservas reservas);
        Task Update(int id, Reservas reservas);
        Task Delete(int id);
    }
}
