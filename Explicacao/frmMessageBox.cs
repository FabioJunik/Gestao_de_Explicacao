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
    public partial class frmMessageBox : Form
    {
        public frmMessageBox(string msg, string titulo, bool aviso = false)
        {
            InitializeComponent();
            lblTitulo.Text = titulo;
            lblMsg.Text = msg;

            if (aviso)
            {
                btnCancelar.Enabled = false;
                btnCancelar.Visible = false;
            }
        }
        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public bool retorno = false;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            retorno = false;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            retorno = true;
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2VSeparator2_Click(object sender, EventArgs e)
        {

        }
    }
}
