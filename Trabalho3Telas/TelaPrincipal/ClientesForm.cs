using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaPrincipal
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "0")
            {
                Inserir();
            }
            else
            {
                Alterar();
            }
        }

        private void Alterar()
        {
            Clientes clientes = new Clientes();
            clientes.Id = Convert.ToInt32(lblId.Text);
            clientes.Nome = txtNome.Text;
            clientes.Peso = Convert.ToDecimal(mtbPeso.Text);
            clientes.Altura = Convert.ToDecimal(mtbAltura.Text);
            if(ckbNomeSujoSim.Checked)
            {
                clientes.NomeSujo = true;
            }
            else
            {
                clientes.NomeSujo = false;
            }
            clientes.Saldo = Convert.ToDecimal(mtbSaldo.Text);
            clientes.Telefone = Convert.ToInt32(mtbTelefone.Text);
            clientes.Estado = txtEstado.Text;
            clientes.Cidade = txtCidade.Text;
            clientes.Bairro = txtBairro.Text;
            clientes.Cep = Convert.ToInt32(mtbCep.Text);
            clientes.Logradouro = txtLogradouro.Text;
            clientes.Numero = Convert.ToInt32(txtNumero.Text);
            clientes.Complemento = txtComplemento.Text;

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\germa\Documents\TrabalhoCSharp.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE clientes SET 
nome = @NOME,
peso = @PESO,
altura = @ALTURA,
nome_sujo = @NOME_SUJO,
saldo = @SALDO,
telefone = @TELEFONE,
estado = @ESTADO,
cidade = @CIDADE,
bairro = @BAIRRO,
cep = @CEP,
logradouro = @LOGRADOURO,
numero = @NUMERO, 
complemento = @COMPLEMENTO
WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", clientes.Id);
            comando.Parameters.AddWithValue("@NOME", clientes.Nome);
            comando.Parameters.AddWithValue("@PESO", clientes.Peso);
            comando.Parameters.AddWithValue("@ALTURA", clientes.Altura);
            comando.Parameters.AddWithValue("@NOME_SUJO", clientes.NomeSujo);
            comando.Parameters.AddWithValue("@SALDO", clientes.Saldo);
            comando.Parameters.AddWithValue("@TELEFONE", clientes.Telefone);
            comando.Parameters.AddWithValue("@ESTADO", clientes.Estado);
            comando.Parameters.AddWithValue("@CIDADE", clientes.Cidade);
            comando.Parameters.AddWithValue("@BAIRRO", clientes.Bairro);
            comando.Parameters.AddWithValue("@CEP", clientes.Cep);
            comando.Parameters.AddWithValue("@LOGRADOURO", clientes.Logradouro);
            comando.Parameters.AddWithValue("@NUMERO", clientes.Numero);
            comando.Parameters.AddWithValue("@COMPLEMENTO", clientes.Complemento);
            comando.ExecuteNonQuery();
            conexao.Close();
            AtualizarTabela();
            LimparCampos();

            MessageBox.Show("Registro alterado com sucesso");
        }

        private void Inserir()
        {
            Clientes clientes = new Clientes();
            clientes.Nome = "";
            try
            {
                clientes.Nome = txtNome.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preenca adequadamente os campos");
                txtNome.Clear();
                txtNome.Focus();
                return;
            }

            clientes.Peso = 0;
            try
            {
                clientes.Peso = Convert.ToDecimal(mtbPeso.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preenca adequadamente os campos");
                mtbPeso.Clear();
                mtbPeso.Focus();
                return;
            }

            clientes.Altura = 0;
            try
            {
                clientes.Altura = Convert.ToDecimal(mtbAltura.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preenca adequadamente os campos");
                mtbAltura.Clear();
                mtbAltura.Focus();
                return;
            }

            if (ckbNomeSujoSim.Checked)
            {
                clientes.NomeSujo = true;
            }
            else
            {
                clientes.NomeSujo = false;
            }
        }

        private void LimparCampos()
        {

        }

        private void AtualizarTabela()
        {

        }

        private void dataGridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void ClientesForm_Activated(object sender, EventArgs e)
        {

        }
    }
}
