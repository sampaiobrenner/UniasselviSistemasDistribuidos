using System;
using System.Windows.Forms;

namespace Socket_Cliente
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                FTCliente.EnviarArquivo(txtArquivo.Text);
                lbmsgCliente.Items.Add(FTCliente.mensagemCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}