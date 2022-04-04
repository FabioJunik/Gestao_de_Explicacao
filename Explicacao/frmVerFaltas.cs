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
    public partial class frmVerFaltas : Form
    {
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        principal principal = new principal();
        MySqlConnection conexao;
        public frmVerFaltas()
        {
            InitializeComponent();
            conexao = dbAuxiliar.buscarConexao();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmAdicionarFalta frm = new frmAdicionarFalta();
            frm.ShowDialog();
        }

        private void frmVerFaltas_Load(object sender, EventArgs e)
        {
            string query = "SELECT codFalta AS 'Código da Falta', dataFalta AS 'Data da falta', cod_Turma AS 'Código da Turma', " +
                           "cod_Aluno AS 'Código do aluno' FROM tbFalta;";
            dgvFalta.DataSource = dbAuxiliar.ApresentarResultados(query);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvFalta.Rows.Count == 0) {
                principal.Aviso("Não existem dados registados. Impossível concluir esta operação.");
                return;
            }
            if (!principal.Confirmacao("A falta será apagado permanentemente. Deseja continuar?", "APGAR FALTA"))
                return;

        }
    }
}
