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
    public partial class MetodoPago : Form
    {
        public MetodoPago()
        {
            InitializeComponent();
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            btnCreditoUnaCuota.Visible = true;
            btnCreditoTresCuotas.Visible = true;
        }
    }
}
