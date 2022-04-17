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
    public partial class frmAdicionarTurma : Form
    {
        principal principal = new principal();
        Panel painelPrincipal;
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        MySqlConnection conexao;
        public frmAdicionarTurma(Panel panel)
        {
            InitializeComponent();
            painelPrincipal = panel;
            conexao = dbAuxiliar.buscarConexao();
        }

        private void frmTurma_Load(object sender, EventArgs e)
        {
            string query = "";
            string queryContagem = "";
            string[] registos;

            query = "SELECT codProf, nome FROM tbProfessor;";
            queryContagem = "SELECT COUNT(*) FROM tbProfessor;";
            registos = principal.ConcaternarMatriz(dbAuxiliar.RetornarRegistosSelecao(query, queryContagem, 2));
            cmbProfessor.Items.AddRange(registos);

            query = "SELECT codDisciplina, nome FROM tbDisciplina;";
            queryContagem = "SELECT COUNT(*) FROM tbDisciplina;";
            registos = principal.ConcaternarMatriz(dbAuxiliar.RetornarRegistosSelecao(query, queryContagem, 2));
            cmbDisciplina.Items.AddRange(registos);

            query = "SELECT codNivel, nivel FROM tbNivel;";
            queryContagem = "SELECT COUNT(*) FROM tbNivel;";
            registos = principal.ConcaternarMatriz(dbAuxiliar.RetornarRegistosSelecao(query, queryContagem, 2));
            cmbNivel.Items.AddRange(registos);

            query = "SELECT codSala, numero FROM tbSala;";
            queryContagem = "SELECT COUNT(*) FROM tbSala;";
            registos = principal.ConcaternarMatriz(dbAuxiliar.RetornarRegistosSelecao(query, queryContagem, 2));
            cmbSala.Items.AddRange(registos);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerTurmas(painelPrincipal), painelPrincipal);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int codProf;
            int codTurma;
            int codSala = int.Parse(cmbSala.Text.Substring(0, cmbSala.Text.IndexOf(" ")));
            int codDisciplina = int.Parse(cmbDisciplina.Text.Substring(0, cmbDisciplina.Text.IndexOf(" ")));
            int codNivel = int.Parse(cmbNivel.Text.Substring(0, cmbNivel.Text.IndexOf(" ")));

            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO tbturma values(null, @nome, @preco, @quantProva, @cargaHoraria, " +
                                                         "@dataInicio, @dataFim, @maxAluno, @nivel, @sala, @disciplina)", conexao);

                comando.Parameters.Add("@nome", MySqlDbType.String).Value = txtNome.Text;
                comando.Parameters.Add("@preco", MySqlDbType.Float).Value = float.Parse(txtPropina.Text);
                comando.Parameters.Add("@sala", MySqlDbType.Int16).Value = codSala;
                comando.Parameters.Add("@nivel", MySqlDbType.Int16).Value = codNivel;
                comando.Parameters.Add("@maxAluno", MySqlDbType.Int16).Value = Convert.ToInt16(txtQuantMaxAlunos.Text);
                comando.Parameters.Add("@disciplina", MySqlDbType.Int16).Value = codDisciplina;
                comando.Parameters.Add("@quantProva", MySqlDbType.Int16).Value = Convert.ToInt16(txtQuantProvas.Text);
                comando.Parameters.Add("@cargaHoraria", MySqlDbType.Int16).Value = Convert.ToInt16(txtCargaHoraria.Text);
                comando.Parameters.Add("@dataFim", MySqlDbType.String).Value = dtpDataFim.Value.ToString("yyyy-MM-dd");
                comando.Parameters.Add("@dataInicio", MySqlDbType.String).Value = dtpDataInicio.Value.ToString("yyyy-MM-dd");
                comando.ExecuteNonQuery();

                codProf = int.Parse(cmbProfessor.Text.Substring(0, cmbProfessor.Text.IndexOf(" ")));
                comando.CommandText = "SELECT MAX(codTurma) FROM tbTurma;";
                codTurma = Convert.ToInt32(comando.ExecuteScalar());

                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO tbProfessor_Turma VALUES(@cod_Prof, @cod_Turma);";
                comando.Parameters.Add("@cod_Prof", MySqlDbType.Int32).Value = codProf;
                comando.Parameters.Add("@cod_Turma", MySqlDbType.Int32).Value = codTurma;
                comando.ExecuteNonQuery();

                conexao.Close();
                principal.LimparCampos(this.Controls);
                principal.Aviso("Dados inserirdos com sucesso!");
            }
            catch (Exception ex)
            {
                principal.Aviso("ERRO: " + ex.Message, "ERRO");
            }
        }
    }
}
