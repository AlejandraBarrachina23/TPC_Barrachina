using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proveedor
    {
        public int CodigoProveedor { get; set; }
        public PersonaFisica DatosFiscales { get; set; }
        public Impuesto Impuesto { get; set; }
        public bool Estado { get; set; }
    }
}
