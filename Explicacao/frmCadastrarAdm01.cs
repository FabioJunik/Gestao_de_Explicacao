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
    public partial class frmCadastrarAdm01 : Form
    {
        principal principal = new principal();
        Panel painel;
        string[] dadosEditar = null;
        public frmCadastrarAdm01(Panel pnl, string[] dadosEditar)
        {
            InitializeComponent();
            painel = pnl;
            this.dadosEditar = dadosEditar;

            txtNomeAdm.Text = dadosEditar[0];
            txtPalavraPasse.Text = dadosEditar[1];
            txtNomeExplicacao.Text = dadosEditar[2];
        }

        public frmCadastrarAdm01(Panel pnl)
        {
            InitializeComponent();
            painel = pnl;
        }
        

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (txtNomeAdm.Text == "" || txtNomeExplicacao.Text == "" || txtPalavraPasse.Text == "")
            {
                MessageBox.Show("Porfavor preencha todos os campos.");
            }
            else
            {
                string[] dados = new string[3] { txtNomeAdm.Text, txtPalavraPasse.Text, txtNomeExplicacao.Text };

                if (dadosEditar != null)
                    principal.AbrirFormulario(new frmCadastrarAdm02(dados, dadosEditar), painel);
                else
                    principal.AbrirFormulario(new frmCadastrarAdm02(dados), painel);
            }
        }

        private void ckbVer_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckbVer.Checked)
                txtPalavraPasse.isPassword = true;
            else
                txtPalavraPasse.isPassword = false;
        }

        private void txtPalavraPasse_KeyPress(object sender, KeyPressEventArgs e)
        {
            principal.LimitarCaracteres(20, txtPalavraPasse.Text.Length, e);
        }

        private void btnNomeExplicacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            principal.LimitarCaracteres(30, txtNomeExplicacao.Text.Length, e);
        }

        private void txtNomeAdm_KeyPress(object sender, KeyPressEventArgs e)
        {
            principal.LimitarCaracteres(30, txtNomeAdm.Text.Length, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
