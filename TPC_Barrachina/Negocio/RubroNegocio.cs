using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;


namespace Negocio
{
    public class RubroNegocio
    {
        private AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
        
        public List<Rubro> ListarRubros() {

            List<Rubro> ListadoRubros = new List<Rubro>();
            AccederDatos.LecturaBaseDatos("SELECT * FROM Rubros");
            while (AccederDatos.LectorDatos.Read()) {

                Rubro unNuevoRubro = new Rubro();
                unNuevoRubro.CodigoRubro = (int)AccederDatos.LectorDatos["CodigoRubro"];
                unNuevoRubro.Nombre = AccederDatos.LectorDatos["NombreRubro"].ToString();
                ListadoRubros.Add(unNuevoRubro);
            }
            return ListadoRubros;

        } 

    }
}
