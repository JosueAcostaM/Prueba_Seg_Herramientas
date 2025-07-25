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
        [Key] public int Id { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contraseña { get; set; }
        public bool Estado { get; set; }
    }
}
