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
        AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
        //public Proveedor CrearProveedor(Proveedor unNuevoProveedor) {

        //    AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
        //    AccederDatos.AbrirConexion();
        //    AccederDatos.DefinirTipoComando("INSERT INTO Proveedores(CodigoProveedor,CodigoTipoProveedor,CodigoImpuesto VALUES (" + unNuevoProveedor.CodigoProveedor + "," + unNuevoProveedor.TipoProveedor + "," + unNuevoProveedor.Impuesto + ")");
        //    AccederDatos.EjecutarAccion();
        //    AccederDatos.EjecutarConsulta();
        //    AccederDatos.CerrarConexion();
        //    AccederDatos.CerrarReader();
        //    return unNuevoProveedor;

        //}

        public List<Proveedor> ListarProveedores()
        {

            List<Proveedor> ListadoProveedores = new List<Proveedor>();
            AccederDatos.LecturaBaseDatos("select CodigoProveedor, NombreFantasia FROM Proveedores INNER JOIN PersonaJuridicas ON CodigoPersonaJuridica = CodigoInformacionEmpresa");

            while (AccederDatos.LectorDatos.Read())
            {
                Proveedor unProveedor = new Proveedor();
                unProveedor.CodigoProveedor = (int)AccederDatos.LectorDatos["CodigoProveedor"];
                ListadoProveedores.Add(unProveedor);
            }

            AccederDatos.CerrarConexion();
            AccederDatos.CerrarReader();
            return ListadoProveedores;

        }

    }
}
