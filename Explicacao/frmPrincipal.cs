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
    public partial class frmPrincipal : Form
    {
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        principal principal = new principal();
        MySqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();

            if (dbAuxiliar.RetornarSolocitacaoPalavraPasse() == "1") {
                frmEntrar frm = new frmEntrar();
                frm.ShowDialog();

                if (!frm.permissao)
                    Application.Exit();
            }

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
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmPainelControle(pnlPrincipal), pnlPrincipal);
            conexao.Open();
            MySqlCommand comando = new MySqlCommand("SELECT nome FROM tbExplicacao WHERE cod_Adm = @codAdm;", conexao);
            comando.Parameters.Add("@codAdm", MySqlDbType.String).Value = dbAuxiliar.RetornarCodigoAdiministradorCorrente();
            lblNomeExplicacao.Text = Convert.ToString(comando.ExecuteScalar());
            conexao.Close();
        }

        private void btnPainelControle_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmPainelControle(pnlPrincipal), pnlPrincipal);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnAluno_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerAlunos(pnlPrincipal), pnlPrincipal);
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerTurmas(pnlPrincipal), pnlPrincipal);
        }

        private void btnProfs_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerProfs(pnlPrincipal), pnlPrincipal);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlPrincipal_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is frmPainelControle)
                pnlPrincipal.AutoScroll = true;
            else
                pnlPrincipal.AutoScroll = false;
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmConfiguracoes(pnlPrincipal), pnlPrincipal);

        }

        private void btnPropina_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerPropinas(pnlPrincipal), pnlPrincipal);
        }
    }
}
