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
            conexao.Open();
            MySqlCommand comando = new MySqlCommand("INSERT INTO tbFalta(dataFalta, cod_Turma, cod_Aluno) VALUES(@dataFalta, @cod_Turma, @cod_Aluno);", conexao);
            comando.Parameters.Add("@dataFalta", MySqlDbType.String).Value = dtpDataFalta.Value.ToString("yyyy-MM-dd");
            comando.Parameters.Add("@cod_Turma", MySqlDbType.Int32).Value = int.Parse(cmbCodTurma.Text);
            comando.Parameters.Add("@cod_Aluno", MySqlDbType.Int32).Value = int.Parse(cmbCodAluno.Text);
            comando.ExecuteNonQuery();
            conexao.Close();

            principal.Aviso("Dados inseridos com sucesso!");
            principal.LimparCampos(this.Controls);
        }

        private void frmAdicionarFalta_Load(object sender, EventArgs e)
        {

            conexao.Open();
            MySqlCommand comando = new MySqlCommand("SELECT codAluno FROM tbAluno;", conexao);
            var cods = comando.ExecuteReader();

            while (cods.Read())
            {
                cmbCodAluno.Items.Add(cods.GetValue(0));
            }

            cods.Close();
            comando.CommandText = "SELECT codTurma FROM tbTurma;";
            cods = comando.ExecuteReader();

            while (cods.Read())
            {
                cmbCodTurma.Items.Add(cods.GetValue(0));
            }

            cods.Close();
            conexao.Close();
        }

    }
}
