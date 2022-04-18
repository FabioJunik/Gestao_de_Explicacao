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
    public partial class frmPainelControle : Form
    {
        Panel painel = new Panel();
        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        MySqlConnection conexao;
        MySqlCommand comando;

        public frmPainelControle(Panel pnl)
        {
            InitializeComponent();
            painel = pnl;
            conexao = dbAuxiliar.buscarConexao();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerProfs(painel), painel);
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerAlunos(painel), painel);
        }

        private void btnEncarregado_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerEncarregados(), painel);
        }

        private void btnFalta_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerFaltas(), painel);
        }

        private void btnDisciplina_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmDisciplina(painel), painel);
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmHorario(painel), painel);
        }

        private void btnSala_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmSala(painel), painel);
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerTurmas(painel), painel);
        }

        private void btnNivel_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmNivel(painel), painel);
        }

        private void btnConfiguracaoes_Click(object sender, EventArgs e)
        {
        }

        private void frmPainelControle_Load(object sender, EventArgs e)
        {
            string miniQuery = "SELECT COUNT(*) FROM ";

            conexao.Open();

            comando = new MySqlCommand($" {miniQuery} tbAluno;", conexao);
            btnAluno.LabelText = "Alunos ("+comando.ExecuteScalar()+")";

            comando.CommandText = miniQuery + " tbProfessor;";
            btnProfessor.LabelText = "Professores (" + comando.ExecuteScalar() + ")";

            comando.CommandText = miniQuery + " tbEncarregado;";
            btnEncarregado.LabelText = "Encarregados (" + comando.ExecuteScalar() + ")";

            comando.CommandText = miniQuery + " tbTurma;";
            btnTurma.LabelText = "Turmas (" + comando.ExecuteScalar() + ")";

            comando.CommandText = miniQuery + " tbSala;";
            btnSala.LabelText = "Sala (" + comando.ExecuteScalar() + ")";

            comando.CommandText = miniQuery + " tbDisciplina;";
            btnDisciplina.LabelText = "Disciplinas (" + comando.ExecuteScalar() + ")";

            conexao.Close();
        }
    }
}
