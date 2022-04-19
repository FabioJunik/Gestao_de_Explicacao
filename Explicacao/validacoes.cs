using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Explicacao
{
    class validacoes:principal
    {
        protected readonly string[] inicialNumeroAo = new string[5] { "91", "92", "93", "94", "99" };

        public void ValidarTelefone(KeyPressEventArgs e, string telefone)
        {
            if (telefone.Length > 18 && e.KeyChar != 8)
                e.Handled = true;

            if (telefone.Length == 9)
            {
                if(e.KeyChar != '/' && e.KeyChar != 8)
                    e.Handled = true;
            }
            else
                ApenasNumero(e);
        }

        public bool NumeroAngola(string num)
        {
            string[] telefones;

            telefones = num.Split('/');

            if(telefones.Length > 1)
            {
                string inicialNumero = telefones[0].Substring(0, 2);
                bool validoNum1 = inicialNumeroAo.Contains(inicialNumero) && telefones[0].Length == 9;

                if (telefones[1].Length < 2)
                    return false;

                inicialNumero = telefones[1].Substring(0, 2);
                bool validoNum2 = inicialNumeroAo.Contains(inicialNumero) && telefones[1].Length == 9;

                return validoNum1 && validoNum2;
            }


            if (num.Length < 2)
                return false;


            return inicialNumeroAo.Contains(num.Substring(0, 2)) && num.Length == 9;
        }

        public bool ValidarEmail(string email)
        {
            int indexDOT = email.IndexOf('.');
            int indexA = email.IndexOf('@');

            if (indexA < 0 || indexDOT < 0 || indexDOT == email.Length - 1)
                return false;

            return indexA < indexDOT && indexA > 0 && indexA + 1 != indexDOT;
        }

        public bool NomeValido(string nome)
        {
            bool retorno = true;

            nome.Trim();

            string[] subNomes = nome.Split(' ');

            if (subNomes.Length == 1)
                retorno = false;

            for (int i = 0; i < subNomes.Length; i++)
            {
                if (subNomes[0].Length < 2)
                    retorno = false;

                if (subNomes[i].Length <= 1)
                    retorno = false;
            }

            return retorno;
        }
    }
}
