using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public  class Proyectos
    {
        [Key] public int Id { get; set; }   

        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public int IdUsuario { get; set; }
        public Usuario? Usuario { get; set; }
        public List<Tareas>? Tareas { get; set; }
    }
}
