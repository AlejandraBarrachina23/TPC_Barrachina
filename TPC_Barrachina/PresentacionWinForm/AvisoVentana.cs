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
    public partial class Avisos : Form
    {
        public string FormularioACerrar;
        private Form FormularioActivo;

        public Avisos(string FormularioQuellamo)
        {
            InitializeComponent();
            FormularioACerrar = FormularioQuellamo;
         
        }

        private void Avisos_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (FormularioACerrar == "Productos") { 
                FormularioActivo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Productos);
            }

            else if (FormularioACerrar == "Proveedores") {
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
    }
}
