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
    public partial class PeixesForm : Form
    {
        public PeixesForm()
        {
            InitializeComponent();
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
            Peixes peixes = new Peixes();
            peixes.Id = Convert.ToInt32(lblId.Text);
            peixes.Nome = txtNome.Text;
            peixes.Raca = cbRaca.SelectedItem.ToString();
            peixes.Preco = Convert.ToDecimal(mtbPreco.Text.Replace("R$", ""));
            peixes.Quantidade = Convert.ToInt32(nudQuantidade.Value);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\germa\Documents\TrabalhoCSharp.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE peixes SET 
nome = @NOME,
raca = @RACA,
preco = @PRECO,
quantidade = @QUANTIDADE
WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", peixes.Id);
            comando.Parameters.AddWithValue("@NOME", peixes.Nome);
            comando.Parameters.AddWithValue("@RACA", peixes.Raca);
            comando.Parameters.AddWithValue("@PRECO", peixes.Preco);
            comando.Parameters.AddWithValue("@QUANTIDADE", peixes.Quantidade);
            comando.ExecuteNonQuery();
            conexao.Close();
            AtualizarTabela();
            LimparCampos();

            MessageBox.Show("Registro alterado com sucesso");
        }

        private void Inserir()
        {
            Peixes peixes = new Peixes();
            peixes.Nome = "";
            try
            {
                peixes.Nome = txtNome.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preenche adequadamente os campos");
                txtNome.Clear();
                txtNome.Focus();
                return;
            }

            if (cbRaca.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Raça");
                return;
            }
            else
            {
                peixes.Raca = cbRaca.SelectedItem.ToString();
            }

            peixes.Preco = 0;
            try
            {
                peixes.Preco = Convert.ToDecimal(mtbPreco.Text.Replace("R$", ""));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha adequadamente os campos");
                mtbPreco.Clear();
                mtbPreco.Focus();
                return;
            }

            peixes.Quantidade = 0;
            try
            {
                peixes.Quantidade = Convert.ToInt32(nudQuantidade.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("O campo quantidade deve ser preenchido");
                nudQuantidade.Focus();
                return;
            }

            //Desenvolvimento de tela
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\germa\Documents\TrabalhoCSharp.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO peixes (nome, raca, preco, quantidade)
VALUES (@NOME, @RACA, @PRECO, @QUANTIDADE)";
            comando.Parameters.AddWithValue("@NOME", peixes.Nome);
            comando.Parameters.AddWithValue("@RACA", peixes.Raca);
            comando.Parameters.AddWithValue("@PRECO", peixes.Preco);
            comando.Parameters.AddWithValue("@QUANTIDADE", peixes.Quantidade);
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
            cbRaca.SelectedIndex = -1;
            mtbPreco.Clear();
            nudQuantidade.Value = 0;
        }

        private void AtualizarTabela()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\germa\Documents\TrabalhoCSharp.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM peixes";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            dataGridViewPeixes.RowCount = 0;
            for(int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Peixes peixes = new Peixes();
                peixes.Id = Convert.ToInt32(linha["id"]);
                peixes.Nome = linha["nome"].ToString();
                peixes.Raca = linha["raca"].ToString();
                peixes.Preco = Convert.ToDecimal(linha["preco"]);
                peixes.Quantidade = Convert.ToInt32(linha["quantidade"]);
                dataGridViewPeixes.Rows.Add(new string[] { peixes.Id.ToString(), peixes.Nome, peixes.Raca, peixes.Preco.ToString(), peixes.Quantidade.ToString()});    
            }
        }

        private void dataGridViewPeixes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void PeixesForm_Load(object sender, EventArgs e)
        {
            AtualizarTabela();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(dataGridViewPeixes.SelectedRows.Count ==0)
            {
                MessageBox.Show("Cadastre Peixes");
                return;
            }

            DialogResult caixaDialogo = MessageBox.Show("Deseja realmente apagar?", "AVISO", MessageBoxButtons.YesNo);

            if(caixaDialogo == DialogResult.Yes)
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\germa\Documents\TrabalhoCSharp.mdf;Integrated Security=True;Connect Timeout=30";
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = @"DELETE FROM peixes WHERE id = @ID";

                int id = Convert.ToInt32(dataGridViewPeixes.CurrentRow.Cells[0].Value);
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();

                conexao.Close();
                AtualizarTabela();
                LimparCampos();
            }
        }

        private void PeixesForm_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void dataGridViewPeixes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewPeixes.CurrentRow.Cells[0].Value);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\germa\Documents\TrabalhoCSharp.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.CommandText = @"SELECT id, nome, raca, preco, quantidade
FROM peixes 
WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.Connection = conexao;

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            DataRow linha = tabela.Rows[0];
            Peixes peixes = new Peixes();
            peixes.Id = Convert.ToInt32(linha["id"]);
            peixes.Nome = linha["nome"].ToString();
            peixes.Raca = linha["raca"].ToString();
            peixes.Preco = Convert.ToDecimal(linha["preco"]);
            peixes.Quantidade = Convert.ToInt32(linha["quantidade"]);

            lblId.Text = peixes.Id.ToString();
            txtNome.Text = peixes.Nome;
            cbRaca.SelectedItem = peixes.Raca;
            mtbPreco.Text = peixes.Preco.ToString();
            nudQuantidade.Value = peixes.Quantidade;

            conexao.Close();
        }
    }
}
