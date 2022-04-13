using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Explicacao
{
    public partial class frmAluno : Form
    {
        Panel painel;
        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        MySqlConnection conexao;
        MySqlCommand comando;

        int codAluno;
        string nome, email;
        string municipio, bairro, rua;
        string telefones;
        string dataNasc;
        string sexo;
        public frmAluno(Panel pnl, int codAluno)
        {
            InitializeComponent();
            painel = pnl;
            this.codAluno = codAluno;
            conexao = dbAuxiliar.buscarConexao();
        }

        private void frmAluno_Load(object sender, EventArgs e)
        {
            mostrarDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            email = txtEmail.Text;
            telefones = txtTelefone.Text;
            dataNasc = dtpDataNasc.Value.ToString("yyyy-MM-dd");
            sexo = rdFemenino.Checked ? "F" : "M";
            municipio = txtMunicipio.Text;
            bairro = txtBairro.Text;
            rua = txtRua.Text;

            string query = "UPDATE tbAluno SET " +
                            "nome = @nome, dataNasc = @dataNasc, sexo = @sexo, email = @email " + 
                            "WHERE codAluno = @codAluno;";

            conexao.Open();
            comando = new MySqlCommand(query, conexao);
            comando.Parameters.Add("@nome", MySqlDbType.String).Value = nome;
            comando.Parameters.Add("@dataNasc", MySqlDbType.String).Value = dataNasc;
            comando.Parameters.Add("@sexo", MySqlDbType.String).Value = sexo;
            comando.Parameters.Add("@email", MySqlDbType.String).Value = email;
            comando.Parameters.Add("@codAluno", MySqlDbType.Int32).Value = codAluno;

            comando.ExecuteNonQuery();
            comando.Dispose();
            conexao.Close();

            actualizarTelefone();
            actualizarEndereco();

            principal.Aviso("Dados inseridos com sucesso!");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerAlunos(painel), painel);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!principal.Confirmacao("O aluno será apagado permanentemente. Deseja continuar?", "APAGAR ALUNO"))
                return;

            conexao.Open();
            comando = new MySqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "DELETE FROM tbAluno WHERE codAluno = @codAluno";
            comando.Parameters.Add("@codAluno", MySqlDbType.Int32).Value = codAluno;

            comando.CommandText = "DELETE FROM tbAluno_Turma WHERE cod_aluno = @codAluno";
            comando.ExecuteNonQuery();

            comando.CommandText = "DELETE FROM tbEndereco WHERE cod_aluno = @codAluno";
            comando.ExecuteNonQuery();

            comando.CommandText = "DELETE FROM tbTelefone WHERE cod_aluno = @codAluno";
            comando.ExecuteNonQuery();

            comando.Dispose();
            conexao.Close();

            principal.AbrirFormulario(new frmVerAlunos(painel), painel);
            principal.Aviso("Dados apagados com sucesso!");
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            principal.ApenasTexto(e);
        }

        private void txtMunicipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            principal.ApenasTexto(e);
        }

        private void guna2VSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void btnNota_Click(object sender, EventArgs e)
        {
            int codTurma = Convert.ToInt32(dgvTurma.CurrentRow.Cells[0].Value);
            principal.AbrirFormulario(new frmVerNota(painel,codAluno,codTurma), painel);
        }

        private void btnPropina_Click(object sender, EventArgs e)
        {
            int codTurma = Convert.ToInt32(dgvTurma.CurrentRow.Cells[0].Value);
            principal.AbrirFormulario(new frmVerPropinas(painel, codAluno,codTurma), painel);
        }

        private void mostrarDados()
        {
            telefones = dbAuxiliar.buscarTelefone(codAluno, 2);
            municipio = dbAuxiliar.buscarMunicipio(codAluno, 2);
            bairro = dbAuxiliar.buscarBairro(codAluno, 2);
            rua = dbAuxiliar.buscarRua(codAluno, 2);
            string query = "SELECT * FROM tbAluno WHERE codAluno = @codAluno;";

            conexao.Open();
            comando = new MySqlCommand(query, conexao);
            comando.Parameters.Add("@codAluno", MySqlDbType.Int32).Value = codAluno;

            var dados = comando.ExecuteReader();

            while (dados.Read())
            {
                nome = dados.GetString("nome");
                email = dados.GetString("email");
                dataNasc = dados.GetDateTime("dataNasc").ToString().Split(' ')[0];
                sexo = dados.GetString("sexo");
            }

            dados.Close();
            conexao.Close();

            txtNome.Text = nome;
            txtEmail.Text = email;
            txtMunicipio.Text = municipio;
            txtBairro.Text = bairro;
            txtRua.Text = rua;
            txtTelefone.Text = telefones;
            dtpDataNasc.Text = dataNasc;
            rdMasculino.Checked = true;
            rdFemenino.Checked = sexo == "F" ? true : false;
            rdMasculino.Checked = sexo == "M" ? true : false;


            query = "SELECT codTurma AS 'Codigo', nome AS 'Nome', dataInicio AS 'Data Inicio' " +
                    "FROM tbAluno_Turma INNER JOIN tbTurma on codTurma = cod_turma " +
                    $"WHERE cod_aluno = {codAluno};";

            dgvTurma.DataSource = dbAuxiliar.ApresentarResultados(query);

        }

        private void actualizarTelefone()
        {
            string[] telefone = txtTelefone.Text.Split('/');

            dbAuxiliar.actualizarTelefone(telefone[0], codAluno, 1);

            if (telefone.Length > 1)
                dbAuxiliar.actualizarTelefone(telefone[1], codAluno, 1);
        }

        private void actualizarEndereco()
        {
            dbAuxiliar.actualizarEndereco(codAluno, 1, municipio, bairro, rua);
        }
    }
}
