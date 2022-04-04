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
    public partial class frmSala : Form
    {
        Panel painel;
        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        MySqlConnection conexao;
        MySqlCommand comando;
        string query;

        public frmSala(Panel pnl)
        {
            InitializeComponent();
            painel = pnl;
            conexao = dbAuxiliar.buscarConexao();
        }

        private void frmSala_Load(object sender, EventArgs e)
        {
            mostrarDados();
        }

        private void btnInseir_Click(object sender, EventArgs e)
        {
            char estado;

            if (cmbEstado.Text.StartsWith("D"))
                estado = '1';
            else
                estado = '0';

            conexao.Open();

            try
            {
                comando = new MySqlCommand("INSERT INTO tbSala values(null,@estado, @numero)", conexao);
                comando.Parameters.Add("@numero", MySqlDbType.Int16).Value = Convert.ToInt16(txtNumero.Text);
                comando.Parameters.Add("@estado", MySqlDbType.String).Value = estado;
                comando.ExecuteNonQuery();
                comando.Dispose();
                principal.LimparCampos(this.Controls);
                mostrarDados();
                principal.Aviso("Dados inseridos com sucesso");
            }
            catch(Exception ex) {
                principal.Aviso("ERRO: " + ex.Message, "ERRO");
            }
            conexao.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSala.Rows.Count == 0) {
                principal.Aviso("Não existem dados registados. Impossível concluir operação.");
                return;
            }

            if (!principal.Confirmacao("A sala será apagado permanentemente. Deseja continuar?", "APGAR SALA"))
                return;


            int codSala = Convert.ToInt32(dgvSala.CurrentRow.Cells[0].Value);

            conexao.Open();
            comando = new MySqlCommand("DELETE FROM tbSala WHERE codSala = @codSala", conexao);
            comando.Parameters.Add("@codSala", MySqlDbType.Int32).Value = codSala;
            comando.ExecuteNonQuery();
            comando.Dispose();
            conexao.Close();
           
            mostrarDados();
            principal.Aviso("Dados eliminado com sucesso");
        }

        private void mostrarDados()
        {
            query = "SELECT codSala AS 'Código da sala', estado AS 'Desponibilidade', numero AS 'Número' FROM tbSala;";
            dgvSala.DataSource = dbAuxiliar.ApresentarResultados(query);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmPainelControle(painel), painel);

        }
    }
}
