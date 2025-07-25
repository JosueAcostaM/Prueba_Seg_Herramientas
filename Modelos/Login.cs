using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Login
    {
        //IDENTIFICADOR UNICO PARA CADA LOGIN
        [Key] public int Id { get; set; }

        //NOMBRE DE USUARIO
        public string Nombre_Usuario { get; set; }

        //CONTRASEÑA QUE VA A USAR EN EL LOGIN
        public string Contraseña { get; set; }

        //ESTADO DEL INICIO DE SESION DEL USUARIO
        public bool Estado { get; set; }
    }
}
