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

namespace Explicacao
{
    public partial class frmEntrar : Form
    {
        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        string palavraPasse = "";
        public bool permissao = false;

        public frmEntrar()
        {
            InitializeComponent();
        }

        private void frmEntrar_Load(object sender, EventArgs e)
        {
            MySqlConnection conexao = dbAuxiliar.buscarConexao();
            conexao.Open();
            MySqlCommand comando = new MySqlCommand("SELECT password FROM tbAdiministrador WHERE codAdm = @codAdm;", conexao);
            comando.Parameters.Add("@codAdm", MySqlDbType.Int32).Value = dbAuxiliar.RetornarCodigoAdiministradorCorrente();
            palavraPasse = Convert.ToString(comando.ExecuteScalar());
            conexao.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (palavraPasse == txtPalavraPasse.Text)
            {
                permissao = true;
                this.Close();
            }
            else
                principal.Aviso("Palavra passe incorrecta.");
        }

        private void ckbVer_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckbVer.Checked)
                txtPalavraPasse.isPassword = true;
            else
                txtPalavraPasse.isPassword = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
