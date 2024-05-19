using System.ComponentModel.DataAnnotations;

namespace Projecto_App5_Max_Montes_Diaz_4F.Modelos
{
    public class Reservas
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string? Usuario { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string? Vehiculo { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public DateOnly FechaPrestamo { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public DateOnly FechaFin { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public int Monto { get; set; }
    }
}
