using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;


namespace Negocio
{
    public class ValidadorDatos
    {
        public bool ValidarExistenciaDeDato(string NombreColumna , string NombreTabla, string Parametro) {

            string Consulta = "SELECT " + NombreColumna + " FROM " + NombreTabla + " WHERE " + NombreColumna + " = '" + Parametro + "'";
            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
            AccederDatos.LecturaBaseDatos(Consulta);
            while (AccederDatos.LectorDatos.Read()) {

                if (AccederDatos.LectorDatos[NombreColumna].ToString() == Parametro)
                {
                    AccederDatos.CerrarConexion();
                    AccederDatos.CerrarReader();
                    return true;
                }

            }
             return false;
        }
    }
}