using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CuentaCorriente
    {
        public int CodigoCuentaCorriente { get; set; }      
        public decimal Saldo { get; set; }
        public decimal LimiteCuenta { get; set; }

        public override string ToString()
        {
            return Saldo.ToString();
        }

    }

   
}
