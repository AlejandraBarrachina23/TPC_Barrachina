using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Contacto
    {
        public int CodigoContacto { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Mail { get; set; }
        public Direccion Direccion { get; set; }

        public override string ToString()
        {
            return CodigoContacto.ToString();
        }
    }

}
