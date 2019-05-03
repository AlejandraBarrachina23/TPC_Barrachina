using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{

    public class AccesoDatos
    {
        public static string CadenaConexion = "data source = localhost\\SQLEXPRESS; inital catalog=BARRACHINA_DB; integrated security= sspi";
        private SqlConnection ConexionSQL;
        private SqlCommand ComandoSQL;
        private SqlDataReader LectorDatos;

        public SqlDataReader Lector {

            get { return LectorDatos; }
        }

        public SqlCommand Comando {

            get { return ComandoSQL; }
        }

        public AccesoDatos() {

            ConexionSQL = new SqlConnection(CadenaConexion);
        }

        public void ConsultaSQL(string consulta) {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void EjecutarConsulta()
        {
            try
            {
                ComandoSQL.Connection = ConexionSQL;
                LectorDatos = ComandoSQL.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AbrirConexion()
        {
            try
            {
                ConexionSQL.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CerrarConexion()
        {
            try
            {
                ConexionSQL.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
