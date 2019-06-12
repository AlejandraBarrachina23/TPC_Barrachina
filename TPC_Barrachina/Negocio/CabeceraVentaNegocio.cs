using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;

namespace Negocio
{
    public class CabeceraVentaNegocio
    {
        AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

        public void AgregarCabeceraVenta(CabeceraVenta unaNuevaCabeceraVenta) {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("INSERT INTO Ventas (Usuario,Cliente,Total) VALUES ('" + unaNuevaCabeceraVenta.Usuario.Nombre + "','" + unaNuevaCabeceraVenta.Cliente.CodigoCliente + "','" +
                unaNuevaCabeceraVenta.Total + "')");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
        }
    }
}
