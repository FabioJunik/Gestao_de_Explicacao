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
    public partial class frmAdicionarAluno : Form
    {
        Panel painel;
        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        validacoes validacoes = new validacoes();

        MySqlConnection conexao;
        public frmAdicionarAluno(Panel pnl)
        {
            InitializeComponent();
            painel = pnl;
            conexao = dbAuxiliar.buscarConexao();
        }

        private void frmVerAluno_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerAlunos(painel), painel);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string sexo = "";
            string[] telefone;

            if (!ValidarCampos()) return;

            sexo = rdFemenino.Checked ? "F" : "M";

            telefone = txtTelefone.Text.Split('/');

            if (dbAuxiliar.VerificarRedundanciaEmail(txtEmail.Text))
                return;

            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO tbAluno(nome, dataNasc, sexo, email) VALUES(@nome, @dataNasc, @sexo, @email);", conexao);
                comando.Parameters.Add("@nome", MySqlDbType.String).Value = txtNome.Text;
                comando.Parameters.Add("@sexo", MySqlDbType.String).Value = sexo;
                comando.Parameters.Add("@email", MySqlDbType.String).Value = txtEmail.Text;
                comando.Parameters.Add("@dataNasc", MySqlDbType.String).Value = dtpDataNasc.Value.ToString("yyyy-MM-dd");
                comando.ExecuteNonQuery();

                comando.CommandText = "SELECT MAX(codAluno) FROM tbAluno";
                int codAluno = Convert.ToInt32(comando.ExecuteScalar());

                conexao.Close();

                dbAuxiliar.AdicionarContacto(telefone[0], codAluno, 1);

                if (telefone.Length > 1)
                    dbAuxiliar.AdicionarContacto(telefone[1], codAluno, 1);

                dbAuxiliar.AdicionarEndereco(txtMunicipio.Text, txtBairro.Text, txtRua.Text, codAluno, 1);
                principal.LimparCampos(this.Controls);
                principal.Aviso("Dados inseridos com sucesso!");
            }
            catch(Exception ex) {
                principal.Aviso("ERRO: " + ex.Message, "ERRO");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerAlunos(painel), painel);
        }

        private bool ValidarCampos()
        {
            bool valido = false;

            if (txtNome.Text == "" || txtTelefone.Text == "" || txtMunicipio.Text == "" || txtBairro.Text == "") 
            {
                principal.Aviso("Porfavor preencha todos os campos marcados com *.");
            }
            else if(!validacoes.NomeValido(txtNome.Text))
                principal.Aviso("Nome invalido \nVerifique se esta bem escrito");

            else if (!validacoes.NumeroAngola(txtTelefone.Text))
            {
                principal.Aviso("Número invalido \nVerifique se esta bem escrito");
            }
            else
            {
                valido = true;
            }

            return valido;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            principal.ApenasTexto(e);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            string telefone = txtTelefone.Text;

            validacoes.ValidarTelefone(e, telefone);

        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            if(nome != "")
                txtNome.Text = principal.OrganizarNome(nome);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtEmail.Text = txtEmail.Text.ToLower();
        }
    }
}
