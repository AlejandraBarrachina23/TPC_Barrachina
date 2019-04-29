using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Cliente
    {
        public int CodigoCliente { get; set; }
        public Persona TipoCliente { get; set; }
        public CuentaCorriente CuentaCorriente { get; set; }
        public Descuento Descuento { get; set; }
        public bool Estado { get; set; }
    }
}
