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

namespace Explicacao
{
    public partial class frmCadastrarAdm : Form
    {
        principal principal = new principal();
        int ocorrencia = 0;
        string[] dadosEditar = null;
        public frmCadastrarAdm(string[] dadosEditar)
        {
            InitializeComponent();
            this.dadosEditar = dadosEditar;
        }
        public frmCadastrarAdm()
        {
            InitializeComponent();
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
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmLogin00_Load(object sender, EventArgs e)
        {
            if (dadosEditar != null)
                principal.AbrirFormulario(new frmCadastrarAdm01(pnlCadastro, dadosEditar), pnlCadastro);
            else
                principal.AbrirFormulario(new frmCadastrarAdm01(pnlCadastro), pnlCadastro);
        }

        private void pnlLogin_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (++ocorrencia == 1)
                this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
