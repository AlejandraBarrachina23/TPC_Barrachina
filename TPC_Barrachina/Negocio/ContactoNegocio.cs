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
    
    public class ContactoNegocio
        
    {
        AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

        public List<Contacto> ListaContactos() {  
            
        List<Contacto> ListadoContacto = new List<Contacto>();
        AccederDatos.LecturaBaseDatos("Select * from Contactos");

            while (AccederDatos.LectorDatos.Read())
            {
                Contacto unContacto = new Contacto();
                unContacto.CodigoContacto = (int) AccederDatos.LectorDatos["CodigoContacto"];
                unContacto.Telefono = AccederDatos.LectorDatos["Telefono"].ToString();
                unContacto.Celular = AccederDatos.LectorDatos["Celular"].ToString();
                unContacto.Mail = AccederDatos.LectorDatos["Mail"].ToString();
                unContacto.Direccion = (Direccion)AccederDatos.LectorDatos["Direccion"];

                ListadoContacto.Add(unContacto);
            
            }

              AccederDatos.CerrarConexion();
              AccederDatos.CerrarReader();
            return ListadoContacto;
        }

        public void AgregarContacto(Contacto unContacto)
        {

            AccederDatos.DefinirTipoComando("INSERT INTO Contactos (Telefono,Celular,Mail,CodigoDireccion)" +
                 "VALUES ('"+ unContacto.Telefono + "','" + unContacto.Celular + "','" + unContacto.Mail + "','" + unContacto.Direccion.CodigoDireccion+"')");
 
            AccederDatos.AbrirConexion();
            AccederDatos.EjecutarConsulta();
            AccederDatos.CerrarReader();
            AccederDatos.CerrarConexion();
        }

        public void EliminarContacto(Contacto unContacto)
        {
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Contactos SET Estado = 0 WHERE CodigoContacto =" + unContacto.CodigoContacto);
            AccederDatos.EjecutarConsulta();
            AccederDatos.CerrarConexion();
        }

        public void ModificarContacto(Contacto unContacto) {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Contactos SET Telefono=@Telefono, Celular=@Celular, Mail=@Mail WHERE CodigoDireccion = " + unContacto.CodigoContacto);
            AccederDatos.Comando.Parameters.Clear();
            AccederDatos.Comando.Parameters.AddWithValue("@Telefono", unContacto.Telefono);
            AccederDatos.Comando.Parameters.AddWithValue("@Celular", unContacto.Celular);
            AccederDatos.Comando.Parameters.AddWithValue("@Mail", unContacto.Mail);
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
        }
    }
}
