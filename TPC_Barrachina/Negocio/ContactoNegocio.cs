using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

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
                unContacto.Telefono = (int)AccederDatos.LectorDatos["Telefono"];
                unContacto.Celular = (int)AccederDatos.LectorDatos["Celular"];
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

            AccederDatos.DefinirTipoComando("INSERT INTO Contacto (Telefono,Celular,Mail)" +
                 "VALUES ('"+ unContacto.Telefono + "','" + unContacto.Celular + "','" + unContacto.Mail + "')");
            AccederDatos.AbrirConexion();
            AccederDatos.EjecutarConsulta();
            AccederDatos.CerrarReader();
            AccederDatos.CerrarConexion();
        }
    }
}
