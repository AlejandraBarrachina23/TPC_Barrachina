using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Contacto
    {
        public int Telefono { get; set; }
        public int Celular { get; set; }
        public string Mail { get; set; }
        public Direccion Direccion { get; set; }
    }
}
