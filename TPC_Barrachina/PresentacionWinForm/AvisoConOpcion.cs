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
    public partial class AvisoConOpcion : Form
    {
        public string FormularioACerrar;
        private Form FormularioActivo;

        public AvisoConOpcion(string FormularioQueLlamo)
        {
            InitializeComponent();
            FormularioACerrar = FormularioQueLlamo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (FormularioACerrar == "Productos")
            {
                FormularioActivo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Productos);
            }

            else if (FormularioACerrar == "Proveedores")
            {
                FormularioActivo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Proveedores);

            }

            else if (FormularioACerrar == "Clientes")
            {
                FormularioActivo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Clientes);

            }

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
                this.Close();
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
