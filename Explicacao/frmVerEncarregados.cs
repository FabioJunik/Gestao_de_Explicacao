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
    public partial class frmVerEncarregados : Form
    {
        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        MySqlConnection conexao;
        public frmVerEncarregados()
        {
            InitializeComponent();
            conexao = dbAuxiliar.buscarConexao();
        }

        private void frmVerEncarregados_Load(object sender, EventArgs e)
        {
            string query = "SELECT codEncarregado AS 'Código do Encarregado', nome AS 'Nome', sexo AS 'Sexo' FROM tbEncarregado;";
            dgvEncarregados.DataSource = dbAuxiliar.ApresentarResultados(query);
        }

        private void frmEditar_Click(object sender, EventArgs e)
        {

        }

        private void frmEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEncarregados.Rows.Count == 0) {
                principal.Aviso("Não exitem dados registados. Impossível concluir esta operação.");
                return;
            }
            if (!principal.Confirmacao("O encarregado será apagado permanentemente. Deseja continuar?", "APGAR ENCARREGADO"))
                return;

        }
    }
}
