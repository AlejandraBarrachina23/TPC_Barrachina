using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class PersonaFisica
    {
        public int CodigoPersonaFisica { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public Contacto Contacto { get; set; }
    }
}
