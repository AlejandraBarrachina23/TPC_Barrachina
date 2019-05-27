using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using AccesoDatos;


namespace Negocio
{
    
    public class TipoProductoNegocio
    {
        private AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

        public List<TipoProducto> ListarTipoProducto() {

            List <TipoProducto> ListaTipoProducto = new List<TipoProducto>();
            AccederDatos.LecturaBaseDatos("SELECT * FROM TipoProductos");
            while (AccederDatos.LectorDatos.Read()) {

                TipoProducto unTipoProducto = new TipoProducto();
                unTipoProducto.CodigoTipoProducto = (int)AccederDatos.LectorDatos["CodigoTipoProducto"];
                unTipoProducto.Nombre = AccederDatos.LectorDatos["NombreTipoProducto"].ToString();
                ListaTipoProducto.Add(unTipoProducto);
                
            }

            AccederDatos.CerrarReader();
            AccederDatos.CerrarConexion();
            return ListaTipoProducto;
        }
        
    }
}
