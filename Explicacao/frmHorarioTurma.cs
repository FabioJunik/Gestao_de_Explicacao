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
    public partial class frmHorarioTurma : Form
    {
        MySqlConnection conexao;
        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        int codHorario = 0;

        public frmHorarioTurma(int codHorario)
        {
            InitializeComponent();
            conexao = dbAuxiliar.buscarConexao();
            this.codHorario = codHorario;
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
            if (cmbTurmas.Text == "")
                return;

            int codTurma = int.Parse(cmbTurmas.Text.Substring(0, cmbTurmas.Text.IndexOf(" ")));

            conexao.Open();
            MySqlCommand comando = new MySqlCommand("INSERT INTO tbHorario_turma VALUES(@cod_Horario, @cod_Turma)", conexao);
            comando.Parameters.Add("@cod_Horario", MySqlDbType.Int32).Value = codHorario;
            comando.Parameters.Add("@cod_Turma", MySqlDbType.Int32).Value = codTurma;
            comando.ExecuteNonQuery();
            conexao.Close();

            principal.Aviso("Dados inseridos com sucesso!");
        }

        private void frmHorarioTurma_Load(object sender, EventArgs e)
        {
            string query = "";
            string queryContagem = "";
            string[] registos;

            query = "SELECT codTurma, nome FROM tbTurma;";
            queryContagem = "SELECT COUNT(*) FROM tbTurma;";
            registos = principal.ConcaternarMatriz(dbAuxiliar.RetornarRegistosSelecao(query, queryContagem, 2));
            cmbTurmas.Items.AddRange(registos);
        }
    }
}
