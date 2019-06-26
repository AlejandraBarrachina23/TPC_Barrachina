using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CabeceraNotaCredito:CabeceraDocumento
    {
        public Cliente Cliente { get; set; }
        public MotivoDevolucion MotivoDevolucio { get; set; }
    }
}
