using System.ComponentModel.DataAnnotations;

namespace Projecto_App5_Max_Montes_Diaz_4F.Modelos
{
    public class Persona
    {
       public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El correo es requerido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Correo { get; set; }
        [Required(ErrorMessage = "El telofono es requerido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Telofono { get; set; }
    }
}
