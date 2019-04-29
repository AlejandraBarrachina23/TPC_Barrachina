using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Empleado
    {
        public int CodigoEmpleado { get; set; }
        public string Cargo { get; set; }
        public string Horario { get; set; }
        public decimal Remuneracion { get; set; }
        public Persona Tipo { get; set; }
        public bool Estado { get; set; }
    }
}
