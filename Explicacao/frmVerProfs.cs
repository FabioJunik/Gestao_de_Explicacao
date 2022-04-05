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
    public partial class frmVerProfs : Form
    {
        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        Panel painel;
        MySqlConnection conexao;
        int codProf;

        bool click=false;
        
        public frmVerProfs(Panel pnl)
        {
            InitializeComponent();
            painel = pnl;
            conexao = dbAuxiliar.buscarConexao();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmAdicionarProf(painel), painel);
        }

        private void btnVerMais_Click(object sender, EventArgs e)
        {
            if (dgvProfs.Rows.Count == 0)
            {
                principal.Aviso("Não exitem dados registados. Impossível concluir esta operação.");
                return;
            }

            codProf = Convert.ToInt32(dgvProfs.CurrentRow.Cells["Código"].Value);
            principal.AbrirFormulario(new frmProf(painel, codProf), painel);
        }

        private void frmVerProfs_Load(object sender, EventArgs e)
        {
            mostrarDados();
        }

        private void mostrarDados() {
            string query = "SELECT codProf AS 'Código', nome AS 'Nome', dataNasc AS 'Data de nascimento', " +
                           "sexo AS 'Sexo" +
                           "', IFNULL(email, 'SEM E-MAIL') AS 'E-mail' FROM tbProfessor;";
            dgvProfs.DataSource = dbAuxiliar.ApresentarResultados(query);

            dgvProfs.Columns[0].Width = 75;
            dgvProfs.Columns["Sexo"].Width = 75;
            dgvProfs.Columns["Nome"].Width = 250;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProfs.Rows.Count == 0) {
                principal.Aviso("Não exitem dados registados. Impossível concluir esta operação.");
                return;
            }
            if (!principal.Confirmacao("O professor será apagado permanentemente. Deseja continuar?", "APGAR PROFESSOR"))
                return;


            codProf = Convert.ToInt32(dgvProfs.CurrentRow.Cells[0].Value);

            conexao.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "DELETE FROM tbProfessor WHERE codProf = @codProf";
            comando.Parameters.Add("@codProf", MySqlDbType.Int32).Value = codProf;
            comando.ExecuteNonQuery();

            comando.CommandText = "DELETE FROM tbProfessor_Turma WHERE cod_prof = @codProf";
            comando.ExecuteNonQuery();

            comando.CommandText = "DELETE FROM tbEndereco WHERE cod_prof = @codProf";
            comando.ExecuteNonQuery();

            comando.CommandText = "DELETE FROM tbTelefone WHERE cod_prof = @codProf";
            comando.ExecuteNonQuery();

            comando.Dispose();
            conexao.Close();
            principal.Aviso("Dados eliminados com sucesso!");
            mostrarDados();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnVerMais_Click(sender, e);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void pesquisar()
        {
            string miniQuery = $"WHERE nome LIKE '%{txtPesquisar.Text}%'";
            int numero = 0;

            if (int.TryParse(txtPesquisar.Text, out numero))
                miniQuery = $"WHERE codProf = {txtPesquisar.Text}";

            string query = "SELECT codProf AS 'Código', nome AS 'Nome', dataNasc AS 'Data de nascimento', " +
                           "sexo AS 'Sexo', IFNULL(email, 'SEM E-MAIL') AS 'E-mail' FROM tbProfessor " +
                           $"{miniQuery};";

            dgvProfs.DataSource = dbAuxiliar.ApresentarResultados(query);
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

        private void dgvProfs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
