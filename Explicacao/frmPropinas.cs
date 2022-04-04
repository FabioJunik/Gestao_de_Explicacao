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
    public partial class frmPropinas : Form
    {
        principal principal = new principal();
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        Panel painel;
        int codPropina;
        public frmPropinas(Panel pnl, int codPropina)
        {
            InitializeComponent();
            painel = pnl;
            this.codPropina = codPropina;
        }

        private void frmPropinas_Load(object sender, EventArgs e)
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerPropinas(painel), painel);
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPropina.Rows.Count == 0) {
                principal.Aviso("Não existem dados registados. Impossível conluir esta operção.");
                return;
            }

            if (!principal.Confirmacao("O registo da propina será apagado permanentemente. Deseja continuar?", "APGAR PROPINA"))
                return;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
