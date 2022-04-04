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
    public partial class frmAdicionarEncarregado : Form
    {
        MySqlConnection conexao;
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        principal principal = new principal();
        int codAluno;
        public frmAdicionarEncarregado(int codAluno)
        {
            InitializeComponent();
            this.codAluno = codAluno;
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

        private void frmAdicionarEncarregado_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int codEncarregado;
            string sexo;
            string[] telefone;

            if (txtNome.Text == "" || txtTelefone.Text == "")
            {
                principal.Aviso("Porfavor preencha todos os campos marcados com *.");
                return;
            }


            if (rdFemenino.Checked)
                sexo = "F";
            else
                sexo = "M";

            telefone = txtTelefone.Text.Split('/');

            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO tbEncarregado(nome, sexo) VALUES(@nome, @sexo);", conexao);
                comando.Parameters.Add("@nome", MySqlDbType.String).Value = txtNome.Text;
                comando.Parameters.Add("@sexo", MySqlDbType.String).Value = sexo;
                comando.ExecuteNonQuery();

                comando.CommandText = "SELECT MAX(codEncarregado) FROM tbEncarregado;";
                codEncarregado = Convert.ToInt32(comando.ExecuteScalar());

                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO tbAluno_Encarregado(cod_Aluno, cod_Encarregado) VALUES(@codAluno, @codEncarregado)";
                comando.Parameters.Add("@codAluno", MySqlDbType.Int32).Value = codAluno;
                comando.Parameters.Add("@codEncarregado", MySqlDbType.Int32).Value = codEncarregado;
                comando.ExecuteNonQuery();

                conexao.Close();

                dbAuxiliar.AdicionarContacto(telefone[0], codEncarregado, 2);

                if (telefone.Length > 1)
                    dbAuxiliar.AdicionarContacto(telefone[1], codEncarregado, 2);
                
                principal.LimparCampos(this.Controls);
                principal.Aviso("Dados inseridos com sucesso.");
                this.Close();
            }
            catch(Exception ex) {
                principal.Aviso("ERRO " + ex.Message, "ERRO");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
