using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;
using System.Windows.Forms;

namespace Negocio
{
    public class ClienteNegocio
    {
        AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
        //public List<Cliente> BusquedaCliente(string ParametroBusqueda, string NombreColumna) {

        //    //ParametroBusqueda.ToUpper();
        //    //List<Cliente> ListadoClientes = new List<Cliente>();
        //    //AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

        //    //string Consulta = "Select Clientes.Codigo, PersonaFisicas.Nombre, PersonaFisicas.Apellido, CuentaCorrientes.Saldo FROM Clientes INNER JOIN" +
        //    //    " FisicasXClientes ON FisicasXClientes.CodigoCliente = Clientes.Codigo INNER JOIN PersonaFisicas ON PersonaFisicas.CodigoPersonaFisica = " +
        //    //    "FisicasXClientes.CodigPersonaFisica INNER JOIN CuentaCorrientes ON CuentaCorrientes.CodigoCuentaCorriente = Clientes.CodigoCuentaCorriente " +
        //    //    "Where PersonaFisicas." + NombreColumna + " LIKE '" + ParametroBusqueda + "%'";

        //    //    //"select * from Clientes where " + NombreColumna + " LIKE '" + ParametroBusqueda +"'";

        //    //AccederDatos.DefinirTipoComando(Consulta);
        //    //AccederDatos.AbrirConexion();
        //    //AccederDatos.EjecutarConsulta();

        //    //while (AccederDatos.LectorDatos.Read())
        //    //{
        //    //    Cliente unNuevoCliente = new Cliente();
        //    //    unNuevoCliente.CuentaCorriente = new CuentaCorriente();
        //    //    PersonaFisica unaNuevaPersonaFisica = new PersonaFisica();
        //    //    unNuevoCliente.CodigoCliente = (int) AccederDatos.LectorDatos["Codigo"];
        //    //    unaNuevaPersonaFisica.Nombre = AccederDatos.LectorDatos["Nombre"].ToString();
        //    //    unaNuevaPersonaFisica.Apellido = AccederDatos.LectorDatos["Apellido"].ToString();
        //    //    unNuevoCliente.CuentaCorriente.Saldo = (decimal)AccederDatos.LectorDatos["Saldo"];
        //    //    unNuevoCliente.TipoCliente = unaNuevaPersonaFisica;
        //    //    ListadoClientes.Add(unNuevoCliente);

        //    //}

        //    //AccederDatos.CerrarReader();
        //    //AccederDatos.CerrarConexion();
        //    //return ListadoClientes;
        //}

        public void AgregarCliente(Cliente unNuevoCliente) {

         
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("INSERT INTO Clientes (CodigoCliente,Nombre,Apellido,CodigoDescuento,CodigoCuentaCorriente,CodigoContacto) VALUES ('" + unNuevoCliente.CodigoCliente + "','" + unNuevoCliente.Nombre + "','" + unNuevoCliente.Apellido + "','" + unNuevoCliente.Descuento.CodigoDescuento + "','" + unNuevoCliente.CuentaCorriente.CodigoCuentaCorriente + "','" + unNuevoCliente.Contacto.CodigoContacto+ "')");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();

        }

        public List<Cliente> ListarClientes() {

            List<Cliente> ListadoClientes = new List<Cliente>();

            AccederDatos.LecturaBaseDatos("SELECT CodigoCliente, Clientes.Nombre, Apellido,CuentaCorrientes.Saldo, Porcentaje, Contactos.CodigoContacto FROM Clientes INNER JOIN CuentaCorrientes on " +
            "CuentaCorrientes.CodigoCuentaCorriente = Clientes.CodigoCuentaCorriente INNER JOIN Descuentos ON Descuentos.CodigoDescuento = Clientes.CodigoDescuento INNER JOIN Contactos " + 
            "ON Contactos.CodigoContacto = Clientes.CodigoContacto");

            while (AccederDatos.LectorDatos.Read()) {

                Cliente unCliente = new Cliente();
                unCliente.Contacto = new Contacto();
                unCliente.CuentaCorriente = new CuentaCorriente();
                unCliente.Descuento = new Descuento();
                unCliente.CodigoCliente = (int)AccederDatos.LectorDatos["CodigoCliente"];
                unCliente.Nombre = AccederDatos.LectorDatos["Nombre"].ToString();
                unCliente.Apellido = AccederDatos.LectorDatos["Apellido"].ToString();
                unCliente.CuentaCorriente.Saldo= (decimal)AccederDatos.LectorDatos["Saldo"];
                unCliente.Contacto.CodigoContacto = (int) AccederDatos.LectorDatos["CodigoContacto"];
                ListadoClientes.Add(unCliente);                
            }

            return ListadoClientes;
            
        }

        public void EliminarCliente(Cliente unCliente) {

            DireccionNegocio unaDireccion = new DireccionNegocio();
            ContactoNegocio unContacto = new ContactoNegocio();
            CuentaCorrienteNegocio unaCuentaCorriente = new CuentaCorrienteNegocio();
            
            
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Clientes SET Estado = 0 WHERE CodigoCliente =" + unCliente.CodigoCliente);
            AccederDatos.EjecutarConsulta();
            AccederDatos.CerrarConexion();

       
            unaDireccion.EliminarDireccion(unCliente.Contacto.CodigoContacto);
            unContacto.EliminarContacto(unCliente.Contacto.CodigoContacto);
            unCliente.CuentaCorriente = new CuentaCorriente();
            unCliente.CuentaCorriente = unaCuentaCorriente.BusquedaCuentaCorriente("CodigoCuentaCorriente", unCliente.Contacto.CodigoContacto.ToString());
            MessageBox.Show(unCliente.CuentaCorriente.CodigoCuentaCorriente.ToString());
            unaCuentaCorriente.EliminarCuentaCorriente(unCliente.CuentaCorriente.CodigoCuentaCorriente);
            
            
        }
    }
}
