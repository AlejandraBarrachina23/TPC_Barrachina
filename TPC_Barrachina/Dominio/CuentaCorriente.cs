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
        public DateTime Fecha { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
        public decimal Saldo { get; set; }
        public decimal LimiteCuenta { get; set; }
    }
}
