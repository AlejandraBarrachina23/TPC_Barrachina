using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class ImpuestoNegocio
    {
        private AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

        public List<Impuesto> ListarImpuestos()
        {
            List<Impuesto> ListadoImpuestos = new List<Impuesto>();

            AccederDatos.LecturaBaseDatos("SELECT * FROM Impuestos");
            while (AccederDatos.LectorDatos.Read())
            {
                Impuesto unNuevoImpuesto = new Impuesto();
                unNuevoImpuesto.CodigoImpuesto = (int)AccederDatos.LectorDatos["CodigoImpuesto"];
                unNuevoImpuesto.Nombre = AccederDatos.LectorDatos["Nombre"].ToString();
                
                ListadoImpuestos.Add(unNuevoImpuesto);
            }
            return ListadoImpuestos;

        }

        public void AgregarImpuesto(Impuesto unImpuesto, int CodigoProveedor)
        {
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("INSERT INTO ProveedorXImpuesto(CodigoProveedor,CodigoImpuesto,Alicuota) VALUES ("
                + CodigoProveedor + "," + unImpuesto.CodigoImpuesto + "," + unImpuesto.Alicuota + ")");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
                 
        }
    }
}
