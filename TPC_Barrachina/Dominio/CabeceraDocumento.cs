using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class CabeceraDocumento
    {
        public int NumeroDocumento { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaEmision { get; set; }
        public List<DetalleDocumento> DetalleDocumento { get; set; }
    }
}
