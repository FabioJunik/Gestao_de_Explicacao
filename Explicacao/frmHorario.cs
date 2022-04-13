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
    public partial class frmHorario : Form
    {
        principal principal = new principal();
        Panel painel;
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        MySqlConnection conexao;
        MySqlCommand comando;

        string query;
        bool click;

        public frmHorario(Panel pnl)
        {
            InitializeComponent();
            painel = pnl;
            conexao = dbAuxiliar.buscarConexao();
        }

        private void frmHorario_Load(object sender, EventArgs e)
        {
            mostrarDados();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmPainelControle(painel), painel);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string dia = "";
            int familia;
            conexao.Open();

            comando = new MySqlCommand("SELECT MAX(familia) FROM tbHorario", conexao);
            familia = Convert.ToInt32(comando.ExecuteScalar());


            comando.CommandText = "INSERT INTO tbhorario VALUES(null, @diaSemana, @horaInicio, @horaFim)";

            foreach (Control controle in this.Controls) 
                if (controle is Guna.UI2.WinForms.Guna2CheckBox) 
                    if (((Guna.UI2.WinForms.Guna2CheckBox)(controle)).Checked)
                    {
                        dia = principal.RetornarDiaSemana(controle.Text).ToString();
                        
                        comando.Parameters.Clear();
                        comando.Parameters.Add("@diaSemana", MySqlDbType.String).Value = dia;
                        comando.Parameters.Add("@horaInicio", MySqlDbType.String).Value = dtpHoraInicio.Text;
                        comando.Parameters.Add("@horaFim", MySqlDbType.String).Value = dtpHoraFim.Text;
                        comando.ExecuteNonQuery();
                    }

            comando.Dispose();
            conexao.Close();

            principal.LimparCampos(this.Controls);
            mostrarDados();
            principal.Aviso("Dados inseridos com sucesso!");
        }

        private void btnAdicionarTurma_Click(object sender, EventArgs e)
        {
            int codHorario = Convert.ToInt32(dgvHorarios.CurrentRow.Cells[0].Value);
            frmHorarioTurma frm = new frmHorarioTurma(codHorario);
            frm.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvHorarios.Rows.Count == 0) {
                principal.Aviso("Não existem dados registados. Impossível concluir esta operação.");
                return;
            }

            if (!principal.Confirmacao("O horário será apagado permanentemente. Deseja continuar?", "APGAR HORÁRIO"))
                return;

            int codHorario = Convert.ToInt32(dgvHorarios.CurrentRow.Cells[0].Value);
            conexao.Open();
            comando = new MySqlCommand("DELETE FROM tbHorario WHERE codHorario = @codHorario", conexao);
            comando.Parameters.Add("@codHorario", MySqlDbType.Int32).Value = codHorario;
            comando.ExecuteNonQuery();
            comando.Dispose();
            conexao.Close();
            
            mostrarDados();
            principal.Aviso("Dados eliminado com sucesso!");
        }

        private void mostrarDados()
        {
            query = "SELECT codHorario AS 'Código', diaSemana AS 'Dias da Semana', " +
                           "horaInicio AS 'Inicio', horaFim AS 'Fim' FROM tbHorario;";
            dgvHorarios.DataSource = dbAuxiliar.ApresentarResultados(query);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) pesquisar();
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
            if (txtPesquisar.Text == "") return;

            int valor = int.Parse(txtPesquisar.Text);
            string miniQuery = $"WHERE codHorario = {valor} Or diaSemana = {valor}";

            query = "SELECT codHorario AS 'Código', diaSemana AS 'Dias da Semana', " +
                    $"horaInicio AS 'Inicio', horaFim AS 'Fim' FROM tbHorario {miniQuery};";
            dgvHorarios.DataSource = dbAuxiliar.ApresentarResultados(query);
        }
    }
}
