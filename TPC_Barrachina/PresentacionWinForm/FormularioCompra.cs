﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace PresentacionWinForm
{
    public partial class FormularioCompra : Form
    {
        private List<DetalleCompra> ListadoDetalleCompra = new List<DetalleCompra>();
        private DetalleCompra unDetalleCompra = new DetalleCompra();
        private Producto unProductoComprado = new Producto();
        private ProductoNegocio unProductoNegocio = new ProductoNegocio();
        private ProveedorNegocio unProveedorNegocio = new ProveedorNegocio();
        private ImpuestoNegocio unImpuestoNegocio = new ImpuestoNegocio();
        private Impuesto unImpuesto = new Impuesto();
        private List<Impuesto> ListadoImpuestos = new List<Impuesto>();
        private Utilidades Utilidades = new Utilidades();
        private int CuentaLinea = 1;

        public FormularioCompra()
        {
            InitializeComponent();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string NombreFormulario = "Productos";
            FormularioBusqueda BusquedaProducto = new FormularioBusqueda(NombreFormulario);
            BusquedaProducto.Show();
        }

        private void FormularioCompra_Load(object sender, EventArgs e)
        {
            try
            {
                cboxProveedor.DataSource = unProveedorNegocio.ListarProveedores();
                tboxNumeroOperacion.Enabled = false;
                tboxFechaEmision.Enabled = false;
                tboxHora.Enabled = false;
                tboxUsuario.Enabled = false;
                
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(Excepcion.Message);

            }
          
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                unProductoComprado = unProductoNegocio.BusquedaProducto(tboxCodigoBarra.Text);
                dgvDetalleCompra.DataSource = null;
                unDetalleCompra.Linea = CuentaLinea;
                unDetalleCompra.Producto = unProductoComprado;
                unDetalleCompra.Cantidad = Convert.ToInt32(tboxCantidad.Text);
                unDetalleCompra.PrecioUnitario = Convert.ToDecimal(tboxPrecioUnitario.Text);
                unDetalleCompra.Descuento = Convert.ToDecimal(tboxDescuento.Text);
                unDetalleCompra.PrecioNeto = Utilidades.CalcularBaseImponible(Convert.ToDecimal(tboxPrecioUnitario.Text), Convert.ToDecimal(tboxDescuento.Text));
                unDetalleCompra.PrecioBruto = Utilidades.CalcularPrecioBruto(ListadoImpuestos,unDetalleCompra.PrecioNeto);
                unDetalleCompra.PrecioPonderado = Utilidades.CalcularPrecioPonderado(unProductoComprado,unDetalleCompra);
                unDetalleCompra.Rentabilidad = unProductoComprado.Rentabilidad;
                unDetalleCompra.PrecioVenta = Utilidades.CalcularPrecioVenta(unDetalleCompra.PrecioBruto, (int)unProductoComprado.Rentabilidad);
                ListadoDetalleCompra.Add(unDetalleCompra);
                dgvDetalleCompra.DataSource = ListadoDetalleCompra;
                Utilidades.AjustarOrdenGridViewCompras(dgvDetalleCompra);
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(Excepcion.Message);
            }
            
        }

        private void cboxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Proveedor ProveedorSeleccionado = (Proveedor)cboxProveedor.SelectedItem;
            //ListadoImpuestos = unImpuestoNegocio.ListarImpuestosxProveedor(ProveedorSeleccionado.CodigoProveedor);
            //dgvImpuestos.DataSource = ListadoImpuestos;
        }

        private void dgvImpuestos_SelectionChanged(object sender, EventArgs e)
        {
  
            
        }

        private void HoraActual_Tick(object sender, EventArgs e)
        {
            tboxFechaEmision.Text = DateTime.Now.ToShortDateString();
            tboxHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DetalleCompraNegocio unDetalleCompraNegocio = new DetalleCompraNegocio();

            foreach (DetalleCompra unDetalleCompra in ListadoDetalleCompra)
            {
                unDetalleCompraNegocio.AgregarDetalleCompra(unDetalleCompra);
            }
        }
    }
}
