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
            if (ckbNomeSujoSim.Checked)
            {
                clientes.NomeSujo = true;
            }
            else
            {
                clientes.NomeSujo = false;
            }
            clientes.Saldo = Convert.ToDecimal(mtbSaldo.Text);
            clientes.Telefone = mtbTelefone.Text;
            clientes.Estado = txtEstado.Text;
            clientes.Cidade = txtCidade.Text;
            clientes.Bairro = txtBairro.Text;
            clientes.Cep = mtbCep.Text;
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

            clientes.Saldo = 0;
            try
            {
                clientes.Saldo = Convert.ToDecimal(mtbSaldo.Text.Replace("R$", ""));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preenca adequadamente os campos");
                mtbSaldo.Clear();
                mtbSaldo.Focus();
                return;
            }

            clientes.Telefone = "";
            try
            {
                clientes.Telefone = mtbTelefone.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preenca adequadamente os campos");
                mtbTelefone.Clear();
                mtbTelefone.Focus();
                return;
            }

            clientes.Estado = "";
            try
            {
                clientes.Estado = txtEstado.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preenca adequadamente os campos");
                txtEstado.Clear();
                txtEstado.Focus();
                return;
            }

            clientes.Cidade = "";
            try
            {
                clientes.Cidade = txtCidade.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preenca adequadamente os campos");
                txtCidade.Clear();
                txtCidade.Focus();
                return;
            }

            clientes.Bairro = "";
            try
            {
                clientes.Bairro = txtBairro.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preenca adequadamente os campos");
                txtBairro.Clear();
                txtBairro.Focus();
                return;
            }

            clientes.Cep = "";
            try
            {
                clientes.Cep = mtbCep.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preenca adequadamente os campos");
                mtbCep.Clear();
                mtbCep.Focus();
                return;
            }

            clientes.Logradouro = "";
            try
            {
                clientes.Logradouro = txtLogradouro.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preenca adequadamente os campos");
                txtLogradouro.Clear();
                txtLogradouro.Focus();
                return;
            }

            clientes.Numero = 0;
            try
            {
                clientes.Numero = Convert.ToInt32(txtNumero.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preenca adequadamente os campos");
                txtNumero.Clear();
                txtNumero.Focus();
                return;
            }

            clientes.Complemento = "";
            try
            {
                clientes.Complemento = txtComplemento.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preenca adequadamente os campos");
                txtComplemento.Clear();
                txtComplemento
.Focus();
                return;
            }

            //Desenvolvimento de cadastro
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\germa\Documents\TrabalhoCSharp.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO clientes 
(nome, peso, altura, nome_sujo, saldo, telefone,
estado, cidade, bairro, cep,
logradouro, numero, complemento)
VALUES (@NOME, @PESO, @ALTURA, @NOME_SUJO, @SALDO, @TELEFONE,
@ESTADO, @CIDADE, @BAIRRO, @CEP,
@LOGRADOURO, @NUMERO, @COMPLEMENTO";

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
            MessageBox.Show("Registro criado com sucesso");
            LimparCampos();
            conexao.Close();
            AtualizarTabela();
        }

        private void LimparCampos()
        {
            lblId.Text = "0";
            txtNome.Clear();
            mtbPeso.Clear();
            mtbAltura.Clear();
            mtbSaldo.Clear();
            mtbTelefone.Clear();
            txtEstado.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            mtbCep.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();

        }

        private void AtualizarTabela()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\germa\Documents\TrabalhoCSharp.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM clientes";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            dataGridViewClientes.RowCount = 0;
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Clientes clientes = new Clientes();
                clientes.Id = Convert.ToInt32(linha["id"]);
                clientes.Nome = linha["nome"].ToString();
                clientes.Peso = Convert.ToDecimal(linha["peso"]);
                clientes.Altura = Convert.ToDecimal(linha["altura"]);
                clientes.NomeSujo = Convert.ToBoolean(linha["nome_sujo"]);
                clientes.Saldo = Convert.ToDecimal(linha["saldo"]);
                clientes.Telefone = linha["telefone"].ToString();
                clientes.Estado = linha["estado"].ToString();
                clientes.Cidade = linha["cidade"].ToString();
                clientes.Bairro = linha["bairro"].ToString();
                clientes.Cep = linha["cep"].ToString();
                clientes.Logradouro = linha["logradouro"].ToString();
                clientes.Numero = Convert.ToInt32(linha["numero"]);
                clientes.Complemento = linha["complemento"].ToString();
                dataGridViewClientes.Rows.Add(new string[] { clientes.Id.ToString(), clientes.Nome, clientes.Peso.ToString(), clientes.Altura.ToString(), clientes.NomeSujo.ToString(), clientes.Saldo.ToString(), clientes.Telefone, clientes.Estado, clientes.Cidade, clientes.Bairro, clientes.Cep, clientes.Logradouro, clientes.Numero.ToString(), clientes.Complemento });
            }
        }

        private void dataGridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewClientes.CurrentRow.Cells[0].Value);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\germa\Documents\TrabalhoCSharp.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.CommandText = @"SELECT id, nome, peso, altura, nome_sujo, saldo, telefone, estado, cidade, bairro, cep, logradouro, numero, complemento FROM clientes
WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.Connection = conexao;

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            DataRow linha = tabela.Rows[0];
            Clientes clientes = new Clientes();
            clientes.Id = Convert.ToInt32(linha["id"]);
            clientes.Nome = linha["nome"].ToString();
            clientes.Peso = Convert.ToDecimal(linha["peso"]);
            clientes.Altura = Convert.ToDecimal(linha["altura"]);
            clientes.NomeSujo = Convert.ToBoolean(linha["nome_sujo"]);
            clientes.Saldo = Convert.ToDecimal(linha["saldo"]);
            clientes.Telefone = linha["telefone"].ToString();
            clientes.Estado = linha["estado"].ToString();
            clientes.Cidade = linha["cidade"].ToString();
            clientes.Bairro = linha["bairro"].ToString();
            clientes.Cep = linha["cep"].ToString();
            clientes.Logradouro = linha["logradouro"].ToString();
            clientes.Numero = Convert.ToInt32(linha["numero"]);
            clientes.Complemento = linha["complemento"].ToString();

            lblId.Text = clientes.Id.ToString();
            txtNome.Text = clientes.Nome;
            mtbPeso.Text = clientes.Peso.ToString();
            mtbAltura.Text = clientes.Altura.ToString();
            if (ckbNomeSujoSim.Checked)
            {
                clientes.NomeSujo = true;
            }
            else
            {
                clientes.NomeSujo = false;
            }
            mtbSaldo.Text = clientes.Saldo.ToString();
            mtbTelefone.Text = clientes.Telefone;
            txtEstado.Text = clientes.Estado;
            txtCidade.Text = clientes.Cidade;
            txtBairro.Text = clientes.Bairro;
            mtbCep.Text = clientes.Cep;
            txtLogradouro.Text = clientes.Logradouro;
            txtNumero.Text = clientes.Numero.ToString();
            txtComplemento.Text = clientes.Complemento;

            conexao.Close();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cadastre colaborador");
                return;
            }

            DialogResult caixaDialogo = MessageBox.Show("Deseja realmente apagar?", "AVISO", MessageBoxButtons.YesNo);

            if (caixaDialogo == DialogResult.Yes)
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\germa\Documents\TrabalhoCSharp.mdf;Integrated Security=True;Connect Timeout=30";
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "DELETE FROM clientes WHERE id = @ID";

                int id = Convert.ToInt32(dataGridViewClientes.CurrentRow.Cells[0].Value);
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();

                conexao.Close();
                AtualizarTabela();
                LimparCampos();
            }
        }

        private void ClientesForm_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }
}
