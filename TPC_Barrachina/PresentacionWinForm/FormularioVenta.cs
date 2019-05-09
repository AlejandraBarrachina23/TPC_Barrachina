using System;
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
            string NombreFormulario = "Cliente";
            Busqueda BusquedaCliente = new Busqueda(NombreFormulario);
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
            CierreCaja FormularioCierreCaja = new CierreCaja();
            FormularioCierreCaja.Show();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string NombreFormulario = "Productos";
            Busqueda BusquedaProducto = new Busqueda(NombreFormulario);
            BusquedaProducto.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
