using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Tareas
    {
        [Key] public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public DateTime Fecha_inicio { get; set; }

        public DateTime Fecha_fin { get; set; }

        public string Estado { get; set; }

        public int IdUsuario {  get; set; }
        public int IdProyectos { get; set; }
        public Usuario? Usuario { get; set; }
        public Proyectos? Proyectos { get; set; }
    }
}
