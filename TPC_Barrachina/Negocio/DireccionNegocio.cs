using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class DireccionNegocio
    {
       private AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

        public List<Direccion> ListarDirecciones()
        {

            List<Direccion> ListadoDirecciones = new List<Direccion>();
            AccederDatos.LecturaBaseDatos("Select * from Direcciones");

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

            AccederDatos.DefinirTipoComando(("INSERT INTO Direcciones (Calle,Numero,CodigoPostal,Localidad,Provincia)" +
                 "VALUES ('" + unaDireccion.Calle + "','" + unaDireccion.Numero+ "','" + unaDireccion.CodigoPostal + "','" + unaDireccion.Localidad + "','" + unaDireccion.Provincia + "')"));
                AccederDatos.AbrirConexion();
                AccederDatos.EjecutarConsulta();
                AccederDatos.CerrarReader();
                AccederDatos.CerrarConexion();
        }

        public int ContaFilasDireccion() {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("SELECT COUNT (CodigoDireccion) FROM Direcciones");
            return AccederDatos.ejecutarAccionReturn();
        
        }

        public void EliminarDireccion(int CodigoDireccion)
        {
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Direcciones SET Estado = 0 WHERE CodigoDireccion =" + CodigoDireccion);
            AccederDatos.EjecutarConsulta();
            AccederDatos.CerrarConexion();

        }
    }
}
