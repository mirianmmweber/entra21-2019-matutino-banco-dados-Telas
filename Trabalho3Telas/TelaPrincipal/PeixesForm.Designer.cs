namespace TelaPrincipal
{
    partial class PeixesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeixesForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.mtbPreco = new System.Windows.Forms.MaskedTextBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewPeixes = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeixes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(475, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(457, 140);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 35);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(457, 185);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 35);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Transparent;
            this.lblNome.Location = new System.Drawing.Point(11, 41);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 18);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.BackColor = System.Drawing.Color.Transparent;
            this.lblRaca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRaca.Location = new System.Drawing.Point(11, 105);
            this.lblRaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(51, 18);
            this.lblRaca.TabIndex = 4;
            this.lblRaca.Text = "Raça:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPreco.Location = new System.Drawing.Point(208, 41);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(56, 18);
            this.lblPreco.TabIndex = 5;
            this.lblPreco.Text = "Preço:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblQuantidade.Location = new System.Drawing.Point(208, 105);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(101, 18);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblId.Location = new System.Drawing.Point(505, 68);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 25);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "0";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(14, 64);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(133, 26);
            this.txtNome.TabIndex = 0;
            // 
            // cbRaca
            // 
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Items.AddRange(new object[] {
            "GoldFish",
            "Neon Chinês",
            "Tetras",
            "Dânios",
            "Beta",
            "Molly",
            "Piapara",
            "Pirarucu",
            "Robalo",
            "Matrinxã"});
            this.cbRaca.Location = new System.Drawing.Point(14, 128);
            this.cbRaca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(133, 28);
            this.cbRaca.TabIndex = 1;
            // 
            // mtbPreco
            // 
            this.mtbPreco.Location = new System.Drawing.Point(211, 64);
            this.mtbPreco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbPreco.Mask = "999999.99";
            this.mtbPreco.Name = "mtbPreco";
            this.mtbPreco.Size = new System.Drawing.Size(99, 26);
            this.mtbPreco.TabIndex = 2;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(211, 128);
            this.nudQuantidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(102, 26);
            this.nudQuantidade.TabIndex = 3;
            // 
            // dataGridViewPeixes
            // 
            this.dataGridViewPeixes.AllowUserToAddRows = false;
            this.dataGridViewPeixes.AllowUserToDeleteRows = false;
            this.dataGridViewPeixes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeixes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnRaca,
            this.ColumnPreco,
            this.ColumnQuantidade});
            this.dataGridViewPeixes.Location = new System.Drawing.Point(26, 254);
            this.dataGridViewPeixes.Name = "dataGridViewPeixes";
            this.dataGridViewPeixes.ReadOnly = true;
            this.dataGridViewPeixes.Size = new System.Drawing.Size(543, 190);
            this.dataGridViewPeixes.TabIndex = 12;
            this.dataGridViewPeixes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPeixes_CellContentClick);
            this.dataGridViewPeixes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPeixes_CellDoubleClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnRaca
            // 
            this.ColumnRaca.HeaderText = "Raça";
            this.ColumnRaca.Name = "ColumnRaca";
            this.ColumnRaca.ReadOnly = true;
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.HeaderText = "Preço";
            this.ColumnPreco.Name = "ColumnPreco";
            this.ColumnPreco.ReadOnly = true;
            // 
            // ColumnQuantidade
            // 
            this.ColumnQuantidade.HeaderText = "Quantidade";
            this.ColumnQuantidade.Name = "ColumnQuantidade";
            this.ColumnQuantidade.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.nudQuantidade);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.mtbPreco);
            this.groupBox1.Controls.Add(this.lblQuantidade);
            this.groupBox1.Controls.Add(this.lblRaca);
            this.groupBox1.Controls.Add(this.cbRaca);
            this.groupBox1.Controls.Add(this.lblPreco);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(26, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 193);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // PeixesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 481);
            this.Controls.Add(this.dataGridViewPeixes);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PeixesForm";
            this.Text = "Tela de Cadastro Peixes";
            this.Activated += new System.EventHandler(this.PeixesForm_Activated);
            this.Load += new System.EventHandler(this.PeixesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeixes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.MaskedTextBox mtbPreco;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.DataGridView dataGridViewPeixes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidade;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}