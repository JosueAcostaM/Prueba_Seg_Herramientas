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
        //IDENTIFICADOR UNICO PARA CADA PROYECTO
        [Key] public int Id { get; set; }   

        //NOMBRE DEL PROYECTO
        public string Nombre { get; set; }

        //DESCRIPCION QUE VA A TENER CADA PROYECTO
        public string Descripcion { get; set; }

        //ESTADO DEL PROYECTO (PENDIENTE O FINALIZADO)
        public string Estado { get; set; }

        //CLAVE FORANEA DE USUARIO
        public int IdUsuario { get; set; }

        //OBJETO DE NAVEGACION USUARIO
        public Usuario? Usuario { get; set; }

        //UNA LISTA DE TAREAS QUE VA A TENER ESE PROYECTO
        public List<Tareas>? Tareas { get; set; }
    }
}
