using System;
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
    public partial class ImpuestosxProveedor : Form

    {
        int CodigoProveedorSeleccionado;

        public ImpuestosxProveedor(int CodigoProveedor)
        {
            InitializeComponent();
            CodigoProveedorSeleccionado = CodigoProveedor;
        }

        private void ImpuestosxProveedor_Load(object sender, EventArgs e)
        {
            ImpuestoNegocio unImpuestoNegocio = new ImpuestoNegocio();
            dgvImpuestosxProveedor.DataSource = unImpuestoNegocio.ListarImpuestosxProveedor(CodigoProveedorSeleccionado);
        }
    }
}
