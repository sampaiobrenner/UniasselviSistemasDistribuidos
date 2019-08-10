using System;
using System.Windows.Forms;

namespace ClientView
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            var retorno = new ClientHelper().EnviarDadosAoServidor(txtDados.Text);
            lblRetorno.Text = retorno;
            txtDados.Clear();
        }

        private void TxtDados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnviar.PerformClick();
            }
        }
    }
}