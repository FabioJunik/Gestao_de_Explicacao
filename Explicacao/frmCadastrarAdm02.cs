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
    public partial class frmCadastrarAdm02 : Form
    {

        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        principal principal = new principal();
        string[] dados;
        MySqlConnection conexao;
        MySqlCommand comando;
        string[] dadosEditar;
        public frmCadastrarAdm02(string[] dados, string[] dadosEditar)
        {
            InitializeComponent();
            conexao = dbAuxiliar.buscarConexao();
            this.dados = dados;
            this.dadosEditar = dadosEditar;
            txtDataLimite.Text = dadosEditar[3];
            txtMulta.Text = dadosEditar[4];

            if (dadosEditar != null)
                btnCriar.Text = "Editar";
        }
        public frmCadastrarAdm02(string[] dados)
        {
            InitializeComponent();
            this.dados = dados;
        }

        private void CadastarAdmExplicacao() {
            conexao.Open();

            comando = new MySqlCommand("INSERT INTO tbAdiministrador(nome, password) VALUES(@nome, @password);", conexao);
            comando.Parameters.Add("@nome", MySqlDbType.String).Value = dados[0];
            comando.Parameters.Add("@password", MySqlDbType.String).Value = dados[1];
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            comando.CommandText = "SELECT MAX(codAdm) FROM tbAdiministrador;";
            int codAdm = Convert.ToInt32(comando.ExecuteScalar());

            comando.CommandText = "INSERT INTO tbExplicacao(nome, cod_Adm) VALUES(@nome, @cod_Adm);";
            comando.Parameters.Add("@nome", MySqlDbType.String).Value = dados[2];
            comando.Parameters.Add("@cod_Adm", MySqlDbType.Int32).Value = codAdm;
            comando.ExecuteNonQuery();

            comando.Dispose();
            conexao.Close();
        }

        private void EditarAdmExplicacao() {
            conexao.Open();

            if (dadosEditar[0] != dados[0]) {
                comando = new MySqlCommand("UPDATE tbAdiministrador SET nome = @nome WHERE codAdm = @codAdm", conexao);
                comando.Parameters.Add("@nome", MySqlDbType.String).Value = dados[0];
                comando.Parameters.Add("@codAdm", MySqlDbType.Int32).Value = int.Parse(dadosEditar[5]);
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            if (dadosEditar[1] != dados[1]) {
                comando = new MySqlCommand("UPDATE tbAdiministrador SET password = @password WHERE codAdm = @codAdm", conexao);
                comando.Parameters.Add("@password", MySqlDbType.String).Value = dados[1];
                comando.Parameters.Add("@codAdm", MySqlDbType.Int32).Value = int.Parse(dadosEditar[5]);
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            if (dadosEditar[2] != dados[2]) {
                comando = new MySqlCommand("UPDATE tbExplicacao SET nome = @nome WHERE cod_Adm = @codAdm", conexao);
                comando.Parameters.Add("@nome", MySqlDbType.String).Value = dados[2];
                comando.Parameters.Add("@codAdm", MySqlDbType.Int32).Value = int.Parse(dadosEditar[5]);
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            if (dadosEditar[3] != txtDataLimite.Text) {
                comando = new MySqlCommand("UPDATE tbNormaPagamento SET dataLimite = @dataLimite WHERE cod_Explicacao = @codExplicacao", conexao);
                comando.Parameters.Add("@dataLimite", MySqlDbType.String).Value = txtDataLimite.Text;
                comando.Parameters.Add("@codExplicacao", MySqlDbType.Int32).Value = int.Parse(dadosEditar[6]);
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            if (dadosEditar[4] != txtMulta.Text) {
                comando = new MySqlCommand("UPDATE tbNormaPagamento SET multa = @multa WHERE cod_Explicacao = @codExplicacao", conexao);
                comando.Parameters.Add("@multa", MySqlDbType.String).Value = txtMulta.Text;
                comando.Parameters.Add("@codExplicacao", MySqlDbType.Int32).Value = int.Parse(dadosEditar[6]);
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            conexao.Close();
        }

        private void frmCriar_Click(object sender, EventArgs e)
        {
            if (btnCriar.Text != "Editar")
            {
                try
                {
                    CadastarAdmExplicacao();

                    conexao.Open();

                    comando = new MySqlCommand("SELECT MAX(codExplicacao) FROM tbExplicacao;", conexao);
                    int codExplicacao = Convert.ToInt32(comando.ExecuteScalar());

                    comando.CommandText = "INSERT INTO tbNormaPagamento(dataLimite, multa, cod_Explicacao) VALUES(@dataLimite, @multa, @cod_Explicacao);";
                    comando.Parameters.Add("@dataLimite", MySqlDbType.Int32).Value = Convert.ToInt32(txtDataLimite.Text);
                    comando.Parameters.Add("@multa", MySqlDbType.Double).Value = Convert.ToDouble(txtMulta.Text);
                    comando.Parameters.Add("@cod_Explicacao", MySqlDbType.Int32).Value = codExplicacao;
                    comando.ExecuteNonQuery();

                    comando.Dispose();
                    conexao.Close();
                }
                catch
                {
                    conexao.Open();

                    comando = new MySqlCommand("SELECT MAX(codExplicacao) FROM tbExplicacao;", conexao);
                    int codExplicacao = Convert.ToInt32(comando.ExecuteScalar());
                    comando.Parameters.Add("@cod_Explicacao", MySqlDbType.Int32).Value = codExplicacao;
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                    conexao.Close();
                }

                principal.Aviso("Dados inseridos com sucesso!");
            }
            else {
                EditarAdmExplicacao();
                principal.Aviso("Dados editados com sucesso");
            }

            this.Close();
        }

        private void txtMulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            principal.ApenasNumero(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
