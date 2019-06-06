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

                if ((bool)AccederDatos.LectorDatos["Estado"]) {

                    unDescuento.CodigoDescuento = (int)AccederDatos.LectorDatos["CodigoDescuento"];
                    unDescuento.Nombre = AccederDatos.LectorDatos["NombreDescuento"].ToString();
                    unDescuento.Porcentaje = (decimal)AccederDatos.LectorDatos["Porcentaje"];

                    ListadoDescuentos.Add(unDescuento);

                }
                
            }
            return ListadoDescuentos;

        }

        public void EliminarDescuento(Descuento unDescuento) {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Descuentos SET Estado = 0 WHERE CodigoDescuento ='" + unDescuento.CodigoDescuento + "'");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();

        }
    }
}
