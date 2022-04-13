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
    public partial class frmAdicionarFalta : Form
    {
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        principal principal = new principal();
        MySqlConnection conexao;
        public frmAdicionarFalta()
        {
            InitializeComponent();
            conexao = dbAuxiliar.buscarConexao();
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int codAluno = int.Parse(cmbCodAluno.Text.Substring(0, cmbCodAluno.Text.IndexOf(" ")));
            int codTurma = int.Parse(cmbCodTurma.Text.Substring(0, cmbCodTurma.Text.IndexOf(" ")));

            conexao.Open();
            MySqlCommand comando = new MySqlCommand("SELECT cod_Turma FROM tbAluno_Turma WHERE cod_Aluno = @cod_Aluno", conexao);
            comando.Parameters.Add("@cod_Aluno", MySqlDbType.Int32).Value = codAluno;
            int cod = Convert.ToInt32(comando.ExecuteScalar());

            if (cod == 0) {
                principal.Aviso("O aluno selecionado não corresponde a turma selecionada.");
                conexao.Close();
                comando.Dispose();
                return;
            }

            comando.CommandText = "INSERT INTO tbFalta(dataFalta, cod_Turma, cod_Aluno) VALUES(@dataFalta, @cod_Turma, @cod_Aluno);";
            comando.Parameters.Add("@dataFalta", MySqlDbType.String).Value = dtpDataFalta.Value.ToString("yyyy-MM-dd");
            comando.Parameters.Add("@cod_Turma", MySqlDbType.Int32).Value = codTurma;
            comando.ExecuteNonQuery();
            conexao.Close();

            principal.Aviso("Dados inseridos com sucesso!");
            principal.LimparCampos(this.Controls);
        }

        private void frmAdicionarFalta_Load(object sender, EventArgs e)
        {
            mostrarDados();
        }

        private void mostrarDados() {
            string query = "";
            string queryContagem = "";
            string[] registos;

            query = "SELECT codAluno, nome FROM tbAluno;";
            queryContagem = "SELECT COUNT(*) FROM tbAluno;";
            registos = principal.ConcaternarMatriz(dbAuxiliar.RetornarRegistosSelecao(query, queryContagem, 2));
            cmbCodAluno.Items.Clear();
            cmbCodAluno.Items.AddRange(registos);
            cmbCodAluno.Text = cmbCodAluno.Items[0].ToString();

            query = "SELECT codTurma, nome FROM tbTurma;";
            queryContagem = "SELECT COUNT(*) FROM tbTurma;";
            registos = principal.ConcaternarMatriz(dbAuxiliar.RetornarRegistosSelecao(query, queryContagem, 2));
            cmbCodTurma.Items.Clear();
            cmbCodTurma.Items.AddRange(registos);
            cmbCodTurma.Text = cmbCodTurma.Items[0].ToString();
        }

    }
}
