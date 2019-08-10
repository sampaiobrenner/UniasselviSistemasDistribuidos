using System;
using System.Windows.Forms;

namespace Socket_Servidor
{
    public partial class frmServidor : Form
    {
        public frmServidor()
        {
            InitializeComponent();
        }

        private void btnIniciarServidor_Click(object sender, EventArgs e)
        {
            FTServidor.IniciarServidor();
            txtStatus.Text = FTServidor.mensagemServidor;
        }
    }
}