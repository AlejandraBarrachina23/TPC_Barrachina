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
            AccederDatos.DefinirTipoComando("INSERT INTO Ventas (Usuario,Cliente,Total,MetodoPago) VALUES ('" + unaNuevaCabeceraVenta.Usuario.CodigoUsuario + "','" + unaNuevaCabeceraVenta.Cliente.CodigoCliente + "','" +
            unaNuevaCabeceraVenta.Total + "','"+ unaNuevaCabeceraVenta.MetodoPago+ "')");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
        }

        public int CuentaFilasCabeceraVenta() {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("SELECT COUNT (NumeroVenta) FROM Ventas");
            int NumeroVenta = AccederDatos.ejecutarAccionReturn();
            AccederDatos.CerrarConexion();
            return NumeroVenta;
        }

        
    }
}
