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
        public bool ExistenciaDeDatoDB(string NombreColumna , string NombreTabla, string Parametro) {

            string Consulta = "SELECT " + NombreColumna + " FROM " + NombreTabla + " WHERE " + NombreColumna + " = '" + Parametro + "'";
            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
            AccederDatos.LecturaBaseDatos(Consulta);
            while (AccederDatos.LectorDatos.Read()) {

                if (AccederDatos.LectorDatos[NombreColumna].ToString().ToUpper() == Parametro.ToUpper())
                {
                    AccederDatos.CerrarConexion();
                    AccederDatos.CerrarReader();
                    return true;
                }

            }
            return false;
        }

        public bool ContenidoTextBox(TextBox texto)
        {
            if (texto.Text.Trim() == "")
            {
                return true;
            }
            return false;
        }

        public bool SeleccionComboBox(ComboBox opciones)
        {

            if (opciones.SelectedIndex == -1)
            {
                return true;
            }
            return false;
        }

        public void SeleccionItemDataGridView(DataGridView grilla) {

            if (grilla.SelectedRows == null) {

                throw new Exception("Seleccione un item");
            }
        }

        //public void ItemRepetidoGrid(DataGridView Grilla, string valorAgregar) {

        //    //(Grilla.Rows.Cast<DataGridViewRow>().Any(x => x.Cells["Nombre"].Value.ToString() == item.ToString())) 

           
        //    foreach (DataGridViewRow fila in Grilla.Rows) {

        //        string valorFila = fila.Cells["Nombre"].Value.ToString();
        //        MessageBox.Show(valorFila);

        //        if (valorAgregar == valorFila) {

        //            throw new Exception("Repetido");
                    
        //        }
                    
        //    }

        //    MessageBox.Show("paso");
           
        //}
    }
    
}