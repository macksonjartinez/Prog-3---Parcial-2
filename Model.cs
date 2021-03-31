using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prog_3___Parcial_2.Shared
{
    public class Model
    {
        public int Id { get; set; }
        public string Cedula_Querellante { get; set; }
        public string Nombre_Querellante { get; set; }
        public string Fecha { get; set; }
        public string Objeto_Robado { get; set; }
        public string Lugar { get; set; }
        public string Valor_Objeto { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
    }
}
