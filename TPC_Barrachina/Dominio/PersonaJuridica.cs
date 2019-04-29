using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class PersonaJuridica
    {
        public string RazonSocial { get; set; }
        public string NumeroCUIT { get; set; }
        public string NombreFantasia { get; set; }
        public Contacto Contacto { get; set; }
        public CondicionIVA CondicionIVA { get; set; }
    }
}
