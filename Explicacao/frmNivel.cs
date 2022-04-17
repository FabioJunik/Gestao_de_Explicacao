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
    public partial class frmNivel : Form
    {
        Panel painel;
        MySqlConnection conexao;
        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        MySqlCommand comando;

        string query;
        bool click;

        int codNivel;

        public frmNivel(Panel pnl)
        {
            InitializeComponent();
            painel = pnl;
            conexao = dbAuxiliar.buscarConexao();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            conexao.Open();

            comando = new MySqlCommand("INSERT INTO tbnivel values(null,@nivel)", conexao);
            comando.Parameters.Add("@nivel", MySqlDbType.String).Value = txtNovoNivel.Text;
            comando.ExecuteNonQuery();
            comando.Dispose();
            conexao.Close();
            principal.LimparCampos(this.Controls);
            principal.Aviso("Dados inseridos com suecesso!");
        }

        private void btnNivel_Click(object sender, EventArgs e)
        {
            
            string query = "UPDATE tbNivel SET nivel = @nivel " +
                           "WHERE codNivel = @codNivel";
            conexao.Open();
            comando = new MySqlCommand(query, conexao);
            comando.Parameters.Add("@nivel", MySqlDbType.String).Value = txtNivel.Text;
            comando.Parameters.Add("@codNivel", MySqlDbType.Int32).Value = codNivel;
            comando.ExecuteNonQuery();
            conexao.Close();
            mostrarDados();

            principal.Aviso("Dados salvos com sucesso");
        }

        private void mostrarDados()
        {
            string query = "SELECT codNivel AS 'Código', nivel AS 'Nivel' FROM tbNivel;";
            dgvNivel.DataSource = dbAuxiliar.ApresentarResultados(query);
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvNivel.Rows.Count == 0) {
                principal.Aviso("Não exitem dados registados. Impossível concluir esta operação.");
            }

            if (!principal.Confirmacao("O nível será apagado permanentemente. Deseja continuar?", "APGAR NÍVEL"))
                return;

            int codNivel = Convert.ToInt32(dgvNivel.CurrentRow.Cells[0].Value);
            query = $"DELETE FROM tbNivel WHERE codNivel = {codNivel}";

            dbAuxiliar.ExecutarNonQuery(query);

            mostrarDados();
            principal.Aviso("Dados eliminado com sucesso!");
        }

        private void frmNivel_Load(object sender, EventArgs e)
        {
            mostrarDados();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmPainelControle(painel), painel);
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
            string miniQuery = $"WHERE nivel LIKE '%{txtPesquisar.Text}%'";
            int numero = 0;

            if (int.TryParse(txtPesquisar.Text, out numero))
                miniQuery = $"WHERE codNivel = {txtPesquisar.Text}";

            string query = $"SELECT codNivel AS 'Código', nivel AS 'Nivel' FROM tbNivel {miniQuery};";
            dgvNivel.DataSource = dbAuxiliar.ApresentarResultados(query);

            dgvNivel.DataSource = dbAuxiliar.ApresentarResultados(query);
        }

        private void dgvNivel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codNivel = Convert.ToInt32(dgvNivel.CurrentRow.Cells[0].Value);
            txtNivel.Text = dgvNivel.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
