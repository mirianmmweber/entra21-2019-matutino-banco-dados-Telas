namespace TelaPrincipal
{
    partial class ClientesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mtbSaldo = new System.Windows.Forms.MaskedTextBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.rbNomeSujoSim = new System.Windows.Forms.RadioButton();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeSujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComlemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(978, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(1016, 79);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 17);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "0";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 34);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 17);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(19, 102);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(39, 17);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(15, 167);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(47, 17);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Altura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nome Sujo?";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(15, 295);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(42, 17);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(161, 420);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(97, 17);
            this.lblComplemento.TabIndex = 7;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(15, 360);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(62, 17);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(160, 34);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 17);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(160, 167);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(45, 17);
            this.lblBairro.TabIndex = 10;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(161, 229);
            this.lblCep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(30, 17);
            this.lblCep.TabIndex = 11;
            this.lblCep.Text = "CEP";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(161, 295);
            this.lblLogradouro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(80, 17);
            this.lblLogradouro.TabIndex = 12;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(160, 360);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 17);
            this.lblNumero.TabIndex = 13;
            this.lblNumero.Text = "Número:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(18, 55);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(116, 22);
            this.txtNome.TabIndex = 15;
            // 
            // mtbSaldo
            // 
            this.mtbSaldo.Location = new System.Drawing.Point(18, 316);
            this.mtbSaldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbSaldo.Mask = "$999999.99";
            this.mtbSaldo.Name = "mtbSaldo";
            this.mtbSaldo.Size = new System.Drawing.Size(76, 22);
            this.mtbSaldo.TabIndex = 16;
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(163, 250);
            this.mtbCep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbCep.Mask = "99999-999";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(76, 22);
            this.mtbCep.TabIndex = 17;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(18, 381);
            this.mtbTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbTelefone.Mask = "(99)9999-9999";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(116, 22);
            this.mtbTelefone.TabIndex = 20;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(163, 316);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(116, 22);
            this.txtLogradouro.TabIndex = 21;
            // 
            // rbNomeSujoSim
            // 
            this.rbNomeSujoSim.AutoSize = true;
            this.rbNomeSujoSim.Location = new System.Drawing.Point(18, 250);
            this.rbNomeSujoSim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNomeSujoSim.Name = "rbNomeSujoSim";
            this.rbNomeSujoSim.Size = new System.Drawing.Size(47, 21);
            this.rbNomeSujoSim.TabIndex = 24;
            this.rbNomeSujoSim.TabStop = true;
            this.rbNomeSujoSim.Text = "Sim";
            this.rbNomeSujoSim.UseVisualStyleBackColor = true;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(163, 381);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(78, 22);
            this.txtNumero.TabIndex = 25;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(163, 441);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(116, 22);
            this.txtComplemento.TabIndex = 26;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(160, 102);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 17);
            this.lblCidade.TabIndex = 27;
            this.lblCidade.Text = "Cidade";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(953, 433);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 30);
            this.btnExcluir.TabIndex = 29;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(953, 381);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 30);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnPeso,
            this.ColumnAltura,
            this.ColumnNomeSujo,
            this.ColumnSaldo,
            this.ColumnTelefone,
            this.ColumnEstado,
            this.ColumnCidade,
            this.ColumnBairro,
            this.ColumnCep,
            this.ColumnLogradouro,
            this.ColumnNumero,
            this.ColumnComlemento});
            this.dataGridViewClientes.Location = new System.Drawing.Point(336, 34);
            this.dataGridViewClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.Size = new System.Drawing.Size(599, 429);
            this.dataGridViewClientes.TabIndex = 31;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnPeso
            // 
            this.ColumnPeso.HeaderText = "Peso";
            this.ColumnPeso.Name = "ColumnPeso";
            this.ColumnPeso.ReadOnly = true;
            // 
            // ColumnAltura
            // 
            this.ColumnAltura.HeaderText = "Altura";
            this.ColumnAltura.Name = "ColumnAltura";
            this.ColumnAltura.ReadOnly = true;
            // 
            // ColumnNomeSujo
            // 
            this.ColumnNomeSujo.HeaderText = "Nome sujo?";
            this.ColumnNomeSujo.Name = "ColumnNomeSujo";
            this.ColumnNomeSujo.ReadOnly = true;
            // 
            // ColumnSaldo
            // 
            this.ColumnSaldo.HeaderText = "Saldo";
            this.ColumnSaldo.Name = "ColumnSaldo";
            this.ColumnSaldo.ReadOnly = true;
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.HeaderText = "Telefone";
            this.ColumnTelefone.Name = "ColumnTelefone";
            this.ColumnTelefone.ReadOnly = true;
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.ReadOnly = true;
            // 
            // ColumnCidade
            // 
            this.ColumnCidade.HeaderText = "Cidade";
            this.ColumnCidade.Name = "ColumnCidade";
            this.ColumnCidade.ReadOnly = true;
            // 
            // ColumnBairro
            // 
            this.ColumnBairro.HeaderText = "Bairro";
            this.ColumnBairro.Name = "ColumnBairro";
            this.ColumnBairro.ReadOnly = true;
            // 
            // ColumnCep
            // 
            this.ColumnCep.HeaderText = "CEP";
            this.ColumnCep.Name = "ColumnCep";
            this.ColumnCep.ReadOnly = true;
            // 
            // ColumnLogradouro
            // 
            this.ColumnLogradouro.HeaderText = "Logradouro";
            this.ColumnLogradouro.Name = "ColumnLogradouro";
            this.ColumnLogradouro.ReadOnly = true;
            // 
            // ColumnNumero
            // 
            this.ColumnNumero.HeaderText = "Número";
            this.ColumnNumero.Name = "ColumnNumero";
            this.ColumnNumero.ReadOnly = true;
            // 
            // ColumnComlemento
            // 
            this.ColumnComlemento.HeaderText = "Complemento";
            this.ColumnComlemento.Name = "ColumnComlemento";
            this.ColumnComlemento.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 188);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 22);
            this.textBox1.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 123);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 22);
            this.textBox2.TabIndex = 33;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 55);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 22);
            this.textBox3.TabIndex = 34;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(18, 123);
            this.maskedTextBox1.Mask = "999.99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(76, 22);
            this.maskedTextBox1.TabIndex = 35;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(18, 187);
            this.maskedTextBox2.Mask = "9.99";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(76, 22);
            this.maskedTextBox2.TabIndex = 36;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 492);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.rbNomeSujoSim);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.mtbCep);
            this.Controls.Add(this.mtbSaldo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtbSaldo;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.RadioButton rbNomeSujoSim;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAltura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeSujo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComlemento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}