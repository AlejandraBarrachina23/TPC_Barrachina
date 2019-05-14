using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado
    {
        public int CodigoEmpleado { get; set; }
        public string Cargo { get; set; }
        public PersonaFisica DatosPersonales { get; set; }
        public bool Estado { get; set; }
    }
}
