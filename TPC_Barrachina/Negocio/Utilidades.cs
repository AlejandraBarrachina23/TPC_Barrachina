﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Dominio;

namespace Negocio
{
    public class Utilidades
    {
        public string AsignarNombreFormulario(string Nombre)
        {

            switch (Nombre)
            {

                case "Clientes":
                    return "Listado Clientes";
                case "Productos":
                    return "Listado Productos";
                case "Proveedores":
                    return "Listado Proveedores";
                case "Rubros":
                    return "Rubros";
                case "Descuentos":
                    return "Descuentos";
                case "Impuestos":
                    return "Impuestos";
                default:
                    return "";
            }

        }

        public object DefinirEntidadAlistar(string NombreFormulario)
        {

            switch (NombreFormulario)
            {

                case "Clientes":
                    ClienteNegocio unCliente = new ClienteNegocio();
                    return unCliente.ListarClientes();
                case "Productos":
                    ProductoNegocio unProducto = new ProductoNegocio();
                    return unProducto.ListarProductos();
                case "Proveedores":
                    ProveedorNegocio unProveedor = new ProveedorNegocio();
                    return unProveedor.ListarProveedores();
                case "Rubros":
                    RubroNegocio unRubro = new RubroNegocio();
                    return unRubro.ListarRubros();
                case "Descuentos":
                    DescuentoNegocio unDescuento = new DescuentoNegocio();
                    return unDescuento.ListarDescuentos();
                case "Impuestos":
                    ImpuestoNegocio unImpuesto = new ImpuestoNegocio();
                    return unImpuesto.ListarImpuestos();
                default:
                    return null;
            }

        }
        
        public object DefinirEntidadaEliminar(object Entidad)
        {
            
            if (Entidad.GetType().Equals(typeof(Cliente)))
            {
                ClienteNegocio unClienteNegocio = new ClienteNegocio();
                unClienteNegocio.EliminarCliente((Cliente)Entidad);

            }

            else if (Entidad.GetType().Equals(typeof(Producto)))
            {
                ProductoNegocio unProducto = new ProductoNegocio();
                unProducto.EliminarProducto((Producto)Entidad);

            }

            else if(Entidad.GetType().Equals(typeof(Proveedor)))
            {

                ProveedorNegocio unProveedor = new ProveedorNegocio();
                unProveedor.EliminarProveedor((Proveedor)Entidad);

            }

            else if(Entidad.GetType().Equals(typeof(Rubro))) {

                RubroNegocio unRubro = new RubroNegocio();
                unRubro.EliminarRubro((Rubro)Entidad);
            }


            else if(Entidad.GetType().Equals(typeof(Impuesto)))
            {

                ImpuestoNegocio unImpuesto = new ImpuestoNegocio();
                unImpuesto.EliminarImpuesto((Impuesto)Entidad);
            }


            else if(Entidad.GetType().Equals(typeof(Descuento)))
            {

                DescuentoNegocio unDescuento = new DescuentoNegocio();
                unDescuento.EliminarDescuento((Descuento)Entidad);

            }

            return null;

        }

        public DataGridView OcultarColumnasDataGridView(DataGridView Grilla, string NombreTabla)
        {

            switch (NombreTabla) {

                case "Prductos":
                    Grilla.Columns[1].Visible = false;
                    Grilla.Columns[3].Visible = false;
                    Grilla.Columns[5].Visible = false;
                    Grilla.Columns[6].Visible = false;
                    Grilla.Columns[7].Visible = false;
                    Grilla.Columns[11].Visible = false;
                    Grilla.Columns[12].Visible = false;
                    Grilla.Columns[13].Visible = false;
                    return Grilla;

                case "Proveedores":
                       
                    Grilla.Columns[4].Visible = false;
                    Grilla.Columns[5].Visible = false;
                    Grilla.Columns[6].Visible = false;
                    Grilla.Columns[7].Visible = false;
                    return Grilla;

                case "Impuestos":

                    Grilla.Columns[2].Visible = false;
                    Grilla.Columns[4].Visible = false;
                    return Grilla;

                case "Clientes":

                    Grilla.Columns[3].Visible = false;
                    Grilla.Columns[6].Visible = false;
                    return Grilla;

                case "Detalle Venta":
                    Grilla.Columns[2].Visible = false;
                    Grilla.Columns[3].Visible = false;
                    return Grilla;
                default:
                    return null;
            }

       
        }

        public void AjustarOrdenGridView(DataGridView Grilla)
        {
            Grilla.Columns["Linea"].DisplayIndex = 0;
            Grilla.Columns["Producto"].DisplayIndex = 1;
            Grilla.Columns["Cantidad"].DisplayIndex = 2;
            Grilla.Columns["Bultos"].DisplayIndex = 3;
            Grilla.Columns["Unidades"].DisplayIndex = 4;
            Grilla.Columns["PrecioMinorista"].DisplayIndex = 5;
            Grilla.Columns["PrecioMayorista"].DisplayIndex = 6;
        }

        public object DefinirEntidadaFiltrar(Panel panelContenedor, Label lblNombreFormulario) {

            TextBox TextBoxSeleccionado = panelContenedor.Controls.OfType<TextBox>().FirstOrDefault(x => x.Text != "");
            string NombreTextBox = TextBoxSeleccionado.Name.Remove(0, 4);

            if (lblNombreFormulario.Text.Remove(0, 8) == "Productos")
            {
                ProductoNegocio unProducto = new ProductoNegocio();
                NombreTextBox += "Producto";
                List<Producto>ListadoProductosFiltrados = unProducto.FiltroProducto(TextBoxSeleccionado.Text, NombreTextBox);
                return ListadoProductosFiltrados;
            }

            else if (lblNombreFormulario.Text.Remove(0, 8) == "Clientes") {

                ClienteNegocio unCliente = new ClienteNegocio();
                NombreTextBox += "Cliente";
                List<Cliente>ListadoClientesFiltrados = unCliente.FiltrarCliente(TextBoxSeleccionado.Text, NombreTextBox);
                return ListadoClientesFiltrados;
            }

            else if (lblNombreFormulario.Text.Remove(0, 8) == "Proveedores")
            {
                ProveedorNegocio unProveedor = new ProveedorNegocio();
                NombreTextBox += "Proveedor";
                if (NombreTextBox == "NombreProveedor") NombreTextBox = "NombreFantasia";
                List<Proveedor> ListadoProveedoresFiltrados = unProveedor.FiltrarProveedor(TextBoxSeleccionado.Text, NombreTextBox);
                return ListadoProveedoresFiltrados;
            }

            throw new Exception("El " + NombreTextBox + " ingresado no existe");
        }

        public decimal CalcularDescuento(int Subtotal,decimal Descuento) {

            return Subtotal - (Subtotal * Descuento / 100);
        }
    }
}

        //public void DefinirFormularioActivos(Form FormularioActual)
        //{
        //    if (FormularioActual.ActiveMdiChild != null)
        //    {
        //        throw new Exception("La ventana ya se encuentra activa");
        //    }

        //}

