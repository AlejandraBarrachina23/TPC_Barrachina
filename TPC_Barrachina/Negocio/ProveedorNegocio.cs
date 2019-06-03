using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            AccederDatos.DefinirTipoComando("INSERT INTO Proveedores(CodigoProveedor,RazonSocial,NumeroCUIT, NombreFantasia,CodigoCondicionIVA,CodigoContacto) VALUES ('"
                + unNuevoProveedor.CodigoProveedor + "','" + unNuevoProveedor.RazonSocial + "','" + unNuevoProveedor.NumeroCUIT + "','" + unNuevoProveedor.NombreFantasia + "','" + unNuevoProveedor.CondicionIVA.CodigoCondicionIVA + "','" + unNuevoProveedor.Contacto.CodigoContacto+ "')");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
          
        }

        public List<Proveedor> ListarProveedores()
        {

            List<Proveedor> ListadoProveedores = new List<Proveedor>();
            AccederDatos.LecturaBaseDatos("select * from Proveedores INNER JOIN CondicionesIVA ON CondicionesIVA.CodigoCondicionIVA = Proveedores.CodigoCondicionIVA INNER JOIN Contactos ON Contactos.CodigoContacto = " +
            "Proveedores.CodigoContacto INNER JOIN Direcciones ON Direcciones.CodigoDireccion = Contactos.CodigoContacto");

            while (AccederDatos.LectorDatos.Read())
            {
                Proveedor unProveedor = new Proveedor();
                unProveedor.Contacto = new Contacto();
                unProveedor.Contacto.Direccion = new Direccion();
                unProveedor.CondicionIVA = new CondicionIVA();

                unProveedor.CodigoProveedor = (int)AccederDatos.LectorDatos["CodigoProveedor"];
                unProveedor.NombreFantasia = AccederDatos.LectorDatos["NombreFantasia"].ToString();
                unProveedor.NumeroCUIT = AccederDatos.LectorDatos["NumeroCUIT"].ToString();
                unProveedor.RazonSocial = AccederDatos.LectorDatos["RazonSocial"].ToString();
                unProveedor.Contacto.CodigoContacto = (int)AccederDatos.LectorDatos["CodigoContacto"];
                unProveedor.Contacto.Telefono = AccederDatos.LectorDatos["Telefono"].ToString();
                unProveedor.Contacto.Celular = AccederDatos.LectorDatos["Celular"].ToString();
                unProveedor.Contacto.Mail = AccederDatos.LectorDatos["Mail"].ToString();
                unProveedor.Contacto.Direccion.CodigoDireccion = (int)AccederDatos.LectorDatos["CodigoDireccion"];
                unProveedor.Contacto.Direccion.Calle = AccederDatos.LectorDatos["Calle"].ToString();
                unProveedor.Contacto.Direccion.Numero = (int)AccederDatos.LectorDatos["Numero"];
                unProveedor.Contacto.Direccion.CodigoPostal = (int)AccederDatos.LectorDatos["CodigoPostal"];
                unProveedor.Contacto.Direccion.Provincia = AccederDatos.LectorDatos["Provincia"].ToString();
                unProveedor.Contacto.Direccion.Localidad = AccederDatos.LectorDatos["Localidad"].ToString();
                unProveedor.CondicionIVA.CodigoCondicionIVA = (int)AccederDatos.LectorDatos["CodigoCondicionIVA"];
                unProveedor.CondicionIVA.Nombre = AccederDatos.LectorDatos["NombreCondicionIVA"].ToString();
                
                ListadoProveedores.Add(unProveedor);
            }

            AccederDatos.CerrarConexion();
            AccederDatos.CerrarReader();
            return ListadoProveedores;

        }

        public void EliminarProveedor(Proveedor unProveedor) {

            MessageBox.Show(unProveedor.Contacto.CodigoContacto.ToString());

            DireccionNegocio unaDireccion = new DireccionNegocio();
            ContactoNegocio unContacto = new ContactoNegocio();
            Direccion DireccionEliminar = new Direccion();
            DireccionEliminar.CodigoDireccion = unProveedor.Contacto.CodigoContacto;

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Proveedores SET Estado = 0 WHERE CodigoProveedor = " + unProveedor.CodigoProveedor);
            AccederDatos.EjecutarConsulta();
            AccederDatos.CerrarConexion();

            unaDireccion.EliminarDireccion(DireccionEliminar);
            unContacto.EliminarContacto(unProveedor.Contacto);

        }


    }
}
