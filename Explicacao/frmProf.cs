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
    public partial class frmProf : Form
    {
        Panel painel;
        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        MySqlConnection conexao;
        MySqlCommand comando;

        int codProf;
        string nome, email;
        string municipio, bairro, rua;
        string telefones;
        string dataNasc;
        string sexo;

        public frmProf(Panel pnl, int codProf)
        {
            InitializeComponent();
            conexao = dbAuxiliar.buscarConexao();
            painel = pnl;
            this.codProf = codProf;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            email = txtEmail.Text;
            municipio = txtMunicipio.Text;
            bairro = txtBairro.Text;
            rua = txtRua.Text;
            telefones = txtTelefone.Text;
            dataNasc = dtpDataNasc.Value.ToString("yyyy-MM-dd");
            sexo = rdFemenino.Checked ? "F" : "M";


            string query = "UPDATE tbProfessor SET " +
                           "nome = @nome, dataNasc = @dataNasc, sexo = @sexo, email = @email " +
                           "WHERE codProf = @codProf;";

            conexao.Open();
            comando = new MySqlCommand(query, conexao);
            comando.Parameters.Add("@nome", MySqlDbType.String).Value = nome;
            comando.Parameters.Add("@dataNasc", MySqlDbType.String).Value = dataNasc;
            comando.Parameters.Add("@sexo", MySqlDbType.String).Value = sexo;
            comando.Parameters.Add("@email", MySqlDbType.String).Value = email;
            comando.Parameters.Add("@codProf", MySqlDbType.Int32).Value = codProf;
            comando.ExecuteNonQuery();
            comando.Dispose();
            conexao.Close();

            actualizarTelefone();
            actualizarEndereco();

            principal.Aviso("Dados salvos com sucesso");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerProfs(painel), painel);
        }

        private void frmProf_Load(object sender, EventArgs e)
        {
            mostrarDados();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerProfs(painel), painel);
        }

        private void actualizarTelefone()
        {
            string[] telefone = txtTelefone.Text.Split('/');

            dbAuxiliar.actualizarTelefone(telefone[0], codProf, 0);

            if (telefone.Length > 1)
                dbAuxiliar.actualizarTelefone(telefone[1], codProf, 0);
        }

        private void actualizarEndereco()
        {
            dbAuxiliar.actualizarEndereco(codProf, 0, municipio, bairro, rua);
        }
        private void mostrarDados()
        {
            telefones = dbAuxiliar.buscarTelefone(codProf, 1);
            municipio = dbAuxiliar.buscarMunicipio(codProf, 1);
            bairro = dbAuxiliar.buscarBairro(codProf, 1);
            rua = dbAuxiliar.buscarRua(codProf, 1);

            conexao.Open();
            comando = new MySqlCommand("SELECT * FROM tbProfessor WHERE codProf = @codProf;", conexao);
            comando.Parameters.Add("@codProf", MySqlDbType.Int32).Value = codProf;
            var dados = comando.ExecuteReader();

            while (dados.Read())
            {
                nome = dados.GetString("nome");
                email = dados.GetString("email");
                dataNasc = dados.GetDateTime("dataNasc").ToString().Split(' ')[0];
                sexo = dados.GetString("sexo");
            }

            dados.Close();
            comando.Dispose();
            conexao.Close();

            string query = "SELECT cod_turma AS 'Codigo', nome AS 'Nome' " +
                            "FROM tbProfessor_turma INNER JOIN tbTurma ON codTurma = cod_turma " +
                            $"WHERE cod_prof = {codProf}";

            dgvTurmasProf.DataSource = dbAuxiliar.ApresentarResultados(query);

            txtNome.Text = nome;
            txtEmail.Text = email;
            txtMunicipio.Text = municipio;
            txtBairro.Text = bairro;
            txtRua.Text = rua;
            txtTelefone.Text = telefones;
            dtpDataNasc.Text = dataNasc;
            rdFemenino.Checked = sexo == "F" ? true : false;
            rdMasculino.Checked = sexo == "M" ? true : false;
        }
    }
}
