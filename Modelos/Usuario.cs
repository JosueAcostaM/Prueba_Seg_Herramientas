using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Usuario
    {
        [Key] public int Id { get; set; }

        public string Nombre { get; set; }

        public string Contraseña { get; set; }

        public string Email { get; set; }

        public List<Tareas> Tareas { get; set; }= new List<Tareas>();
    }
}
