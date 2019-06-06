using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Windows.Forms;
using AccesoDatos;



namespace Negocio
{
    public class RubroNegocio
    {
        private AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
        
        public List<Rubro> ListarRubros() {

            List<Rubro> ListadoRubros = new List<Rubro>();
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("SELECT * FROM Rubros");
            AccederDatos.EjecutarConsulta();

            while (AccederDatos.LectorDatos.Read()) {

                Rubro unNuevoRubro = new Rubro();

                if ((bool)AccederDatos.LectorDatos["Estado"]) {

                    unNuevoRubro.CodigoRubro = (int)AccederDatos.LectorDatos["CodigoRubro"];
                    unNuevoRubro.Nombre = AccederDatos.LectorDatos["NombreRubro"].ToString();
                    ListadoRubros.Add(unNuevoRubro);
                }
                
                
            }

            AccederDatos.CerrarConexion();
            return ListadoRubros;

        }

        public void EliminarRubro(Rubro unRubro) {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Rubros SET Estado = 0 WHERE CodigoRubro ='" + unRubro.CodigoRubro + "'");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();

        }

        public void AgregarRubro(Rubro unRubro) {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("INSERT INTO Rubros(CodigoRubro,NombreRubro)VALUES('"+unRubro.CodigoRubro+"','"+unRubro.Nombre+"')");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();

        }

        public Rubro CargarRubro(TextBox tboxCodigoRubro, TextBox tboxNombre) {

            Rubro unRubro = new Rubro();

            unRubro.CodigoRubro = Convert.ToInt32(tboxCodigoRubro.Text);
            unRubro.Nombre = tboxNombre.Text;
            return unRubro;
        }

        public void ModificarRubro(Rubro unRubro) {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Rubros SET NombreRubro = '" + unRubro.Nombre + "' WHERE CodigoRubro = '" + unRubro.CodigoRubro + "'");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
        }
    }
}
