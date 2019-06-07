﻿using System;
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
        public void ExistenciaDeDatoDB(string NombreColumna , string NombreTabla, string Parametro) {

            string Consulta = "SELECT " + NombreColumna + " FROM " + NombreTabla + " WHERE " + NombreColumna + " = '" + Parametro + "'";
            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
            AccederDatos.LecturaBaseDatos(Consulta);
            while (AccederDatos.LectorDatos.Read()) {

                if (AccederDatos.LectorDatos[NombreColumna].ToString().ToUpper() == Parametro.ToUpper())
                {
                    AccederDatos.CerrarConexion();
                    AccederDatos.CerrarReader();
                    throw new Exception("El " + NombreColumna +" " + Parametro +" ya existe");
                }

            }
            AccederDatos.CerrarConexion();
            AccederDatos.CerrarReader();
        }

        public void ContenidoTextBoxVacio(TextBox texto, string NombreCampo)
        {
            if (texto.Text.Trim() == "")
            {
                throw new Exception("El campo " + NombreCampo + " esta vacío");
            }
                        
        }

        public void SeleccionComboBox(ComboBox opciones, string NombreCampo)
        {

            if (opciones.SelectedIndex == -1)
            {
                throw new Exception("Seleccione una opción en " + NombreCampo);
            }
           
        }

        public void SeleccionItemDataGridView(DataGridView grilla) {

            if (grilla.SelectedRows == null) {

                throw new Exception("Seleccione un item");
            }
        }

        public void MinimoValor(TextBox texto, string NombreCampo, int valor) {

            ContenidoTextBoxVacio(texto, NombreCampo);

            long Minimo = Convert.ToInt64(texto.Text);

            if (Minimo <= valor) {

                throw new Exception("El campo" + NombreCampo + " acepta valores a partir del " + valor.ToString());
            }
         
        }

        public void Multiplo(TextBox textoUno, TextBox textoDos, string NombreCampoUno, string NombreCampoDos) {

            if (Convert.ToInt32(textoUno.Text) % Convert.ToInt32(textoDos.Text) != 0)
            {
                throw new Exception("El " + NombreCampoUno + " debe ser múltiplo de " + NombreCampoDos);
            }
        }

        public void FormularioProducto(TextBox tboxCodigoProducto, TextBox tboxCodigoBulto, TextBox tboxNombre, TextBox tboxCantidadBulto, TextBox tboxStockCritico, ComboBox cboxTipoProducto, ComboBox cboxRubro, ComboBox cboxProveedor,string TipoOperacion)
        {
            if (TipoOperacion == "Agregar") {

                ContenidoTextBoxVacio(tboxCodigoProducto, "Código Producto");
                ExistenciaDeDatoDB("CodigoProducto", "Productos", tboxCodigoProducto.Text);
                MinimoValor(tboxCodigoProducto, "Codigo Producto", 1);

                ContenidoTextBoxVacio(tboxCodigoBulto, "Código Bulto");
                ExistenciaDeDatoDB("CodigoBulto", "Productos", tboxCodigoBulto.Text);
                MinimoValor(tboxCodigoBulto, "Codigo Bulto", 10);

                ExistenciaDeDatoDB("Nombre", "Productos", tboxNombre.Text);
               
            }

            ContenidoTextBoxVacio(tboxNombre, "Nombre");
            ExistenciaRepetidaDeDatoDB("CodigoProducto", "Nombre", "Productos", "CodigoProducto", "Nombre", tboxNombre.Text, tboxCodigoProducto.Text);

            MinimoValor(tboxCantidadBulto, "Cantidad por bulto", 0);
            MinimoValor(tboxStockCritico, "Stock Crítico", 0);
            Multiplo(tboxStockCritico, tboxCantidadBulto, "Stock Crítico", "Cantidad por Bulto");

            SeleccionComboBox(cboxTipoProducto, "Tipo Producto");

            SeleccionComboBox(cboxProveedor, "Proveedor");

            SeleccionComboBox(cboxRubro, "Rubro");
        }

        public void FormularioRubro(TextBox tboxCodigoRubro, TextBox tboxNombre, string TipoOperacion) {

            if (TipoOperacion == "Agregar") {

                ContenidoTextBoxVacio(tboxCodigoRubro, "Codigo Rubro");
                ExistenciaDeDatoDB("CodigoRubro", "Rubros", tboxCodigoRubro.Text);
                ContenidoTextBoxVacio(tboxNombre, "Nombre");
                ExistenciaDeDatoDB("NombreRubro", "Rubros", tboxNombre.Text);
            }
            ContenidoTextBoxVacio(tboxNombre, "Nombre");
            ExistenciaRepetidaDeDatoDB("CodigoRubro", "NombreRubro", "Rubros", "CodigoRubro", "NombreRubro", tboxNombre.Text, tboxCodigoRubro.Text);

        }

        public void FormularioDescuento(TextBox tboxCodigoDescuento, TextBox tboxNombre, TextBox tboxPorcentaje, string TipoOperacion) {

            if (TipoOperacion == "Agregar") {

                ContenidoTextBoxVacio(tboxCodigoDescuento, "Codigo Descuento");
                ExistenciaDeDatoDB("CodigoDescuento", "Descuentos", tboxCodigoDescuento.Text);
                ExistenciaDeDatoDB("NombreDescuento", "Descuentos", tboxNombre.Text);
            }

            ExistenciaRepetidaDeDatoDB("CodigoDescuento", "NombreDescuento", "Descuentos", "CodigoDescuento", "NombreDescuento", tboxNombre.Text, tboxCodigoDescuento.Text);
            ContenidoTextBoxVacio(tboxNombre, "Nombre");
            ContenidoTextBoxVacio(tboxPorcentaje, "Porcentaje");
        }

        public void FormularioImpuesto(TextBox tboxCodigoImpuesto, TextBox tboxNombre, TextBox tboxDescripcion, string TipoOperacion) {

            if (TipoOperacion == "Agregar") {

                ContenidoTextBoxVacio(tboxCodigoImpuesto, "Codigo Impuesto");
                ExistenciaDeDatoDB("CodigoImpuesto", "Impuestos", tboxCodigoImpuesto.Text);
                ContenidoTextBoxVacio(tboxNombre, "Nombre");
                ExistenciaDeDatoDB("Nombre", "Impuestos", tboxNombre.Text);
            }
                ExistenciaRepetidaDeDatoDB("CodigoImpuesto", "Nombre", "Impuestos", "CodigoImpuesto", "Nombre", tboxNombre.Text, tboxCodigoImpuesto.Text);
                ContenidoTextBoxVacio(tboxDescripcion, "Descripcion");
        }

        public void ExistenciaRepetidaDeDatoDB(string DatoBuscarUno, string DatoBuscarDos, string NombreTabla, string NombreColumnaUno, string NombreColumnaDos,string Parametro, string CodigoRevisar)
        {
            AdministradorAccesoDatos AccederDatos = new AdministradorAccesoDatos();
            AccederDatos.AbrirConexion();
            AccederDatos.DefinirTipoComando("SELECT " + DatoBuscarUno + "," + DatoBuscarDos + " FROM " + NombreTabla + " WHERE " + NombreColumnaDos + " = '" + Parametro + "'");
            AccederDatos.EjecutarConsulta();           
            
            while (AccederDatos.LectorDatos.Read())
            {
                if (AccederDatos.LectorDatos[NombreColumnaUno].ToString() != CodigoRevisar) {

                    if (AccederDatos.LectorDatos[NombreColumnaDos].ToString().ToUpper() == Parametro.ToUpper())
                    {
                        AccederDatos.CerrarConexion();
                        AccederDatos.CerrarReader();
                        throw new Exception("El " + DatoBuscarDos + " " + Parametro + " ya existe");
                    }
                }
                    
            }

            AccederDatos.CerrarConexion();
            AccederDatos.CerrarReader();
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