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
    public partial class frmVerPropinas : Form
    {
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        principal principal = new principal();
        Panel painel;
        public frmVerPropinas(Panel pnl)
        {
            InitializeComponent();
            painel = pnl;
        }

        private void frmVerPropinas_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void mostrar()
        {
            string query = "SELECT codPropina AS 'Código', dataPagamento AS 'Data', quantMeses AS 'Quantidade de meses', " +
                           "valor AS 'Valor pago' FROM tbPropina;";

            dgvPropina.DataSource = dbAuxiliar.ApresentarResultados(query);

            dgvPropina.Columns[0].Width = 75;
        }

        private void btnVerMais_Click(object sender, EventArgs e)
        {
            if (dgvPropina.Rows.Count == 0)
            {
                principal.Aviso("Não existem dados registados. Impossível conluir esta operação.");
                return;
            }
            int codPropina = Convert.ToInt32(dgvPropina.CurrentRow.Cells[0].Value);
            principal.AbrirFormulario(new frmPropinas(painel, codPropina), painel);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmAdicionarPropina(painel), painel);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnVerMais_Click(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPropina.Rows.Count == 0) {
                principal.Aviso("Não existem dados registados. Impossível concluir esta operação.");
                return;
            }

            if (!principal.Confirmacao("A propina será apagado permanentemente. Deseja continuar?", "APGAR PROPINA"))
                return;

        }
    }
}
