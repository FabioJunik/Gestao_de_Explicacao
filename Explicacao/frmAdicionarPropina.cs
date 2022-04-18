using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Explicacao
{
    public partial class frmAdicionarPropina : Form
    {
        Panel painel;
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        MySqlConnection conexao;
        principal principal = new principal();
        MySqlCommand comando;

        int codAluno;
        int codTurma;

        public frmAdicionarPropina(Panel pnl, int codAluno, int codTurma)
        {
            InitializeComponent();
            this.codAluno = codAluno;
            this.codTurma = codTurma;
            painel = pnl;
            conexao = dbAuxiliar.buscarConexao();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmAdicionarPropina_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int codAlunoTurma = 0;
            string dataPagamento = DateTime.Now.ToString("yyyy-MM-dd");
            
            try
            {
                conexao.Open();
                comando = new MySqlCommand("SELECT codAlunoTurma FROM tbAluno_Turma " +
                                            "WHERE cod_Aluno = @codAluno AND cod_Turma = @codTurma", conexao);
                comando.Parameters.Add("@codAluno", MySqlDbType.Int32).Value = codAluno;
                comando.Parameters.Add("@codTurma", MySqlDbType.Int32).Value = codTurma;
                codAlunoTurma = Convert.ToInt32(comando.ExecuteScalar());

                if (codAlunoTurma == 0) {
                    principal.Aviso("A aluno selecionado não condiz com a turma.");
                    return;
                }

                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO tbPropina VALUES(NULL, @dataPagamento, @codAlunoTurma, @quantMeses, @valor);";
                comando.Parameters.Add("@dataPagamento", MySqlDbType.String).Value = dataPagamento;
                comando.Parameters.Add("@codAlunoTurma", MySqlDbType.Int32).Value = codAlunoTurma;
                comando.Parameters.Add("@quantMeses", MySqlDbType.Int32).Value = int.Parse(txtQuantMeses.Text);
                comando.Parameters.Add("@valor", MySqlDbType.Float).Value = float.Parse(txtValor.Text);
                comando.ExecuteNonQuery();

                comando.Dispose();
                conexao.Close();

                this.Close();
                principal.AbrirFormulario(new frmVerPropinas(painel,codAluno,codTurma),painel);

                principal.Aviso("Dados inseridos com sucesso!");
            }
            catch (Exception ex) {
                principal.Aviso("ERRO: " + ex.Message, "ERRO");
            }
        }

        private void txtQuantMeses_OnValueChanged(object sender, EventArgs e)
        {
            CalcularPreco();
        }

        private float CalcularPreco() {
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
            catch {
                return 0;
            }
        }

        private void cmbTurmas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPreco();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            //Não configurei porque não sei se é o mais corrector dar a possibilidade
            //de apagar um registo de pagamento
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
