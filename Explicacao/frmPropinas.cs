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
        int codPropina;
        public frmPropinas(Panel pnl, int codPropina)
        {
            InitializeComponent();
            painel = pnl;
            this.codPropina = codPropina;
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
        }
        
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {

        }

        private void pnlBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
