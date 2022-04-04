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
    public partial class frmAlunoTurma : Form
    {

        MySqlConnection conexao;
        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        int codTurma = 0;
        public frmAlunoTurma(int codTurma)
        {
            InitializeComponent();
            this.codTurma = codTurma;
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
            if (cmbAlunos.Text == "")
                return;

            bool validar;
            int codAluno = int.Parse(cmbAlunos.Text.Substring(0, cmbAlunos.Text.IndexOf(" ")));

            conexao.Open();
            MySqlCommand comando = new MySqlCommand("SELECT cod_Aluno FROM tbAluno_Turma at " +
                                                    "INNER JOIN tbTurma t ON t.codTurma = at.cod_Turma " +
                                                    "WHERE @codTurma = at.cod_Turma;", conexao);
            comando.Parameters.Add("@codTurma", MySqlDbType.Int32).Value = codTurma;
            validar = dbAuxiliar.VerificarRedundanciaCampo(comando, codAluno.ToString(), "Este aluno já foi adicionado a turma.");

            if (validar){
                conexao.Close();
                return;
            }

            comando.CommandText = "INSERT INTO tbAluno_turma VALUES(null, @codAluno, @codTurma)";
            comando.Parameters.Add("@codAluno", MySqlDbType.Int32).Value = codAluno;
            comando.ExecuteNonQuery();
            conexao.Close();

            principal.Aviso("Dados inseridos com sucesso!");
        }

        private void frmAlunoTurma_Load(object sender, EventArgs e)
        {
            string query = "";
            string queryContagem = "";
            string[] registos;

            query = "SELECT codAluno, nome FROM tbAluno;";
            queryContagem = "SELECT COUNT(*) FROM tbAluno;";
            registos = principal.ConcaternarMatriz(dbAuxiliar.RetornarRegistosSelecao(query, queryContagem, 2));
            cmbAlunos.Items.AddRange(registos);
        }
    }
}
