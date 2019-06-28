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
    public partial class BusquedaAuxiliar : Form
    {
        private Utilidades utilidades = new Utilidades();
        private string NombreFormulario;

        public BusquedaAuxiliar(string NombreRecibido)
        {
            InitializeComponent();
            NombreFormulario = NombreRecibido;
        }

        private void BusquedaAuxiliar_Load(object sender, EventArgs e)
        {
            this.Text= utilidades.AsignarNombreFormulario(NombreFormulario);
            cboxListado.DataSource = utilidades.DefinirEntidadAlistar(NombreFormulario);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.Text == "Rubros")
            {

                Rubros FormularioRubro = new Rubros();
                FormularioRubro.MdiParent = this.MdiParent;
                FormularioRubro.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormularioAgregarModificar_FormClosed);
                FormularioRubro.Show();
            }

            else if (this.Text == "Impuestos")
            {
                FormularioImpuestos FormularioImpuesto = new FormularioImpuestos();
                FormularioImpuesto.MdiParent = this.MdiParent;
                FormularioImpuesto.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormularioAgregarModificar_FormClosed);
                FormularioImpuesto.Show();
            }

            else if (this.Text == "Descuentos") {


                Descuentos FormularioDescuento = new Descuentos();
                FormularioDescuento.MdiParent = this.MdiParent;
                FormularioDescuento.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormularioAgregarModificar_FormClosed);
                FormularioDescuento.Show();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.Text == "Rubros")
            {

                Rubros FormularioRubro = new Rubros((Rubro)cboxListado.SelectedItem);
                FormularioRubro.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormularioAgregarModificar_FormClosed);
                FormularioRubro.MdiParent = this.MdiParent;
                FormularioRubro.Show();
            }

            else if (this.Text == "Impuestos")
            {
                FormularioImpuestos FormularioImpuesto = new FormularioImpuestos((Impuesto)cboxListado.SelectedItem);
                FormularioImpuesto.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormularioAgregarModificar_FormClosed);
                FormularioImpuesto.MdiParent = this.MdiParent;
                FormularioImpuesto.Show();
            }

            else if (this.Text == "Descuentos")
            {
                Descuentos FormularioDescuento = new Descuentos((Descuento)cboxListado.SelectedItem);
                FormularioDescuento.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormularioAgregarModificar_FormClosed);
                FormularioDescuento.MdiParent = this.MdiParent;
                FormularioDescuento.Show();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            utilidades.DefinirEntidadaEliminar(cboxListado.SelectedItem);
            cboxListado.DataSource = utilidades.DefinirEntidadAlistar(NombreFormulario);
        }


        private void FormularioAgregarModificar_FormClosed(object sender, FormClosedEventArgs e)
        {
            cboxListado.DataSource = utilidades.DefinirEntidadAlistar(NombreFormulario);
        }


    }
}
