﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CabeceraVenta:CabeceraDocumento
    {
        public Cliente Cliente { get; set; }
        public TipoPago MetodoPago { get; set; }
        
    }
}
