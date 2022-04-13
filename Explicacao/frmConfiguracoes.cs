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
    public partial class frmConfiguracoes : Form
    {
        Panel painel;
        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        MySqlConnection conexao;
        MySqlCommand comando;
        public frmConfiguracoes(Panel pnl)
        {
            InitializeComponent();
            painel = pnl;
            conexao = dbAuxiliar.buscarConexao();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrarAdm frm = new frmCadastrarAdm();
            frm.ShowDialog();
            mostrarDados();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmPainelControle(painel), painel);
        }

        private void frmConfiguracoes_Load(object sender, EventArgs e)
        {
            mostrarDados();
        }

        private void mostrarDados() {
            string query = "";
            string queryContagem = "";
            string[] registos;

            if (dbAuxiliar.RetornarSolocitacaoPalavraPasse() == "1")
                ckbSolicitarPP.Checked = true;

            query = "SELECT codAdm, nome FROM tbAdiministrador;";
            queryContagem = "SELECT COUNT(*) FROM tbAdiministrador;";
            registos = principal.ConcaternarMatriz(dbAuxiliar.RetornarRegistosSelecao(query, queryContagem, 2));
            cmbAdms.Items.Clear();
            cmbAdms.Items.AddRange(registos);

            foreach (object adm in cmbAdms.Items) 
                if (adm.ToString().StartsWith(dbAuxiliar.RetornarCodigoAdiministradorCorrente().ToString() + " "))
                    cmbAdms.Text = adm.ToString();

            cmbAdmEliminar.Items.Clear();
            cmbAdmEliminar.Items.AddRange(registos);
            cmbAdmEliminar.Items.RemoveAt(0);
            cmbAdmEliminar.Items.Add("");
        }
        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int codAdm = int.Parse(cmbAdms.Text.Substring(0, cmbAdms.Text.IndexOf(" ")));
            string solicitar = "";

            if (ckbSolicitarPP.Checked)
                solicitar = "1";
            else
                solicitar = "0";

            if (dbAuxiliar.RetornarSolocitacaoPalavraPasse() != solicitar) {
                if (codAdm != 1)
                {
                    conexao.Open();
                    comando = new MySqlCommand("UPDATE tbConfiguracao SET solicitarPalavraPasse = @solicitar;", conexao);
                    comando.Parameters.Add("@solicitar", MySqlDbType.String).Value = solicitar;
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                    conexao.Close();
                }
            }

            if (dbAuxiliar.RetornarCodigoAdiministradorCorrente() != codAdm) {
                conexao.Open();
                comando = new MySqlCommand("UPDATE tbConfiguracao SET codAdmCorrente = @codAdm", conexao);
                comando.Parameters.Add("@codAdm", MySqlDbType.Int32).Value = codAdm;
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();
            }

            principal.Aviso("Dados editados com sucesso!");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbAdmEliminar.Text != "") {
                if (principal.Confirmacao("Deseja mesmo apgar este usuário?", "APGAR ADIMINISTRADOR")) {

                    int codAdm = int.Parse(cmbAdmEliminar.Text.Substring(0, cmbAdmEliminar.Text.IndexOf(" ")));
                    int codExplicacao;

                    conexao.Open();
                    comando = new MySqlCommand("DELETE FROM tbAdiministrador WHERE codAdm = @codAdm;", conexao);
                    comando.Parameters.Add("@codAdm", MySqlDbType.Int32).Value = codAdm;
                    comando.ExecuteNonQuery();
                    
                    comando.CommandText = "SELECT codExplicacao FROM tbExplicacao WHERE cod_Adm = @codAdm";
                    codExplicacao = Convert.ToInt32(comando.ExecuteScalar());

                    comando.CommandText = "DELETE FROM tbExplicacao WHERE cod_Adm = @codAdm";
                    comando.ExecuteNonQuery();

                    comando.Parameters.Clear();
                    comando.CommandText = "DELETE FROM tbNormaPagamento WHERE cod_Explicacao = @codExplicacao";
                    comando.Parameters.Add("@codExplicacao", MySqlDbType.Int32).Value = codExplicacao;
                    comando.ExecuteNonQuery();

                    comando.Dispose();
                    conexao.Close();

                    principal.Aviso("Adiministrador apagado com sucesso!");

                    if (codAdm == dbAuxiliar.RetornarCodigoAdiministradorCorrente()) {
                        dbAuxiliar.DefinirUsuarioPorDefeito();
                    }

                    mostrarDados();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dbAuxiliar.RetornarCodigoAdiministradorCorrente() == 1)
                return;

            int codAdm = dbAuxiliar.RetornarCodigoAdiministradorCorrente();
            string[] dadosEditar = new string[7];
            int codExplicacao;

            conexao.Open();
            comando = new MySqlCommand("SELECT nome, password FROM tbAdiministrador WHERE codAdm = @codAdm;", conexao);
            comando.Parameters.Add("@codAdm", MySqlDbType.Int32).Value = codAdm;
            var dados = comando.ExecuteReader();

            while (dados.Read()) {
                dadosEditar[0] = dados.GetString(0);
                dadosEditar[1] = dados.GetString(1);
            }
            dados.Close();

            comando.CommandText = "SELECT nome FROM tbExplicacao WHERE cod_Adm = @codAdm;";
            dadosEditar[2] = Convert.ToString(comando.ExecuteScalar());

            comando.CommandText = "SELECT codExplicacao FROM tbExplicacao WHERE cod_Adm = @codAdm;";
            codExplicacao = Convert.ToInt32(comando.ExecuteScalar());

            comando.Parameters.Clear();
            comando.CommandText = "SELECT dataLimite, multa FROM tbNormaPagamento WHERE cod_Explicacao = @codExplicacao;";
            comando.Parameters.Add("@codExplicacao", MySqlDbType.Int32).Value = codExplicacao;
            dados = comando.ExecuteReader();

            while (dados.Read()) {
                dadosEditar[3] = dados.GetString(0);
                dadosEditar[4] = dados.GetString(1);
            }

            dados.Close();
            comando.Dispose();
            comando.Dispose();
            conexao.Close();

            dadosEditar[5] = codAdm.ToString();
            dadosEditar[6] = codExplicacao.ToString();
            frmCadastrarAdm frm = new frmCadastrarAdm(dadosEditar);
            frm.ShowDialog();
        }
    }
}
