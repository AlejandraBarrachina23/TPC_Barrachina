﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Documento
    {
        public int NumeroDocumento { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaEmision { get; set; }
    }
}
