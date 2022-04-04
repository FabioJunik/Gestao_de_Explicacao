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
    public partial class frmVerAlunos : Form
    {
        Panel painel;
        principal principal = new principal();
        DBAuxiliar dbauxiliar = new DBAuxiliar();
        MySqlConnection conexao;
        int codAluno;

        public frmVerAlunos(Panel pnl)
        {
            InitializeComponent();
            painel = pnl;
            conexao = dbauxiliar.buscarConexao();
        }
        

        private void frmAluno_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmAdicionarAluno(painel), painel);
        }


        private void btnAdicionarEncarregado_Click_1(object sender, EventArgs e)
        {
            if (dgvAlunos.Rows.Count == 0) {
                principal.Aviso("Não há alunos registados. Impossível continuar operação.");
                return;
            }

            codAluno = Convert.ToInt32(dgvAlunos.CurrentRow.Cells[0].Value.ToString());
            frmAdicionarEncarregado frm = new frmAdicionarEncarregado(codAluno);
            frm.ShowDialog();
        }

        private void btnVerMais_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.Rows.Count == 0)
            {
                principal.Aviso("Não existem dados registados. Impossível conluir esta operação.");
                return;
            }
            codAluno = Convert.ToInt32(dgvAlunos.CurrentRow.Cells[0].Value);
            principal.AbrirFormulario(new frmAluno(painel, codAluno), painel);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (dgvAlunos.Rows.Count == 0) {
                principal.Aviso("Não existem dados registados. Impossível concluir esta operação.");
                return;
            }

            if (!principal.Confirmacao("O aluno será apagado permanentemente. Deseja continuar?", "APGAR ALUNO"))
                return;

            codAluno = Convert.ToInt32(dgvAlunos.CurrentRow.Cells[0].Value);

            conexao.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            
            comando.CommandText = "DELETE FROM tbAluno WHERE codAluno = @codAluno";
            comando.Parameters.Add("@codAluno", MySqlDbType.Int32).Value = codAluno;
            comando.ExecuteNonQuery();

            comando.CommandText = "DELETE FROM tbAluno_Turma WHERE cod_aluno = @codAluno";
            comando.ExecuteNonQuery();

            comando.CommandText = "DELETE FROM tbEndereco WHERE cod_aluno = @codAluno";
            comando.ExecuteNonQuery();

            comando.CommandText = "DELETE FROM tbTelefone WHERE cod_aluno = @codAluno";
            comando.ExecuteNonQuery();

            mostrar();
            principal.Aviso("Dados eliminado com sucesso");
        }

        private void mostrar()
        {
            string query = "SELECT codAluno AS 'Código', nome AS 'Nome', dataNasc AS 'Data de nascimento', " +
                           "sexo AS 'Sexo', IFNULL(email, 'SEM E-MAIL') AS 'E-mail' FROM tbAluno;";

            dgvAlunos.DataSource = dbauxiliar.ApresentarResultados(query);

            dgvAlunos.Columns[0].Width = 75;
            dgvAlunos.Columns["Sexo"].Width = 75;
            dgvAlunos.Columns["Nome"].Width = 250;
        }
    }
}
