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
    public partial class frmVerPropinas : Form
    {
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        MySqlConnection conexao;
        principal principal = new principal();
        Panel painel;

        int codAluno;
        int codTurma;
        bool click;

        public frmVerPropinas(Panel pnl, int codAluno, int codTurma)
        {
            InitializeComponent();
            painel = pnl;
            this.codAluno = codAluno;
            this.codTurma = codTurma;
            conexao = dbAuxiliar.buscarConexao();

        }

        private void frmVerPropinas_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void mostrar()
        {
            conexao.Open();
            MySqlCommand comando = new MySqlCommand("SELECT nome FROM tbTurma WHERE codTurma = @codTurma;",conexao);
            comando.Parameters.Add("@codTurma", MySqlDbType.Int32).Value = codTurma;
            comando.Parameters.Add("@codAluno", MySqlDbType.Int32).Value = codAluno;

            lblTurma.Text = Convert.ToString(comando.ExecuteScalar());

            comando.CommandText = "SELECT nome FROM tbAluno WHERE codAluno = @codAluno;";
            lblNome.Text = Convert.ToString(comando.ExecuteScalar());

            comando.CommandText = "SELECT codAlunoTurma FROM tbAluno_Turma WHERE cod_Aluno = @codAluno AND cod_Turma = @codTurma;";
            int codAlunoTurma = Convert.ToInt32(comando.ExecuteScalar());

            conexao.Close();

            string query = "SELECT codPropina AS 'Código', dataPagamento AS 'Data', quantMeses AS 'Quantidade de meses', " +
                           "valor AS 'Valor pago' FROM tbPropina WHERE cod_AlunoTurma = @codAlunoTurma;";

            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexao);
            adaptador.SelectCommand.Parameters.Add("@codAlunoTurma", MySqlDbType.Int32).Value = codAlunoTurma;
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            dgvPropina.DataSource = tabela;

            dgvPropina.Columns[0].Width = 75;
        }

        private void btnVerMais_Click(object sender, EventArgs e)
        {
            if (dgvPropina.Rows.Count == 0)
            {
                principal.Aviso("Não existem dados registados. Impossível conluir esta operação.");
                return;
            }
            int codPropina = Convert.ToInt32(dgvPropina.CurrentRow.Cells[0].Value);
            principal.AbrirFormulario(new frmPropinas(painel,codAluno,codTurma,codPropina), painel);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmAdicionarPropina(painel, codAluno, codTurma), painel);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnVerMais_Click(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPropina.Rows.Count == 0) {
                principal.Aviso("Não existem dados registados. Impossível concluir esta operação.");
                return;
            }

            if (!principal.Confirmacao("A propina será apagado permanentemente. Deseja continuar?", "APGAR PROPINA"))
                return;

            int codPropina = Convert.ToInt32(dgvPropina.CurrentRow.Cells[0].Value);
            conexao.Open();
            MySqlCommand comando = new MySqlCommand("DELETE FROM tbPropina WHERE codPropina = @codPropina", conexao);
            comando.Parameters.Add("@codPropina", MySqlDbType.Int32).Value = codPropina;
            comando.ExecuteNonQuery();
            conexao.Close();
            principal.Aviso("Dados eliminados com sucesso!");
        }
        private void pesquisar()
        {
            string miniQuery ="";
            int numero = 0;

            if (int.TryParse(txtPesquisar.Text, out numero))
                miniQuery = $"WHERE codPropina = {txtPesquisar.Text}";

            string query = "SELECT codPropina AS 'Código', dataPagamento AS 'Data', quantMeses AS 'Quantidade de meses', " +
                            $"valor AS 'Valor pago' FROM tbPropina {miniQuery};";

            dgvPropina.DataSource = dbAuxiliar.ApresentarResultados(query);
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                pesquisar();

        }

        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            if (!click)
            {
                txtPesquisar.Text = "";
                click = true;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmAluno(painel, codAluno), painel);
        }
    }
}
