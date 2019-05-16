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
        public AvisoConOpcion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Form FormularioActivo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Productos);
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
                this.Close();
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
