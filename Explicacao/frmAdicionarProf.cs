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
    public partial class frmAdicionarProf : Form
    {
        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        MySqlConnection conexao;
        Panel painel;
        public frmAdicionarProf(Panel pnl)
        {
            InitializeComponent();
            painel = pnl;
            conexao = dbAuxiliar.buscarConexao();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string sexo = "";
            string[] telefone;

            if (txtNome.Text == "" || txtTelefone.Text == "" || txtMunicipio.Text == "" || txtBairro.Text == "")
            {
                principal.Aviso("Porfavor preencha todos os campos marcados com *.");
                return;
            }

            sexo = rdFemenino.Checked ? "F" : "M";

            telefone = txtTelefone.Text.Split('/');
            
            try
            {
                if (dbAuxiliar.VerificarRedundanciaEmail(txtEmail.Text))
                    return;

                conexao.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO tbProfessor(nome, sexo, email, dataNasc) VALUES(@nome, @sexo, @email, @dataNasc);", conexao);
                comando.Parameters.Add("@nome", MySqlDbType.String).Value = txtNome.Text;
                comando.Parameters.Add("@sexo", MySqlDbType.String).Value = sexo;
                comando.Parameters.Add("@email", MySqlDbType.String).Value = txtEmail.Text;
                comando.Parameters.Add("@dataNasc", MySqlDbType.String).Value = dtpDataNasc.Value.ToString("yyyy-MM-dd");
                comando.ExecuteNonQuery();

                comando.CommandText = "SELECT MAX(codProf) FROM tbProfessor;";
                int codProf = Convert.ToInt32(comando.ExecuteScalar());
                conexao.Close();

                dbAuxiliar.AdicionarContacto(telefone[0], codProf, 0);

                if (telefone.Length > 1) 
                    dbAuxiliar.AdicionarContacto(telefone[1], codProf, 0);

                dbAuxiliar.AdicionarEndereco(txtMunicipio.Text, txtBairro.Text, txtRua.Text, codProf, 0);

                principal.LimparCampos(this.Controls);
                principal.Aviso("Dados inseridos com sucesso");
            }
            catch(Exception ex) {
                principal.Aviso("ERRO: " + ex.Message, "AVISO");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerProfs(painel), painel);
        }
        
    }
}
