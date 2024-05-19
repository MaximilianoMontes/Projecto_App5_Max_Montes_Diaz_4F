using System.ComponentModel.DataAnnotations;

namespace Projecto_App5_Max_Montes_Diaz_4F.Modelos
{
    public class Usuarios
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public int NumeroTelefono { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string? Direccion { get; set; }
    }
}
