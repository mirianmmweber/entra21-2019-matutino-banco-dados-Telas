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
    public partial class ColaboradoresForm : Form
    {
        public ColaboradoresForm()
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
            Colaboradores colaboradores = new Colaboradores();
            colaboradores.Id = Convert.ToInt32(lblId.Text);
            colaboradores.Nome = txtNome.Text;
            colaboradores.Cpf = mtbCpf.Text;
            colaboradores.Salario = Convert.ToDecimal(mtbSalario.Text.Replace("R$", ""));
            colaboradores.Sexo = cbSexo.SelectedItem.ToString();
            colaboradores.Cargo = txtCargo.Text;
            if (ckbProgramadorSim.Checked)
            {
                colaboradores.Programador = true;
            }
            else
            {
                colaboradores.Programador = false;
            }
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\germa\Documents\TrabalhoCSharp.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE colaboradores SET
nome = @NOME,
cpf = @CPF,
salario = @SALARIO,
sexo = @SEXO,
cargo = @CARGO,
programador = @PROGRAMADOR
WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", colaboradores.Id);
            comando.Parameters.AddWithValue("@NOME", colaboradores.Nome);
            comando.Parameters.AddWithValue("@CPF", colaboradores.Cpf);
            comando.Parameters.AddWithValue("@SALARIO", colaboradores.Salario);
            comando.Parameters.AddWithValue("@SEXO", colaboradores.Sexo);
            comando.Parameters.AddWithValue("@CARGO", colaboradores.Cargo);
            comando.Parameters.AddWithValue("@PROGRAMADOR", colaboradores.Programador);
            comando.ExecuteNonQuery();
            conexao.Close();
            AtualizarTabela();
            LimparCampos();

            MessageBox.Show("Registro alterado com sucesso");
        }

        private void Inserir()
        {
            Colaboradores colaboradores = new Colaboradores();
            colaboradores.Nome = "";
            try
            {
                colaboradores.Nome = txtNome.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preenca adequadamente os campos");
                txtNome.Clear();
                txtNome.Focus();
                return;
            }

            colaboradores.Cpf = "";
            try
            {
                colaboradores.Cpf = mtbCpf.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preenca adequadamente os campos");
                mtbCpf.Clear();
                mtbCpf.Focus();
                return;
            }

            colaboradores.Salario = 0;
            try
            {
                colaboradores.Salario = Convert.ToDecimal(mtbSalario.Text.Replace("R$", ""));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preenca adequadamente os campos");
                mtbSalario.Clear();
                mtbSalario.Focus();
                return;
            }

            colaboradores.Sexo = cbSexo.SelectedItem.ToString();
            if (cbSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o Sexo");
                cbSexo.Focus();
                cbSexo.DroppedDown = true;
                return;
            }

            colaboradores.Cargo = "";
            try
            {
                colaboradores.Cargo = txtCargo.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preenca adequadamente os campos");
                txtCargo.Clear();
                txtCargo.Focus();
                return;
            }


            if (ckbProgramadorSim.Checked)
            {
                colaboradores.Programador = true;
            }
            else
            {
                colaboradores.Programador = false;
            }

            //Desenvolvimento da tela de cadastro
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\germa\Documents\TrabalhoCSharp.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO colaboradores
(nome, cpf, salario, sexo, cargo, programador)
VALUES (@NOME, @CPF, @SALARIO, @SEXO, @CARGO, @PROGRAMADOR)";

            comando.Parameters.AddWithValue("@NOME", colaboradores.Nome);
            comando.Parameters.AddWithValue("@CPF", colaboradores.Cpf);
            comando.Parameters.AddWithValue("@SALARIO", colaboradores.Salario);
            comando.Parameters.AddWithValue("@SEXO", colaboradores.Sexo);
            comando.Parameters.AddWithValue("@CARGO", colaboradores.Cargo);
            comando.Parameters.AddWithValue("@PROGRAMADOR", colaboradores.Programador);
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
            mtbCpf.Clear();
            mtbSalario.Clear();
            cbSexo.SelectedIndex = -1;
            txtCargo.Text = "";
        }

        private void AtualizarTabela()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\germa\Documents\TrabalhoCSharp.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM colaboradores";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            dataGridViewColaboradores.RowCount = 0;
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Colaboradores colaboradores = new Colaboradores();
                colaboradores.Id = Convert.ToInt32(linha["id"]);
                colaboradores.Nome = linha["nome"].ToString();
                colaboradores.Cpf = linha["cpf"].ToString();
                colaboradores.Salario = Convert.ToDecimal(linha["salario"]);
                colaboradores.Sexo = linha["sexo"].ToString();
                colaboradores.Cargo = linha["cargo"].ToString();
                colaboradores.Programador = Convert.ToBoolean(linha["programador"]);
                dataGridViewColaboradores.Rows.Add(new string[] { colaboradores.Id.ToString(), colaboradores.Nome, colaboradores.Cpf, colaboradores.Salario.ToString(), colaboradores.Cargo, colaboradores.Sexo, colaboradores.Programador.ToString() });
            }
        }

        private void dataGridViewColaboradores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewColaboradores.CurrentRow.Cells[0].Value);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\germa\Documents\TrabalhoCSharp.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.CommandText = @"SELECT id, nome, cpf, salario, sexo, cargo, programador FROM colaboradores
WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.Connection = conexao;

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            DataRow linha = tabela.Rows[0];
            Colaboradores colaboradores = new Colaboradores();
            colaboradores.Id = Convert.ToInt32(linha["id"]);
            colaboradores.Nome = linha["nome"].ToString();
            colaboradores.Cpf = linha["cpf"].ToString();
            colaboradores.Salario = Convert.ToDecimal(linha["salario"]);
            colaboradores.Sexo = linha["sexo"].ToString();
            colaboradores.Cargo = linha["cargo"].ToString();
            colaboradores.Programador = Convert.ToBoolean(linha["programador"]);

            lblId.Text = colaboradores.Id.ToString();
            txtNome.Text = colaboradores.Nome;
            mtbCpf.Text = colaboradores.Cpf;
            mtbSalario.Text = colaboradores.Salario.ToString();
            cbSexo.SelectedItem = colaboradores.Sexo;
            txtCargo.Text = colaboradores.Cargo;
            if (ckbProgramadorSim.Checked)
            {
                colaboradores.Programador = true;
            }
            else
            {
                colaboradores.Programador = false;
            }

            conexao.Close();
        }

        private void ColaboradoresForm_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewColaboradores.SelectedRows.Count == 0)
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
                comando.Connection = conexao;
                comando.CommandText = "DELETE FROM colaboradores WHERE id = @ID";

                int id = Convert.ToInt32(dataGridViewColaboradores.CurrentRow.Cells[0].Value);
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();

                conexao.Close();
                AtualizarTabela();
                LimparCampos();
            }
        }

        private void ColaboradoresForm_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }
}
