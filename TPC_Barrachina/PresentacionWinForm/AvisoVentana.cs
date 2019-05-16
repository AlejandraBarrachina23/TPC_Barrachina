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
       

        public Avisos()
        {
            InitializeComponent();
         
        }

        private void Avisos_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form FormularioActivo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Productos);
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
                this.Close();
            }
            this.Close();
        }
    }
}
