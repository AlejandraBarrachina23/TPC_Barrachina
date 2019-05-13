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

        public List<Proveedor> BusquedaProveedores(string ParametroBusqueda, string NombreColumna) {

            List<Proveedor> ListadoProveedores = new List<Proveedor>();
            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("SELECT * FROM Proveedores WHERE " + NombreColumna + " LIKE '" + ParametroBusqueda + "'");
            AccederDatos.EjecutarAccion();
            AccederDatos.EjecutarConsulta();

            while (AccederDatos.LectorDatos.Read()) {

                Proveedor unProveedor = new Proveedor();
                unProveedor.CodigoProveedor = (int)AccederDatos.LectorDatos["Codigo"];
                unProveedor.Estado = (bool)AccederDatos.LectorDatos["Estado"];
                ListadoProveedores.Add(unProveedor);
            }
            
            AccederDatos.CerrarConexion();
            AccederDatos.CerrarReader();
            return ListadoProveedores;        

        }
        
    }
}
