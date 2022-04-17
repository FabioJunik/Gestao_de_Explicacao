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
    public partial class frmEditarNota : Form
    {
        Panel painel;
        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        MySqlConnection conexao;
        MySqlCommand comando;

        int codNota;
        int codAluno;
        int codTurma;

        public frmEditarNota(int codNota, int codAluno, int codTurma, Panel painel)
        {
            InitializeComponent();

            this.codNota = codNota;
            this.codAluno = codAluno;
            this.codTurma = codTurma;
            this.painel = painel;

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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            principal.AbrirFormulario(new frmVerNota(painel, codAluno, codTurma), painel);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string query = "UPDATE tbNota SET " +
                            "prova = @prova, nota = @nota " +
                            $"WHERE codNota = {codNota};";

            conexao.Open();
            comando = new MySqlCommand(query, conexao);
            comando.Parameters.Add("@prova", MySqlDbType.String).Value = txtProva.Text;
            comando.Parameters.Add("@nota", MySqlDbType.String).Value = txtNota.Text;

            comando.ExecuteNonQuery();
            conexao.Close();

            this.Close();
            principal.Aviso("Nota actualizada com sucesso !");
            principal.AbrirFormulario(new frmVerNota(painel, codAluno, codTurma), painel);
        }

        private void frmEditarNota_Load(object sender, EventArgs e)
        {
            mostrarDados();
        }

        private void mostrarDados()
        {
            string query = $"SELECT prova FROM tbNota WHERE codNota = {codNota}";

            conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, conexao);
            txtProva.Text = comando.ExecuteScalar().ToString();
            
            comando.CommandText = $"SELECT nota FROM tbNota WHERE codNota = {codNota}";
            txtNota.Text = comando.ExecuteScalar().ToString();

            conexao.Close();
        }
    }
}
