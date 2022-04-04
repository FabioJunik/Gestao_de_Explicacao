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
    public partial class frmDisciplina : Form
    {
        Panel painel;
        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        MySqlConnection conexao;
        MySqlCommand comando;

        string query;
        bool click;

        public frmDisciplina(Panel pnl)
        {
            InitializeComponent();
            painel = pnl;
            conexao = dbAuxiliar.buscarConexao();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmPainelControle(painel), painel);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            bool validar;
            conexao.Open();
            comando = new MySqlCommand("SELECT nome FROM tbDisciplina", conexao);
            validar = dbAuxiliar.VerificarRedundanciaCampo(comando, txtNome.Text, "Esta disciplina já foi inserida");

            if (validar) {
                conexao.Close();
                return;
            }

            comando.CommandText = "INSERT INTO tbdisciplina values(null,@disciplina)";
            comando.Parameters.Add("@disciplina", MySqlDbType.String).Value = txtNome.Text;
            comando.ExecuteNonQuery();
            comando.Dispose();
            conexao.Close();

            principal.LimparCampos(this.Controls);
            mostrarDados();
            principal.Aviso("Dados inseridos com sucesso!");
        }

        private void frmDisciplina_Load(object sender, EventArgs e)
        {
            mostrarDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int codDisciplina = Convert.ToInt32(dgvDisciplina.CurrentRow.Cells[0].Value);
            string nome = txtDisciplina.Text;

            try {
                conexao.Open();
                comando = new MySqlCommand("UPDATE tbDisciplina SET nome = @nome " +
                                           "WHERE codDisciplina = @codDisciplina", conexao);
                comando.Parameters.Add("@nome", MySqlDbType.String).Value = nome;
                comando.Parameters.Add("@codDisciplina", MySqlDbType.String).Value = codDisciplina;
                comando.ExecuteNonQuery();
                conexao.Dispose();
                conexao.Close();
            }
            catch (Exception ex) {
                principal.Aviso("ERRO: " + ex.Message, "ERRO");
            }

            mostrarDados();
            principal.Aviso("Dados editados com sucesso!");
        }

        public void mostrarDados()
        {
            query = "SELECT codDisciplina AS 'Código do Disciplina', nome AS 'Nome' FROM tbDisciplina;";
            dgvDisciplina.DataSource = dbAuxiliar.ApresentarResultados(query);
        }

        private void dgvDisciplina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDisciplina.Text = dgvDisciplina.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvDisciplina.Rows.Count == 0) {
                principal.Aviso("Não exitem dados registados. Impossível concluir esta operação.");
                return;
            }

            if (!principal.Confirmacao("A disciplina será apagado permanentemente. Deseja continuar?", "APGAR DISCIPLINA"))
                return;

            int codDisciplina = Convert.ToInt32(dgvDisciplina.CurrentRow.Cells[0].Value);

            query = $"DELETE FROM tbDisciplina WHERE codDisciplina = {codDisciplina}";

            dbAuxiliar.ExecutarNonQuery(query);

            mostrarDados();
            principal.Aviso("Dados eliminados com sucesso!");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
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

        private void pesquisar()
        {
            string miniQuery = $"WHERE nome LIKE '%{txtPesquisar.Text}%'";
            int numero = 0;

            if (int.TryParse(txtPesquisar.Text, out numero))
                miniQuery = $"WHERE codDisciplina = {txtPesquisar.Text}";

            query = "SELECT codDisciplina AS 'Código', nome AS 'Nome'" +
                    $" FROM tbDisciplina {miniQuery};";
            dgvDisciplina.DataSource = dbAuxiliar.ApresentarResultados(query);

        }
    }
}
