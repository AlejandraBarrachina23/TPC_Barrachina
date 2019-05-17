using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;
namespace Negocio
{
    public class DescuentoNegocio

    {
        AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

        public List<Descuento> ListarDescuentos()
        {

            List<Descuento> ListadoDescuentos = new List<Descuento>();
            AccederDatos.LecturaBaseDatos("SELECT * FROM Descuentos");
            while (AccederDatos.LectorDatos.Read())
            {

                Descuento unDescuento = new Descuento();

                unDescuento.CodigoDescuento = (int)AccederDatos.LectorDatos["CodigoDescuento"];
                unDescuento.Nombre = AccederDatos.LectorDatos["Nombre"].ToString();
                unDescuento.Porcentaje = (decimal)AccederDatos.LectorDatos["Porcentaje"];

                ListadoDescuentos.Add(unDescuento);
            }
            return ListadoDescuentos;

        }
    }
}
