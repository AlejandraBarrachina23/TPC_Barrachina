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

        public void AgregarProveedor(Proveedor unNuevoProveedor) {

            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("INSERT INTO Proveedores(CodigoProveedor,RazonSocial,NumeroCUIT, NombreFantasia,CodigoCondicionIVA,CodigoImpuesto VALUES ("
                + unNuevoProveedor.CodigoProveedor + "," + unNuevoProveedor.RazonSocial + "," + unNuevoProveedor.NumeroCUIT + "," + unNuevoProveedor.NombreFantasia + "," + unNuevoProveedor.CondicionIVA + ")");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
            AccederDatos.CerrarReader();
       

        }

        public List<Proveedor> ListarProveedores()
        {

            List<Proveedor> ListadoProveedores = new List<Proveedor>();
            AccederDatos.LecturaBaseDatos("Select * from Proveedores");

            while (AccederDatos.LectorDatos.Read())
            {
                Proveedor unProveedor = new Proveedor();
                unProveedor.CodigoProveedor = (int)AccederDatos.LectorDatos["CodigoProveedor"];
                unProveedor.NombreFantasia = AccederDatos.LectorDatos["NombreFantasia"].ToString();
                unProveedor.NumeroCUIT = AccederDatos.LectorDatos["NumeroCUIT"].ToString();
                unProveedor.RazonSocial = AccederDatos.LectorDatos["RazonSocial"].ToString();
              
                ListadoProveedores.Add(unProveedor);
            }

            AccederDatos.CerrarConexion();
            AccederDatos.CerrarReader();
            return ListadoProveedores;

        }

    }
}
