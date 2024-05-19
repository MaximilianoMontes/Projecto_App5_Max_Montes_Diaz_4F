using Projecto_App5_Max_Montes_Diaz_4F.Modelos;

namespace Projecto_App5_Max_Montes_Diaz_4F.Repositorio
{
    public interface IRepositorioVehiculo
    {
        Task<List<Vehiculos>> GetAll();
        Task<Vehiculos?> Get(int id);
        Task<Vehiculos> Add(Vehiculos vehiculos);
        Task Update(int id, Vehiculos vehiculos);
        Task Delete(int id);
    }
}
