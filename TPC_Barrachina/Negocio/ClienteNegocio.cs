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
        private CuentaCorrienteNegocio unaCuentaCorriente = new CuentaCorrienteNegocio();
        private ContactoNegocio unContacto = new ContactoNegocio();
        private DireccionNegocio unaDireccion = new DireccionNegocio();
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

            unaDireccion.AgregarDireccion(unNuevoCliente.Contacto.Direccion);
            unContacto.AgregarContacto(unNuevoCliente.Contacto);
            unaCuentaCorriente.AgregarCuentaCorriente(unNuevoCliente.CuentaCorriente);

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("INSERT INTO Clientes (CodigoCliente,Nombre,Apellido,CodigoDescuento,CodigoCuentaCorriente,CodigoContacto) VALUES ('" + unNuevoCliente.CodigoCliente + "','" + unNuevoCliente.Nombre + "','" + unNuevoCliente.Apellido + "','" + unNuevoCliente.Descuento.CodigoDescuento + "','" + unNuevoCliente.CuentaCorriente.CodigoCuentaCorriente + "','" + unNuevoCliente.Contacto.CodigoContacto+ "')");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
            
        }

        public List<Cliente> ListarClientes() {

            List<Cliente> ListadoClientes = new List<Cliente>();

            AccederDatos.LecturaBaseDatos("select * from Clientes inner join Contactos on Contactos.CodigoContacto = Clientes.CodigoContacto " +
                "inner join Direcciones on Direcciones.CodigoDireccion = Contactos.CodigoDireccion inner join CuentaCorrientes on " +
                "CuentaCorrientes.CodigoCuentaCorriente = Clientes.CodigoCuentaCorriente inner join Descuentos on Descuentos.CodigoDescuento = Clientes.CodigoDescuento");

            while (AccederDatos.LectorDatos.Read()) {

                if ((bool)AccederDatos.LectorDatos["Estado"]) {

                    Cliente unCliente = new Cliente();
                    unCliente.Contacto = new Contacto();
                    unCliente.Contacto.Direccion = new Direccion();
                    unCliente.CuentaCorriente = new CuentaCorriente();
                    unCliente.Descuento = new Descuento();
                    unCliente.CodigoCliente = (int)AccederDatos.LectorDatos["CodigoCliente"];
                    unCliente.Nombre = AccederDatos.LectorDatos["Nombre"].ToString();
                    unCliente.Apellido = AccederDatos.LectorDatos["Apellido"].ToString();
                    unCliente.Contacto.CodigoContacto = (int)AccederDatos.LectorDatos["CodigoContacto"];
                    unCliente.Contacto.Telefono = AccederDatos.LectorDatos["Telefono"].ToString();
                    unCliente.Contacto.Celular = AccederDatos.LectorDatos["Celular"].ToString();
                    unCliente.Contacto.Mail = AccederDatos.LectorDatos["Mail"].ToString();
                    unCliente.Contacto.Direccion.CodigoDireccion = (int)AccederDatos.LectorDatos["CodigoDireccion"];
                    unCliente.Contacto.Direccion.Calle = AccederDatos.LectorDatos["Calle"].ToString();
                    unCliente.Contacto.Direccion.Numero = (int)AccederDatos.LectorDatos["Numero"];
                    unCliente.Contacto.Direccion.CodigoPostal = (int)AccederDatos.LectorDatos["CodigoPostal"];
                    unCliente.Contacto.Direccion.Provincia = AccederDatos.LectorDatos["Provincia"].ToString();
                    unCliente.Contacto.Direccion.Localidad = AccederDatos.LectorDatos["Localidad"].ToString();
                    unCliente.CuentaCorriente.CodigoCuentaCorriente = (int)AccederDatos.LectorDatos["CodigoCuentaCorriente"];
                    unCliente.CuentaCorriente.Saldo= (decimal)AccederDatos.LectorDatos["Saldo"];
                    unCliente.CuentaCorriente.LimiteCuenta = (decimal)AccederDatos.LectorDatos["LimiteCuenta"];
                    unCliente.Descuento.CodigoDescuento = (int)AccederDatos.LectorDatos["CodigoDescuento"];
                    unCliente.Descuento.Nombre = AccederDatos.LectorDatos["NombreDescuento"].ToString();
                    unCliente.Descuento.Porcentaje = (decimal)AccederDatos.LectorDatos["Porcentaje"];

                    ListadoClientes.Add(unCliente);
                }
            }

            return ListadoClientes;
        }

        public void EliminarCliente(Cliente unCliente) {

                        
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Clientes SET Estado = 0 WHERE CodigoCliente =" + unCliente.CodigoCliente);
            AccederDatos.EjecutarConsulta();
            AccederDatos.CerrarConexion();
       
            unaDireccion.EliminarDireccion(unCliente.Contacto.Direccion);
            unContacto.EliminarContacto(unCliente.Contacto);
            unaCuentaCorriente.EliminarCuentaCorriente(unCliente.CuentaCorriente);

        }

        public void ModificarCliente(Cliente unCliente) {

            DireccionNegocio unaDireccionNegocio = new DireccionNegocio();
            CuentaCorrienteNegocio unaCuentaCorriente = new CuentaCorrienteNegocio();
            ContactoNegocio unContactoNegocio = new ContactoNegocio();
            unaDireccionNegocio.ModificarDireccion(unCliente.Contacto.Direccion);
            unaCuentaCorriente.ModificarCuentaCorriente(unCliente.CuentaCorriente);
            unContactoNegocio.ModificarContacto(unCliente.Contacto);

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Clientes Set Nombre=@Nombre, Apellido=@Apellido, CodigoDescuento=@CodigoDescuento WHERE CodigoCliente = " + unCliente.CodigoCliente);
            AccederDatos.Comando.Parameters.Clear();
            AccederDatos.Comando.Parameters.AddWithValue("@Nombre", unCliente.Nombre);
            AccederDatos.Comando.Parameters.AddWithValue("@Apellido", unCliente.Apellido);
            AccederDatos.Comando.Parameters.AddWithValue("@CodigoDescuento", unCliente.Descuento.CodigoDescuento);
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();

        }

        public Cliente CargarCliente(TextBox tboxCodigo, TextBox tboxNombre, TextBox tboxApellido, ComboBox cboxDescuento, TextBox tboxLimitecuenta, TextBox tboxTelefono, TextBox tboxCelular, TextBox tboxCorreoElectronico,TextBox tboxProvincia, TextBox tboxLocalidad, TextBox tboxCalle, TextBox tboxNumero, TextBox tboxCP, int CodigoDireccion, int CodigoCuentaCorriente) {

            Cliente unNuevoCliente = new Cliente();
            unNuevoCliente.CodigoCliente = Convert.ToInt32(tboxCodigo.Text);
            unNuevoCliente.Nombre = tboxNombre.Text;
            unNuevoCliente.Apellido = tboxApellido.Text;
            unNuevoCliente.Descuento = (Descuento)cboxDescuento.SelectedItem;

            unNuevoCliente.CuentaCorriente = unaCuentaCorriente.CargarCuentaCorriente(tboxLimitecuenta, CodigoCuentaCorriente);
            unNuevoCliente.Contacto = unContacto.CargarContacto(tboxTelefono, tboxCelular, tboxCorreoElectronico, CodigoDireccion);
            unNuevoCliente.Contacto.Direccion = unaDireccion.CargarDireccion(tboxCalle, tboxNumero, tboxCP, tboxLocalidad, tboxProvincia, CodigoDireccion);
            return unNuevoCliente;
        }

    }
}
