using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Explicacao
{
    public class DBAuxiliar
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost; user id=root; password=''; database=dbexplicacao;");
        MySqlCommand comando;
        principal principal = new principal();
        public MySqlConnection buscarConexao()
        {
            return new MySqlConnection($"server=localhost; user id=root; password=''; database=dbExplicacao;");
        }
        public MySqlConnection buscarConexao(string baseDeDados)
        {
            return new MySqlConnection($"server=localhost; user id=root; password=''; database={baseDeDados};");
        }

        public void ExecutarNonQuery(string query)
        {
            conexao.Open();
            comando = new MySqlCommand(query, conexao);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void AdicionarContacto(string Tel, int cod, int numEntidade)
        {
            /*
                numEntidade   0 - professor; 1 - Aluno; 2 - Encarregado
            */
            try
            {
                conexao.Open();

                if (numEntidade == 0)
                {
                    comando = new MySqlCommand("INSERT INTO tbTelefone(numero, cod_Prof) VALUES(@numero, @cod_Prof)", conexao);
                    comando.Parameters.Add("@cod_Prof", MySqlDbType.Int32).Value = cod;
                }
                else if (numEntidade == 1)
                {
                    comando = new MySqlCommand("INSERT INTO tbTelefone(numero, cod_Aluno) VALUES(@numero, @cod_Aluno)", conexao);
                    comando.Parameters.Add("@cod_Aluno", MySqlDbType.Int32).Value = cod;
                }
                else
                {
                    comando = new MySqlCommand("INSERT INTO tbTelefone(numero, cod_Encarregado) VALUES(@numero, @cod_Encarregado)", conexao);
                    comando.Parameters.Add("@cod_Encarregado", MySqlDbType.Int32).Value = cod;
                }

                comando.Parameters.Add("@numero", MySqlDbType.String).Value = Tel;

                comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                principal.Aviso("ERRO: " + ex.Message, "ERRO");
            }
        }

        public void AdicionarEndereco(string municipio, string bairro, string rua, int cod, int numEntidade)
        {
            if (rua == "")
                rua = null;

            try
            {
                conexao.Open();

                if (numEntidade == 0)
                {
                    comando = new MySqlCommand("INSERT INTO tbEndereco(municipio, bairro, rua, cod_Prof) VALUES(@municipio, @bairro, @rua, @cod_Prof)", conexao);
                    comando.Parameters.Add("@cod_Prof", MySqlDbType.Int32).Value = cod;
                }
                else
                {
                    comando = new MySqlCommand("INSERT INTO tbEndereco(municipio, bairro, rua, cod_Aluno) VALUES(@municipio, @bairro, @rua, @cod_Aluno)", conexao);
                    comando.Parameters.Add("@cod_Aluno", MySqlDbType.Int32).Value = cod;
                }

                comando.Parameters.Add("@municipio", MySqlDbType.String).Value = municipio;
                comando.Parameters.Add("@bairro", MySqlDbType.String).Value = bairro;
                comando.Parameters.Add("@rua", MySqlDbType.String).Value = rua;
                comando.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception ex)
            {
                principal.Aviso("ERRO: " + ex.Message, "ERRO");
            }
        }


        public void actualizarTelefone(string telefone, int cod, int numEntidade)
        {
            string entidade;
            conexao.Open();

            if (numEntidade == 1)
                entidade = "cod_Aluno";

            else if (numEntidade == 0)
                entidade = "cod_prof";

            else
                entidade = "cod_Encarregado";

            comando = new MySqlCommand("UPDATE tbTelefone SET numero = @telefone " +
                                       $"WHERE {entidade} = @cod;", conexao);

            comando.Parameters.Add("@telefone", MySqlDbType.String).Value = telefone;
            comando.Parameters.Add("@cod", MySqlDbType.Int32).Value = cod;
            comando.ExecuteNonQuery();

            conexao.Close();

        }

        public void actualizarEndereco(int cod, int numEntidade, string municipio, string bairro, string rua)
        {
            string entidade;
            conexao.Open();

            rua = rua == "" ? null : rua;

            entidade = numEntidade == 1 ? "cod_Aluno" : "cod_prof";

            comando = new MySqlCommand("UPDATE tbEndereco SET municipio = @municipio, " +
                                       "bairro = @bairro, rua = @rua " +
                                       $"WHERE {entidade} = @cod;", conexao);
            comando.Parameters.Add("@municipio", MySqlDbType.String).Value = municipio;
            comando.Parameters.Add("@bairro", MySqlDbType.String).Value = bairro;
            comando.Parameters.Add("@rua", MySqlDbType.String).Value = rua;
            comando.Parameters.Add("@cod", MySqlDbType.Int32).Value = cod;

            comando.ExecuteNonQuery();
            comando.Dispose();
            conexao.Close();
        }

        public string buscarTelefone(int cod, int numEntidade)
        {
            string telefones = "";
            string miniQuery;
            conexao.Open();

            if (numEntidade == 2)
                miniQuery = $"cod_Aluno = {cod};";

            else if (numEntidade == 1)
                miniQuery = $"cod_prof = {cod};";

            else
                miniQuery = ($"cod_Encarregado = {cod};");

            comando = new MySqlCommand($"SELECT numero FROM tbTelefone WHERE {miniQuery}", conexao);
            var dados = comando.ExecuteReader();

            int cont = 1;
            while (dados.Read())
            {
                string tel = $"{dados.GetString(0)}";
                telefones = cont == 1 ? tel : telefones + "/" + tel;
            }

            dados.Close();
            conexao.Close();

            return telefones;
        }

        public string buscarMunicipio(int cod, int numEntidade)
        {
            string miniQuery;
            conexao.Open();

            if (numEntidade == 2)
                miniQuery = $"cod_Aluno = {cod};";

            else
                miniQuery = $"cod_prof = {cod};";


            comando = new MySqlCommand($"SELECT municipio FROM tbEndereco WHERE {miniQuery}", conexao);
            string municipio = Convert.ToString(comando.ExecuteScalar());

            conexao.Close();

            return municipio;
        }

        public string buscarRua(int cod, int numEntidade)
        {
            string miniQuery;
            conexao.Open();

            if (numEntidade == 2)
                miniQuery = $"cod_Aluno = {cod};";

            else
                miniQuery = $"cod_prof = {cod};";


            comando = new MySqlCommand($"SELECT rua FROM tbEndereco WHERE {miniQuery}", conexao);
            string rua = Convert.ToString(comando.ExecuteScalar());

            conexao.Close();

            return rua;
        }

        public string buscarBairro(int cod, int numEntidade)
        {
            string miniQuery;
            conexao.Open();

            if (numEntidade == 2)
                miniQuery = $"cod_Aluno = {cod};";

            else
                miniQuery = $"cod_prof = {cod};";


            comando = new MySqlCommand($"SELECT bairro FROM tbEndereco WHERE {miniQuery}", conexao);
            string bairro = Convert.ToString(comando.ExecuteScalar());

            conexao.Close();

            return bairro;
        }


        public bool VerificarRedundanciaEmail(string email)
        {
            bool validar = false;

            conexao.Open();
            comando = new MySqlCommand("SELECT email FROM tbProfessor", conexao);
            validar = VerificarExistenciaEmail(comando, email);

            if (validar)
            {
                conexao.Close();
                return validar;
            }

            comando.CommandText = "SELECT email FROM tbAluno";
            validar = VerificarExistenciaEmail(comando, email);

            comando.Dispose();
            conexao.Close();

            return validar;
        }

        private bool VerificarExistenciaEmail(MySqlCommand comando, string email)
        {
            var emails = comando.ExecuteReader();

            while (emails.Read())
            {
                string e_mail = emails.GetString(0);

                if (e_mail == email)
                {
                    principal.Aviso("Este email já está registrado.");
                    return true;
                }
            }
            emails.Close();
            return false;
        }

        public bool VerificarRedundanciaCampo(MySqlCommand comando, string valor, string msg) {
            var valores = comando.ExecuteReader();

            while (valores.Read()) {
                string val = valores.GetString(0);

                if (val == valor) {
                    principal.Aviso(msg);
                    return true;
                } 
            }

            valores.Close();
            return false;
        }

        public DataTable ApresentarResultados(string query) {
            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexao);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            return tabela;
        }

        public string[,] RetornarRegistosSelecao(string query, string queryContagem, int campos) {
            int index = 0;
            int quantRegistos = 0;
            string[,] registos;     

            conexao.Open();
            comando = new MySqlCommand(queryContagem, conexao);
            quantRegistos = Convert.ToInt32(comando.ExecuteScalar());
            registos = new string[quantRegistos, campos];

            comando.CommandText = query;
            var res = comando.ExecuteReader();

            while (res.Read()) {
                for (int i = 0; i < campos; i++) 
                    registos[index, i] = res.GetString(i);

                index++;
            }

            comando.Dispose();
            conexao.Close();
            return registos;
        }
        public void DefinirUsuarioPorDefeito()
        {
            conexao.Open();
            comando = new MySqlCommand("UPDATE tbConfiguracao SET codAdmCorrente = 1, solicitarPalavraPasse = 0;", conexao);
            comando.ExecuteNonQuery();
            comando.Dispose();
            conexao.Close();
        }

        public int RetornarCodigoAdiministradorCorrente()
        {
            int codAdm = 0;
            conexao.Open();
            comando = new MySqlCommand("SELECT codAdmCorrente FROM tbConfiguracao;", conexao);
            codAdm = Convert.ToInt32(comando.ExecuteScalar());
            comando.Dispose();
            conexao.Close();

            return codAdm;
        }

        public string RetornarSolocitacaoPalavraPasse()
        {
            string solicitar = "";
            conexao.Open();
            comando = new MySqlCommand("SELECT solicitarPalavraPasse FROM tbConfiguracao;", conexao);
            solicitar = Convert.ToString(comando.ExecuteScalar());
            comando.Dispose();
            conexao.Close();

            return solicitar;
        }

    }
}

