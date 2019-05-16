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

        public List<Impuesto> ListarRubros()
        {
            List<Impuesto> ListadoImpuestos = new List<Impuesto>();

            AccederDatos.LecturaBaseDatos("SELECT * FROM Impuestos");
            while (AccederDatos.LectorDatos.Read())
            {
                Impuesto unNuevoImpuesto = new Impuesto();
                unNuevoImpuesto.CodigoImpuesto = (int)AccederDatos.LectorDatos["CodigoRubro"];
                unNuevoImpuesto.Nombre = AccederDatos.LectorDatos["Nombre"].ToString();
                
                ListadoImpuestos.Add(unNuevoImpuesto);
            }
            return ListadoImpuestos;

        }

        //public Proveedor AgregaImpuesto(Impuesto unImpuesto, Proveedor unProveedor, decimal alicuota)
        //{

        //    //AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
        //    //AccederDatos.AbrirConexion();
        //    //AccederDatos.DefinirTipoComando("INSERT INTO ProveedorXImpuesto(CodigoProveedor,CodigoImpuesto,Alicuota) VALUES ("
        //    //    + unNuevoProveedor.CodigoProveedor + "," + unNuevoProveedor.RazonSocial + "," + unNuevoProveedor.NumeroCUIT + "," + unNuevoProveedor.NombreFantasia + "," + unNuevoProveedor.CondicionIVA + ")");
        //    //AccederDatos.EjecutarAccion();
        //    //AccederDatos.CerrarConexion();
        //    //AccederDatos.CerrarReader();
        //    //return unNuevoProveedor;

        //}
    }
}
