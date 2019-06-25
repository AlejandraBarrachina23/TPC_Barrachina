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
    public class ImpuestoNegocio
    {
        private AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

        public List<Impuesto> ListarImpuestos()
        {
            List<Impuesto> ListadoImpuestos = new List<Impuesto>();

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("SELECT * FROM Impuestos");
            AccederDatos.EjecutarConsulta();
            while (AccederDatos.LectorDatos.Read())
            {
                Impuesto unNuevoImpuesto = new Impuesto();

                if ((bool)AccederDatos.LectorDatos["Estado"]) { 
                    unNuevoImpuesto.CodigoImpuesto = (int)AccederDatos.LectorDatos["CodigoImpuesto"];
                    unNuevoImpuesto.Nombre = AccederDatos.LectorDatos["Nombre"].ToString();
                    unNuevoImpuesto.Descripcion = AccederDatos.LectorDatos["Descripcion"].ToString();
                    ListadoImpuestos.Add(unNuevoImpuesto);
                }
               
            }

            AccederDatos.CerrarReader();
            AccederDatos.CerrarConexion();
            return ListadoImpuestos;

        }

        public void AgregarImpuestoXProveedor(Impuesto unImpuesto, int CodigoProveedor)
        {
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("INSERT INTO ProveedorXImpuesto(CodigoProveedor,CodigoImpuesto,Alicuota) VALUES ("
                + CodigoProveedor + "," + unImpuesto.CodigoImpuesto + "," + unImpuesto.Alicuota + ")");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();

        }

        public void AgregarImpuesto(Impuesto unImpuesto)
        {
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("INSERT INTO Impuestos(CodigoImpuesto,Nombre,Descripcion) VALUES ('"+ unImpuesto.CodigoImpuesto + "','" + unImpuesto.Nombre + "','" + unImpuesto.Descripcion + "')");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();

        }

        public List<Impuesto> ListarImpuestosxProveedor(int CodigoProveedor){

            List<Impuesto> ListadoImpuestos = new List<Impuesto>();
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("SELECT ProveedorXImpuesto.CodigoImpuesto, ProveedorXImpuesto.CodigoProveedor, ProveedorXImpuesto.Alicuota, Impuestos.Nombre FROM ProveedorXImpuesto INNER JOIN " +
            "Impuestos ON ProveedorXImpuesto.CodigoImpuesto = Impuestos.CodigoImpuesto WHERE ProveedorXImpuesto.CodigoProveedor = '" + CodigoProveedor + "'");
            AccederDatos.EjecutarConsulta();
            while (AccederDatos.LectorDatos.Read()) {

                Impuesto unImpuesto = new Impuesto();
                unImpuesto.CodigoImpuesto = (int)AccederDatos.LectorDatos["CodigoImpuesto"];
                unImpuesto.Alicuota = (decimal)AccederDatos.LectorDatos["Alicuota"];
                unImpuesto.Nombre = AccederDatos.LectorDatos["Nombre"].ToString();
                ListadoImpuestos.Add(unImpuesto);
            }

            AccederDatos.CerrarReader();
            AccederDatos.CerrarConexion();
            return ListadoImpuestos;
        }

        public void EliminarImpuesto(Impuesto unImpuesto) {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Impuestos SET Estado=0 WHERE CodigoImpuesto = '" + unImpuesto.CodigoImpuesto + "'");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();

        }

        public Impuesto CargarImpuesto(TextBox tboxCodigoImpuesto, TextBox tboxNombre, TextBox tboxDescripcion) {

            Impuesto unImpuesto = new Impuesto();
            unImpuesto.CodigoImpuesto = Convert.ToInt32(tboxCodigoImpuesto.Text);
            unImpuesto.Nombre = tboxNombre.Text;
            unImpuesto.Descripcion = tboxDescripcion.Text;
            return unImpuesto;
        }

        public void ModificarImpuesto(Impuesto unImpuesto) {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Impuestos SET Nombre=@Nombre, Descripcion=@Descripcion WHERE CodigoImpuesto ='" + unImpuesto.CodigoImpuesto + "'");
            AccederDatos.Comando.Parameters.Clear();
            AccederDatos.Comando.Parameters.AddWithValue("@Nombre", unImpuesto.Nombre);
            AccederDatos.Comando.Parameters.AddWithValue("@Descripcion", unImpuesto.Descripcion);
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();

        }

        public decimal CalcularPorcentaje(decimal Precio, Impuesto unImpuesto) {

            return Precio * unImpuesto.Alicuota / 100;
        }

    }
}
