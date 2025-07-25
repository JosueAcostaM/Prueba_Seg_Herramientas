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
        //IDENTIFICADOR UNICO PARA TAREAS
        [Key] public int Id { get; set; }

        //NOMBRE QUE VA A TENER ESA TAREA
        public string Nombre { get; set; }

        //DESCRIPCION DE LA TAREA
        public string Descripcion { get; set; }

        //FECHA DE INICIO DE LA TAREA
        public DateTime Fecha_inicio { get; set; }

        //FECHA DE FINALIZACION DE LA TAREA
        public DateTime Fecha_fin { get; set; }

        //ESTADO EN EL QUE ESTA LA TAREA (PENDIENTE O FINALIZADA) 
        public string Estado { get; set; }

        //CLAVE FORANEA DE USUARIO
        public int IdUsuario {  get; set; }

        //CLAVE FORANEA PARA PROYECTOS
        public int IdProyectos { get; set; }

        //OBJETO DE NAVEGACION USUARIO
        public Usuario? Usuario { get; set; }

        //OBJETO DE NAVEGACION PROYECTO
        public Proyectos? Proyectos { get; set; }
    }
}
