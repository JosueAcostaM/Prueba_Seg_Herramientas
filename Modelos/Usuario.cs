using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Usuario
    {
        //IDENTIFICADOR UNICO PARA EL USUARIO
        [Key] public int Id { get; set; }

        //NOMBRE DEL USUARIO
        public string Nombre { get; set; }

        //CONTRASEÑA PARA EL USUARIO
        public string Contraseña { get; set; }

        //CORREO ELECTRONIO DEL USUARIO
        public string Email { get; set; }

        //ROL QUE PUEDE TOMAR EL USUARIO (USUARIO O ADMINISTRADOR)
        public string Rol {  get; set; }

        //LISTA DE TARES QUE TIENE EL USUARIO
        public List<Tareas>? Tareas { get; set; }= new List<Tareas>();
    }
}
