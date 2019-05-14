using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
    public class Cliente
    {
        public int CodigoCliente { get; set; }
        public PersonaFisica DatosPersonales { get; set; }
        public CuentaCorriente CuentaCorriente { get; set; }
        public Descuento Descuento { get; set; }
        public bool Estado { get; set; }
    }
}
