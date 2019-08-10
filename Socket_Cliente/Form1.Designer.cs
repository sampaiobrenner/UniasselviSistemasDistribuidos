namespace Socket_Cliente
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picCliente = new System.Windows.Forms.PictureBox();
            this.lbmsgCliente = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(13, 63);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(322, 51);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Conectar com Servidor e Transferir Arquivo";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivo.Location = new System.Drawing.Point(13, 37);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(322, 22);
            this.txtArquivo.TabIndex = 1;
            this.txtArquivo.Text = "c:\\dados\\data.mdb";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe Local e nome do arquivo a transferir";
            // 
            // picCliente
            // 
            this.picCliente.Image = ((System.Drawing.Image)(resources.GetObject("picCliente.Image")));
            this.picCliente.Location = new System.Drawing.Point(342, 37);
            this.picCliente.Name = "picCliente";
            this.picCliente.Size = new System.Drawing.Size(93, 77);
            this.picCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCliente.TabIndex = 3;
            this.picCliente.TabStop = false;
            // 
            // lbmsgCliente
            // 
            this.lbmsgCliente.FormattingEnabled = true;
            this.lbmsgCliente.HorizontalScrollbar = true;
            this.lbmsgCliente.Location = new System.Drawing.Point(16, 120);
            this.lbmsgCliente.Name = "lbmsgCliente";
            this.lbmsgCliente.ScrollAlwaysVisible = true;
            this.lbmsgCliente.Size = new System.Drawing.Size(419, 212);
            this.lbmsgCliente.TabIndex = 4;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(454, 348);
            this.Controls.Add(this.lbmsgCliente);
            this.Controls.Add(this.picCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.btnEnviar);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTE";
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCliente;
        private System.Windows.Forms.ListBox lbmsgCliente;
    }
}

