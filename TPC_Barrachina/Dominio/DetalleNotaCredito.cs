﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class DetalleNotaCredito
    {
        public int NumeroLinea { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad {get;set;}
    }
}
