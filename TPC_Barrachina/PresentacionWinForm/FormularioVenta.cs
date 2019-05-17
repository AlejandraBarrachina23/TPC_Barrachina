﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentacionWinForm
{
    public partial class FormularioVenta : Form
    {

        public FormularioVenta()
        {
            InitializeComponent();
        }

         private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FormularioBusqueda BusquedaCliente = new FormularioBusqueda("Cliente", "Formulario Venta");
            BusquedaCliente.Show();
        }

        private void btnMetodoPago_Click(object sender, EventArgs e)
        {
            MetodoPago FormularioMetodoPago = new MetodoPago();
            FormularioMetodoPago.Show();
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            MotivoDevolucion FormularioMotivoDevolucion = new MotivoDevolucion();
            FormularioMotivoDevolucion.Show();
        }

        private void btnUltimasActualizaciones_Click(object sender, EventArgs e)
        {
            UltimasActualizaciones FormularioUltimasActualizaciones = new UltimasActualizaciones();
            FormularioUltimasActualizaciones.Show();
        }

        private void btnRetiroDinero_Click(object sender, EventArgs e)
        {
            RetiroDinero FormularioRetiroDinero = new RetiroDinero();
            FormularioRetiroDinero.Show();
        }

        private void btnCierreCaja_Click(object sender, EventArgs e)
        {
            FormularioCierreCaja FormularioCierreCaja = new FormularioCierreCaja();
            FormularioCierreCaja.Show();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            
            FormularioBusqueda BusquedaProducto = new FormularioBusqueda("Productos", "Formulario Venta");
            BusquedaProducto.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculadora8_Click(object sender, EventArgs e)
        {

        }
    }
}
