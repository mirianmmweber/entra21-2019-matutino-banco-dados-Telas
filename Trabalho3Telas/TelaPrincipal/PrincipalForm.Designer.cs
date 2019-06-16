namespace TelaPrincipal
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            this.btnPeixes = new System.Windows.Forms.Button();
            this.btnColaboradores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPeixes
            // 
            this.btnPeixes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPeixes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPeixes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPeixes.Location = new System.Drawing.Point(18, 385);
            this.btnPeixes.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnPeixes.Name = "btnPeixes";
            this.btnPeixes.Size = new System.Drawing.Size(247, 78);
            this.btnPeixes.TabIndex = 0;
            this.btnPeixes.Text = "Peixes";
            this.btnPeixes.UseVisualStyleBackColor = false;
            this.btnPeixes.Click += new System.EventHandler(this.btnPeixes_Click);
            // 
            // btnColaboradores
            // 
            this.btnColaboradores.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnColaboradores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColaboradores.Location = new System.Drawing.Point(290, 385);
            this.btnColaboradores.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnColaboradores.Name = "btnColaboradores";
            this.btnColaboradores.Size = new System.Drawing.Size(247, 78);
            this.btnColaboradores.TabIndex = 1;
            this.btnColaboradores.Text = "Colaboradores";
            this.btnColaboradores.UseVisualStyleBackColor = false;
            this.btnColaboradores.Click += new System.EventHandler(this.btnColaboradores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.Location = new System.Drawing.Point(555, 385);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(247, 78);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 479);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnColaboradores);
            this.Controls.Add(this.btnPeixes);
            this.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Name = "TelaPrincipalForm";
            this.Text = "Tela Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPeixes;
        private System.Windows.Forms.Button btnColaboradores;
        private System.Windows.Forms.Button btnClientes;
    }
}

