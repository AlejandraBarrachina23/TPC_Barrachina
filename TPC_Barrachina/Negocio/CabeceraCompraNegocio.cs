using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class CabeceraCompraNegocio
    {
        AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

        public void AgregarCabeceraCompra(CabeceraCompra unaNuevaCabeceraCompra)
        {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("INSERT INTO Compras (Usuario,Proveedor) VALUES ('" + unaNuevaCabeceraCompra.Usuario.CodigoUsuario + "','" + unaNuevaCabeceraCompra.Proveedor.CodigoProveedor +"')");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
        }

        public int CuentaFilasCabeceraCompra() { 

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("SELECT COUNT (NumeroCompra) FROM Compras");
            int NumeroCompra = AccederDatos.ejecutarAccionReturn();
            AccederDatos.CerrarConexion();
            return NumeroCompra;
        }
    }
}
