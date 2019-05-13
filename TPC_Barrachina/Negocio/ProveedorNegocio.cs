using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;

namespace Negocio
{
    public class ProveedorNegocio
    {
        public Proveedor CrearProveedor(Proveedor unNuevoProveedor) {

            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("INSERT INTO Proveedores(CodigoProveedor,CodigoTipoProveedor,CodigoImpuesto VALUES (" + unNuevoProveedor.CodigoProveedor + "," + unNuevoProveedor.TipoProveedor + "," + unNuevoProveedor.Impuesto + ")");
            AccederDatos.EjecutarAccion();
            AccederDatos.EjecutarConsulta();
            AccederDatos.CerrarConexion();
            AccederDatos.CerrarReader();
            return unNuevoProveedor;

        }

        public void NuevoProveedor() {



        }
        


    }
}
