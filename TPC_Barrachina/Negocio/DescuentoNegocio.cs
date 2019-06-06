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
    public class DescuentoNegocio

    {
        AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();

        public List<Descuento> ListarDescuentos()
        {

            List<Descuento> ListadoDescuentos = new List<Descuento>();
            AccederDatos.LecturaBaseDatos("SELECT * FROM Descuentos");
            while (AccederDatos.LectorDatos.Read())
            {

                Descuento unDescuento = new Descuento();

                if ((bool)AccederDatos.LectorDatos["Estado"]) {

                    unDescuento.CodigoDescuento = (int)AccederDatos.LectorDatos["CodigoDescuento"];
                    unDescuento.Nombre = AccederDatos.LectorDatos["NombreDescuento"].ToString();
                    unDescuento.Porcentaje = (decimal)AccederDatos.LectorDatos["Porcentaje"];

                    ListadoDescuentos.Add(unDescuento);

                }
                
            }
            return ListadoDescuentos;

        }

        public void EliminarDescuento(Descuento unDescuento) {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Descuentos SET Estado = 0 WHERE CodigoDescuento ='" + unDescuento.CodigoDescuento + "'");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();

        }

        public void AgregarDescuento(Descuento unDescuento) {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("INSERT INTO Descuentos (CodigoDescuento,NombreDescuento,Porcentaje) VALUES ('" + unDescuento.CodigoDescuento + "','" + unDescuento.Nombre + "','" + unDescuento.Porcentaje + "')");
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();


        }

        public Descuento CargarDescuento(TextBox tboxCodigoDescuento, TextBox tboxNombre, TextBox tboxPorcentaje)
        {
            Descuento unDescuento = new Descuento();
            unDescuento.CodigoDescuento = Convert.ToInt32(tboxCodigoDescuento.Text);
            unDescuento.Nombre = tboxNombre.Text;
            unDescuento.Porcentaje = Convert.ToDecimal(tboxPorcentaje.Text);
            return unDescuento;

        }

        public void ModificarDescuento(Descuento unDescuento) {

            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("UPDATE Descuentos SET NombreDescuento = @NombreDescuento, Porcentaje =@Porcentaje WHERE CodigoDescuento ='" + unDescuento.CodigoDescuento + "'");
            AccederDatos.Comando.Parameters.Clear();
            AccederDatos.Comando.Parameters.AddWithValue("@NombreDescuento", unDescuento.Nombre);
            AccederDatos.Comando.Parameters.AddWithValue("@Porcentaje", unDescuento.Porcentaje);
            AccederDatos.EjecutarAccion();
            AccederDatos.CerrarConexion();
        }
    }
}
