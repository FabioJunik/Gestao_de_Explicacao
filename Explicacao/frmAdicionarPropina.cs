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
    public partial class frmAdicionarPropina : Form
    {
        Panel painel;
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        MySqlConnection conexao;
        principal principal = new principal();
        MySqlCommand comando;
        public frmAdicionarPropina(Panel pnl)
        {
            InitializeComponent();
            painel = pnl;
            conexao = dbAuxiliar.buscarConexao();
        }

        private void frmAdicionarPropina_Load(object sender, EventArgs e)
        {
            string query = "";
            string queryContagem = "";
            string[] registos;

            //query = "SELECT codAluno, nome FROM tbAluno INNER JOIN tbAluno_Turma ON codAluno = cod_Aluno;";
            query = "SELECT codAluno, nome FROM tbAluno;";
            queryContagem = "SELECT COUNT(*) FROM tbAluno;";
            registos = principal.ConcaternarMatriz(dbAuxiliar.RetornarRegistosSelecao(query, queryContagem, 2));
            cmbAlunos.Items.AddRange(registos);

            if (cmbAlunos.Items.Count == 0) {
                principal.Aviso("Não existema lunos registados. Impossível concluir esta operação.");
                return;
            }

            cmbAlunos.Text = cmbAlunos.Items[0].ToString();

            query = "SELECT codTurma, nome FROM tbTurma;";
            queryContagem = "SELECT COUNT(*) FROM tbTurma;";
            registos = principal.ConcaternarMatriz(dbAuxiliar.RetornarRegistosSelecao(query, queryContagem, 2));
            cmbTurmas.Items.AddRange(registos);
            cmbTurmas.Text = cmbTurmas.Items[0].ToString();

            mostrar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerPropinas(painel), painel);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int codAlunoTurma = 0;
            int codAluno = int.Parse(cmbAlunos.Text.Substring(0, cmbAlunos.Text.IndexOf(" ")));
            int codTurma = int.Parse(cmbTurmas.Text.Substring(0, cmbTurmas.Text.IndexOf(" ")));
            string dataPagamento = DateTime.Now.ToString("yyyy-MM-dd");
            
            try
            {
                conexao.Open();
                comando = new MySqlCommand("SELECT codAlunoTurma FROM tbAluno_Turma " +
                                            "WHERE cod_Aluno = @codAluno AND cod_Turma = @codTurma", conexao);
                comando.Parameters.Add("@codAluno", MySqlDbType.Int32).Value = codAluno;
                comando.Parameters.Add("@codTurma", MySqlDbType.Int32).Value = codTurma;
                codAlunoTurma = Convert.ToInt32(comando.ExecuteScalar());

                if (codAlunoTurma == 0) {
                    principal.Aviso("A aluno selecionado não condiz com a turma.");
                    return;
                }

                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO tbPropina VALUES(NULL, @dataPagamento, @codAlunoTurma, @quantMeses, @valor);";
                comando.Parameters.Add("@dataPagamento", MySqlDbType.String).Value = dataPagamento;
                comando.Parameters.Add("@codAlunoTurma", MySqlDbType.Int32).Value = codAlunoTurma;
                comando.Parameters.Add("@quantMeses", MySqlDbType.Int32).Value = int.Parse(txtQuantMeses.Text);
                comando.Parameters.Add("@valor", MySqlDbType.Float).Value = float.Parse(txtValor.Text);
                comando.ExecuteNonQuery();

                comando.Dispose();
                conexao.Close();
                mostrar();
                principal.Aviso("Dados inseridos com sucesso!");
            }
            catch (Exception ex) {
                principal.Aviso("ERRO: " + ex.Message, "ERRO");
            }
        }

        private void txtQuantMeses_OnValueChanged(object sender, EventArgs e)
        {
            CalcularPreco();
        }

        private float CalcularPreco() {
            try
            {
                float valor;
                int quantMeses = int.Parse(txtQuantMeses.Text);
                int codTurma = int.Parse(cmbTurmas.Text.Substring(0, cmbTurmas.Text.IndexOf(" ")));

                conexao.Open();
                comando = new MySqlCommand("SELECT preco FROM tbTurma WHERE codTurma = @codTurma", conexao);
                comando.Parameters.Add("@codTurma", MySqlDbType.Int32).Value = codTurma;
                valor = (float)Convert.ToDouble(comando.ExecuteScalar());

                txtValor.Text = (valor * quantMeses).ToString();

                comando.Dispose();
                conexao.Close();

                return valor;
            }
            catch {
                return 0;
            }
        }

        private void mostrar()
        {
            string query = "SELECT codPropina AS 'Código', dataPagamento AS 'Data', quantMeses AS 'Quantidade de meses', " +
                           "valor AS 'Valor pago' FROM tbPropina;";

            dgvPropina.DataSource = dbAuxiliar.ApresentarResultados(query);

            dgvPropina.Columns[0].Width = 75;
        }

        private void cmbTurmas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPreco();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            //Não configurei porque não sei se é o mais corrector dar a possibilidade
            //de apagar um registo de pagamento
        }
    }
}
