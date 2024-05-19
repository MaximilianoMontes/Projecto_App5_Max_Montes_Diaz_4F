using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Projecto_App5_Max_Montes_Diaz_4F.Modelos
{
    public class Vehiculos
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string? Tipo { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string? Modelo { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string? Placa { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public int Tarifa { get; set; }
    }
}
