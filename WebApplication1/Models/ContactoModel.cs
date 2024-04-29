using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ContactoModel
    {
        public int IdContacto { get; set; }

        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string? Genero { get; set; }
        public string? Correo { get; set; }

        [Required(ErrorMessage = "El campo ErrorMessage es obligatorio")]
        public string? FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El campo Fecha de Nacimiento es obligatorio")]
        public string? rut { get; set; }


    }
}