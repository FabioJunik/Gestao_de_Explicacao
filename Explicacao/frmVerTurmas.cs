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
    public partial class frmVerTurmas : Form
    {
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        principal principal = new principal();
        Panel painelPrincipal;
        MySqlConnection conexao;

        public frmVerTurmas(Panel panel)
        {
            InitializeComponent();
            painelPrincipal = panel;
            conexao = dbAuxiliar.buscarConexao();
        }

        private void btnVerMais_Click(object sender, EventArgs e)
        {
            if (dgvTurmas.Rows.Count == 0)
            {
                principal.Aviso("Não existem dados registados. Impossível conluir esta operação.");
                return;
            }
            int codTurma = Convert.ToInt32(dgvTurmas.CurrentRow.Cells[0].Value);
            principal.AbrirFormulario(new frmTurma(painelPrincipal, codTurma), painelPrincipal);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmAdicionarTurma(painelPrincipal), painelPrincipal);
        }

        private void frmVerTurmas_Load(object sender, EventArgs e)
        {
            string query = "SELECT codTurma AS 'Codigo', nome AS 'Nome', dataInicio AS 'Data Inicio', " +
                          "cod_disciplina, cod_nivel  FROM tbTurma;";
            dgvTurmas.DataSource = dbAuxiliar.ApresentarResultados(query);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTurmas.Rows.Count == 0) {
                principal.Aviso("Não existem dados registados. Impossível conluir esta operação.");
                return;
            }

            if (!principal.Confirmacao("A turma será apagado permanentemente. Deseja continuar?", "APGAR TURMA"))
                return;

            int codTurma = Convert.ToInt32(dgvTurmas.CurrentRow.Cells[0].Value);

            conexao.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "DELETE FROM tbTurma WHERE codTurma = @codTurma;";
            comando.Parameters.Add("@codTurma", MySqlDbType.Int32).Value = codTurma;
            comando.ExecuteNonQuery();

            comando.CommandText = "DELETE FROM tbProfessor_Turma WHERE cod_turma = @codTurma;";
            comando.ExecuteNonQuery();

            comando.CommandText = "DELETE FROM tbAluno_Turma WHERE cod_Turma = @codTurma;";
            comando.ExecuteNonQuery();

            principal.Aviso("Dados elimindados com sucesso!!");
            principal.AbrirFormulario(new frmAdicionarTurma(painelPrincipal), painelPrincipal);
        }
    }
}
