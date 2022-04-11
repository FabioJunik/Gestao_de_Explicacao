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
    public partial class frmEditarEncarregado : Form
    {
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        principal principal = new principal();

        MySqlConnection conexao;
        MySqlCommand comando;

        int codEncarregado;
        string nome;
        string telefone;
        string sexo;

        public frmEditarEncarregado(int codEncarregado)
        {
            InitializeComponent();
            this.codEncarregado = codEncarregado;
            conexao = dbAuxiliar.buscarConexao();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmEditarEncarregado_Load(object sender, EventArgs e)
        {
            mostrarDados();
        }

        private void mostrarDados()
        {
            conexao.Open();
            comando = new MySqlCommand("SELECT nome, numero FROM tbEncarregado " +
                                        "INNER JOIN tbTelefone ON cod_encarregado = @codEncarregado " +
                                        "WHERE codEncarregado = @codEncarregado;", conexao);

            comando.Parameters.Add("@codEncarregado", MySqlDbType.Int32).Value = codEncarregado;

            var dados = comando.ExecuteReader();

            while (dados.Read())
            {
                nome = dados.GetString("nome");
                telefone = dados.GetString("numero");
            }

            dados.Close();
            conexao.Close();

            txtNome.Text = nome;
            txtTelefone.Text = telefone;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            sexo = rdFemenino.Checked ? "F" : "M";

            conexao.Open();
           
            comando = new MySqlCommand($"UPDATE tbEncarregado SET nome = @nome, sexo = @sexo " +
                                       $"WHERE codEncarregado = @codEncarregado;",conexao);

            comando.Parameters.Add("@nome", MySqlDbType.String).Value = nome;
            comando.Parameters.Add("@sexo", MySqlDbType.String).Value = sexo;
            comando.Parameters.Add("@codEncarregado", MySqlDbType.Int32).Value = codEncarregado;

            comando.ExecuteNonQuery();

            actualizarTelefone();
            conexao.Close();

            mostrarDados();
            principal.Aviso("Dados salvos com sucesso!");
        }

        private void actualizarTelefone()
        {
            string[] telefone = txtTelefone.Text.Split('/');

            dbAuxiliar.actualizarTelefone(telefone[0], codEncarregado, 2);

            if (telefone.Length > 1)
                dbAuxiliar.actualizarTelefone(telefone[1], codEncarregado, 2);
        }

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
