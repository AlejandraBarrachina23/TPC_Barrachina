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
    public class DireccionNegocio
    {
       private AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

        public List<Direccion> ListarDirecciones()
        {

            List<Direccion> ListadoDirecciones = new List<Direccion>();
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("Select * from Direcciones");
            AccederDatos.EjecutarConsulta();

            while (AccederDatos.LectorDatos.Read())
            {
                Direccion unaDireccion = new Direccion();
                unaDireccion.CodigoDireccion = (int)AccederDatos.LectorDatos["CodigoDireccion"];
                unaDireccion.Calle = AccederDatos.LectorDatos["Calle"].ToString();
                unaDireccion.Numero = (int)AccederDatos.LectorDatos["Numero"];
                unaDireccion.CodigoPostal = (int)AccederDatos.LectorDatos["CodigoPostal"];
                unaDireccion.Localidad = AccederDatos.LectorDatos["Localidad"].ToString();
                unaDireccion.Provincia = AccederDatos.LectorDatos["Provincia"].ToString();

                ListadoDirecciones.Add(unaDireccion);
            }

            AccederDatos.CerrarConexion();
            AccederDatos.CerrarReader();
            return ListadoDirecciones;

        }

        public void AgregarDireccion(Direccion unaDireccion)
        {
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando(("INSERT INTO Direcciones (Calle,Numero,CodigoPostal,Localidad,Provincia)" +
                 "VALUES ('" + unaDireccion.Calle + "','" + unaDireccion.Numero+ "','" + unaDireccion.CodigoPostal + "','" + unaDireccion.Localidad + "','" + unaDireccion.Provincia + "')"));
            
                AccederDatos.EjecutarAccion();
                AccederDatos.CerrarConexion();
        }

        public int ContaFilasDireccion() {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("SELECT COUNT (CodigoDireccion) FROM Direcciones");
            int total = AccederDatos.ejecutarAccionReturn();
            AccederDatos.CerrarConexion();
            return total+1;
        
        }

        public void EliminarDireccion(Direccion unaDireccion)
        {
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Direcciones SET Estado = 0 WHERE CodigoDireccion =" + unaDireccion.CodigoDireccion);
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();

        }

        public void ModificarDireccion(Direccion unaDireccion) {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Direcciones SET Calle=@Calle,Numero=@Numero,CodigoPostal=@CodigoPostal,Localidad=@Localidad,Provincia=@Provincia WHERE CodigoDireccion = " + unaDireccion.CodigoDireccion);
            AccederDatos.Comando.Parameters.Clear();
            AccederDatos.Comando.Parameters.AddWithValue("@Calle", unaDireccion.Calle);
            AccederDatos.Comando.Parameters.AddWithValue("@Numero", unaDireccion.Numero);
            AccederDatos.Comando.Parameters.AddWithValue("@CodigoPostal", unaDireccion.CodigoPostal);
            AccederDatos.Comando.Parameters.AddWithValue("@Localidad", unaDireccion.Localidad);
            AccederDatos.Comando.Parameters.AddWithValue("@Provincia", unaDireccion.Provincia);
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
        }

        public Direccion CargarDireccion(TextBox tboxCalle, TextBox tboxNumero, TextBox tboxCP, TextBox tboxLocalidad, TextBox tboxProvincia, int CodigoDireccion) {

            Direccion unaNuevaDireccion = new Direccion();
            unaNuevaDireccion.CodigoDireccion = CodigoDireccion;
            unaNuevaDireccion.Calle = tboxCalle.Text;
            unaNuevaDireccion.Numero = Convert.ToInt32(tboxNumero.Text);
            unaNuevaDireccion.CodigoPostal = Convert.ToInt32(tboxCP.Text);
            unaNuevaDireccion.Localidad = tboxLocalidad.Text;
            unaNuevaDireccion.Provincia = tboxProvincia.Text;
            return unaNuevaDireccion;
        }
    }
}
