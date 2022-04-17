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
    public partial class frmVerHorarioTurma : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        MySqlConnection conexao;
        int codTurma;
        int familia = 0;
        public frmVerHorarioTurma(int codTurma)
        {
            InitializeComponent();

            this.codTurma = codTurma;
            familia = RetornarFamilia();
            Mostrar();
        }

        private int RetornarFamilia() {
            int familia = 0;
            string query = "SELECT familia FROM tbHorario_Turma WHERE cod_Turma = @codTurma";
            conexao = dbAuxiliar.buscarConexao();
            conexao.Open();
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.Add("@codTurma", MySqlDbType.Int32).Value = codTurma;

            if (DBNull.Value.Equals(comando.ExecuteScalar()))
            {
                principal.Aviso("Nenhum horário encontrado, insira um.");
                conexao.Close();
                this.Close();
            }
            else
                familia = Convert.ToInt32(comando.ExecuteScalar());

            comando.Dispose();
            conexao.Close();
            return familia;
        }

        private void Mostrar()
        {
            string query = "SELECT h.codHorario, h.diaSemana, h.horaInicio, h.horaFim from tbHorario H " +
                           "INNER JOIN tbHorario_Turma ht ON h.familia = @familia " +
                           "INNER JOIN tbTurma ON codTurma = @codTurma;";

            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexao);
            adaptador.SelectCommand.Parameters.Add("@familia", MySqlDbType.Int32).Value = familia;
            adaptador.SelectCommand.Parameters.Add("@codTurma", MySqlDbType.Int32).Value = codTurma;
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            dgvHorarios.DataSource = tabela;

            principal.apresentarDiasSemana(dgvHorarios);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVerHoraioTurma_Load(object sender, EventArgs e)
        {

        }

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
