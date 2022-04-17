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
    public partial class frmVerNota : Form
    {
        Panel painel;
        principal principal = new principal();
        DBAuxiliar dbauxiliar = new DBAuxiliar();
        MySqlConnection conexao;
        MySqlCommand comando;

        int codAluno;
        int codTurma;

        public frmVerNota(Panel pnl, int codAluno, int codTurma)
        {
            InitializeComponent();
            painel = pnl;
            this.codAluno = codAluno;
            this.codTurma = codTurma;
            conexao = dbauxiliar.buscarConexao();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
           frmAdicionarNota frmAdicionarNota = new frmAdicionarNota(codAluno, codTurma);

            frmAdicionarNota.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmAluno(painel,codAluno), painel);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarNota frmEditarNota = new frmEditarNota(codAluno,codTurma);
            frmEditarNota.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmVerNota_Load(object sender, EventArgs e)
        {
            mostrarDados();
        }

        private void mostrarDados()
        {
            string query ="SELECT codNota AS 'Código', prova AS 'Prova', nota AS 'Nota' FROM tbNota;";

            dgvNota.DataSource = dbauxiliar.ApresentarResultados(query);

            query = $"SELECT nome FROM tbAluno WHERE codAluno = {codAluno} ";

            conexao.Open();

            comando = new MySqlCommand(query, conexao);
            lblNome.Text = comando.ExecuteScalar().ToString();

            comando.CommandText = $"SELECT nome FROM tbTurma WHERE codTurma = {codTurma}";
            lblTurma.Text = comando.ExecuteScalar().ToString();

            conexao.Close();
        }
    }
}
