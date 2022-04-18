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
using System.Runtime.InteropServices;


namespace Explicacao
{
    public partial class frmPropinas : Form
    {
        
        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        Panel painel;
        MySqlConnection conexao;
        MySqlCommand comando;

        int codTurma;
        int codAluno;

        int codPropina, quantMeses;
        string dataPagamento;
        float valor;
        public frmPropinas(Panel pnl, int codAluno, int codTurma, int codPropina)
        {
            InitializeComponent();
            painel = pnl;
            conexao = dbAuxiliar.buscarConexao();
            this.codPropina = codPropina;
            this.codTurma = codTurma;
            this.codAluno = codAluno;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void frmPropinas_Load(object sender, EventArgs e)
        {
            mostrarDados();
        }

        
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            conexao.Open();
            comando = new MySqlCommand("UPDATE tbPropina SET quantMeses = @quantMeses, " +
                                       "valor = @valor, dataPagamento = @datapagamento " +
                                       "WHERE codPropina = @codPropina", conexao);
            comando.Parameters.Add("@quantMeses", MySqlDbType.Int32).Value = int.Parse(txtQuantMeses.Text);
            comando.Parameters.Add("@valor", MySqlDbType.Float).Value = float.Parse(txtValor.Text);
            comando.Parameters.Add("@dataPagamento", MySqlDbType.String).Value = dtpPagamento.Value.ToString("yyyy-MM-dd");
            comando.Parameters.Add("@codPropina", MySqlDbType.Int32).Value = codPropina;
            comando.ExecuteNonQuery();

            comando.Dispose();
            conexao.Close();

            this.Close();
            principal.AbrirFormulario(new frmVerPropinas(painel, codAluno, codTurma), painel);

            principal.Aviso("Dados alterados com sucesso!");
        }

        private void txtQuantMeses_OnValueChanged(object sender, EventArgs e)
        {
            CalcularPreco();
        }

        private float CalcularPreco()
        {
            try
            {
                float valor;
                int quantMeses = int.Parse(txtQuantMeses.Text);

                conexao.Open();
                comando = new MySqlCommand("SELECT preco FROM tbTurma WHERE codTurma = @codTurma", conexao);
                comando.Parameters.Add("@codTurma", MySqlDbType.Int32).Value = codTurma;
                valor = (float)Convert.ToDouble(comando.ExecuteScalar());

                txtValor.Text = (valor * quantMeses).ToString();

                comando.Dispose();
                conexao.Close();

                return valor;
            }
            catch
            {
                return 0;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mostrarDados() {
            conexao.Open();
            comando = new MySqlCommand("SELECT * FROM tbPropina WHERE codPropina = @codPropina;", conexao);
            comando.Parameters.Add("@codPropina", MySqlDbType.Int32).Value = codPropina;
            var dados = comando.ExecuteReader();

            while (dados.Read())
            {
                quantMeses = dados.GetInt32("quantMeses");
                valor = dados.GetFloat("valor");
                dataPagamento = dados.GetDateTime("dataPagamento").ToString().Split(' ')[0];
            }

            dados.Close();
            comando.Dispose();
            conexao.Close();

            txtQuantMeses.Text = quantMeses.ToString();
            txtValor.Text = valor.ToString();
            dtpPagamento.Text = dataPagamento.ToString();
        }
    }
}
