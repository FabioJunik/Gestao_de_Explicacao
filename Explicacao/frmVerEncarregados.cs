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
    public partial class frmVerEncarregados : Form
    {
        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        MySqlConnection conexao;
        MySqlCommand comando;

        bool click = false;

        public frmVerEncarregados()
        {
            InitializeComponent();
            conexao = dbAuxiliar.buscarConexao();
        }

        private void frmVerEncarregados_Load(object sender, EventArgs e)
        {
            mostrarDados();
        }

        private void frmEditar_Click(object sender, EventArgs e)
        {
            int codEncarregado = Convert.ToInt32(dgvEncarregados.CurrentRow.Cells[0].Value);
            frmEditarEncarregado formEditarEncarregado = new frmEditarEncarregado(codEncarregado);

            formEditarEncarregado.ShowDialog();
        }

        private void frmEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEncarregados.Rows.Count == 0) {
                principal.Aviso("Não exitem dados registados. Impossível concluir esta operação.");
                return;
            }
            if (!principal.Confirmacao("O encarregado será apagado permanentemente. Deseja continuar?", "APGAR ENCARREGADO"))
                return;

            int codEncarregado = Convert.ToInt32(dgvEncarregados.CurrentRow.Cells[0].Value);

            conexao.Open();
            comando = new MySqlCommand("DELETE FROM tbEncarregado WHERE codEncarregado = @codEncarregado;", conexao);
            comando.Parameters.Add("@codEncarregado", MySqlDbType.Int32).Value = codEncarregado;
            comando.ExecuteNonQuery();

            comando.CommandText = "DELETE FROM tbAluno_encarregado WHERE cod_Encarregado = @codEncarregado;";
            comando.ExecuteNonQuery();

            conexao.Close();

            mostrarDados();
            principal.Aviso("Encarregado apagada com sucesso!");

        }

        private void mostrarDados()
        {
            string query = "SELECT codEncarregado AS 'Código do Encarregado', nome AS 'Nome', sexo AS 'Sexo' FROM tbEncarregado;";
            dgvEncarregados.DataSource = dbAuxiliar.ApresentarResultados(query);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

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
                miniQuery = $"WHERE codEncarregado = {txtPesquisar.Text}";

            string query = "SELECT codEncarregado AS 'Código', nome AS 'Nome', sexo AS 'Sexo' " +
                           $"FROM tbEncarregado {miniQuery};";

            dgvEncarregados.DataSource = dbAuxiliar.ApresentarResultados(query);
        }
    }
}
