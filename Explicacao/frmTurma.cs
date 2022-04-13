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
    public partial class frmTurma : Form
    {
        DBAuxiliar dbAuxiliar = new DBAuxiliar();
        principal principal = new principal();
        Panel painel;

        MySqlConnection conexao;
        MySqlCommand comando;

        string nome;
        int codTurma, codProf;
        int codDisciplina, codNivel, codSala;
        string maxAluno, cargaHoraria;
        string quantProva, proprina;
        string dataInicio, dataFim;

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlunosTurma.Rows.Count == 0) {
                principal.Aviso("Não existem dados registados. Impossível concluir esta operação.");
                return;
            }

            if (!principal.Confirmacao("O aluno será apagado permanentemente da turma. Deseja continuar?", "APGAR ALUNO DA TURMA"))
                return;

            int codAluno = Convert.ToInt32(dgvAlunosTurma.CurrentRow.Cells[0].Value);
            conexao.Open();
            comando = new MySqlCommand("DELETE FROM tbAluno_Turma WHERE cod_Aluno = @codAluno AND cod_Turma = @codTurma;", conexao);
            comando.Parameters.Add("@codAluno", MySqlDbType.Int32).Value = codAluno;
            comando.Parameters.Add("@codTurma", MySqlDbType.Int32).Value = codTurma;
            comando.ExecuteNonQuery();
            comando.Dispose();
            conexao.Close();

            principal.Aviso("Aluno removido com sucesso.");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            principal.AbrirFormulario(new frmVerTurmas(painel), painel);
        }

        public frmTurma(Panel pnl, int codTurma)
        {
            InitializeComponent();
            painel = pnl;
            painel = pnl;
            this.codTurma = codTurma;
            conexao = dbAuxiliar.buscarConexao();
        }

        private void frmAdiconarTurma_Load(object sender, EventArgs e)
        {
            mostrarDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            codProf = int.Parse(cmbProfessor.Text.Substring(0, cmbProfessor.Text.IndexOf(" ")));
            codSala = int.Parse(cmbSala.Text.Substring(0, cmbSala.Text.IndexOf(" ")));
            codDisciplina = int.Parse(cmbDisciplina.Text.Substring(0, cmbDisciplina.Text.IndexOf(" ")));
            codNivel = int.Parse(cmbNivel.Text.Substring(0, cmbNivel.Text.IndexOf(" ")));

            txtNome.Text = nome;
            proprina = txtPropina.Text;
            cargaHoraria = txtCargaHoraria.Text;
            maxAluno = txtQuantMaxAlunos.Text;
            quantProva = txtQuantProvas.Text;

            dataFim = dtpDataFim.Value.ToString("yyyy-MM-dd");
            dataInicio = dtpDataInicio.Value.ToString("yyyy-MM-dd");

            conexao.Open();
            MySqlCommand comando = new MySqlCommand($"UPDATE tbturma SET nome = '{nome}', preco = {proprina}, quantProvas = {quantProva}," +
                                                    $"cargaHoraria = {cargaHoraria}, dataInicio = '{dataInicio}', dataFim = '{dataFim}', cod_sala = {codSala}," +
                                                    $" numMaxAluno = {maxAluno}, cod_nivel = {codNivel},cod_disciplina = {codDisciplina}" +
                                                    $" WHERE codTurma = {codTurma};", conexao);

            comando.ExecuteNonQuery();

            comando.CommandText = $"UPDATE tbProfessor_Turma SET cod_Prof = {codProf}, cod_Turma = {codTurma}" +
                                  $" WHERE cod_Prof = {codProf} AND cod_Turma = {codTurma} ;";

            comando.ExecuteNonQuery();

            conexao.Close();

            MessageBox.Show("Dados salvos com sucesso");
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmAlunoTurma frm = new frmAlunoTurma(codTurma);
            mostrarDados();
            frm.ShowDialog();
        }
        private void mostrarDados()
        {
            string query = "";
            string queryContagem = "";
            string[] registos;

            query = "SELECT a.codAluno, a.nome FROM tbaluno a " +
                    "INNER JOIN tbaluno_turma at ON a.codAluno = at.cod_Aluno " +
                    "INNER JOIN tbturma t ON t.codTurma = at.cod_Turma " +
                    "WHERE @codTurma = at.cod_Turma;";

            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexao);
            adaptador.SelectCommand.Parameters.Add("@codTurma", MySqlDbType.Int32).Value = codTurma;
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            dgvAlunosTurma.DataSource = tabela;


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


            query = "SELECT * FROM tbTurma WHERE codTurma = @codTurma;";

            conexao.Open();
            comando = new MySqlCommand(query, conexao);
            comando.Parameters.Add("@codTurma", MySqlDbType.Int32).Value = codTurma;
            var dados = comando.ExecuteReader();

            while (dados.Read())
            {
                nome = dados.GetString("nome");
                dataInicio = dados.GetDateTime("dataInicio").ToString().Split(' ')[0];
                dataFim = dados.GetDateTime("dataFim").ToString().Split(' ')[0];
                cargaHoraria = dados.GetString("cargaHoraria");
                maxAluno = dados.GetString("numMaxAluno");
                quantProva = dados.GetString("quantProvas");
                proprina = dados.GetString("preco");
                codDisciplina = dados.GetInt32("cod_disciplina");
                codNivel = dados.GetInt32("cod_nivel");
                codSala = dados.GetInt32("cod_sala");
            }

            dados.Close();

            comando.CommandText = "SELECT cod_Prof FROM tbProfessor_Turma  WHERE cod_turma = @codTurma";
            codProf = Convert.ToInt32(comando.ExecuteScalar());

            comando.CommandText = $"SELECT nome FROM tbProfessor WHERE codProf = {codProf}";
            cmbProfessor.Text = Convert.ToString(comando.ExecuteScalar());

            comando.CommandText = $"SELECT nivel FROM tbNivel WHERE codNivel = {codNivel}";
            cmbNivel.Text = Convert.ToString(comando.ExecuteScalar());

            //comando.CommandText = $"SELECT numero FROM tbSala WHERE codSala = {codSala}";
            //cmbSala.Text = comando.ExecuteScalar().ToString();

            comando.Dispose();
            conexao.Close();

            txtNome.Text = nome;
            txtPropina.Text = proprina;
            txtCargaHoraria.Text = cargaHoraria;
            txtQuantMaxAlunos.Text = maxAluno;
            txtQuantProvas.Text = quantProva;
            dtpDataInicio.Text = dataInicio;
            dtpDataFim.Text = dataFim;

            foreach (string prof in cmbProfessor.Items) {
                if (prof.StartsWith(codProf.ToString()))
                {
                    cmbProfessor.Text = prof;
                    break;
                }
            }
            foreach (string disciplina in cmbDisciplina.Items)
            {
                if (disciplina.StartsWith(codDisciplina.ToString()))
                {
                    cmbDisciplina.Text = disciplina;
                    break;
                }
            }
            foreach (string sala in cmbSala.Items)
            {
                if (sala.StartsWith(codSala.ToString()))
                {
                    cmbSala.Text = sala;
                    break;
                }
            }
            foreach (string nivel in cmbNivel.Items)
            {
                if (nivel.StartsWith(codNivel.ToString()))
                {
                    cmbNivel.Text = nivel;
                    break;
                }
            }
        }
    }
}
