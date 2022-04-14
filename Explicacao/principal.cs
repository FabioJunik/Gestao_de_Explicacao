using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Explicacao
{
    public class principal
    {
        Form frmAtivo;

        public void AbrirFormulario(Form formulario, Panel painel)
        {
            if (frmAtivo != null)
                frmAtivo.Close();

            frmAtivo = formulario;

            formulario.TopLevel = false;
            painel.Controls.Add(formulario);
            formulario.BringToFront();
            formulario.Show();

        }

        public string Criptografar(string str)
        {
            /*Este método tornou-se ineficiente desde o momento
            em que precisei descriptografar*/
            string resultado = "";

            MD5 criador = MD5.Create();
            byte[] inputs = Encoding.ASCII.GetBytes(str);
            byte[] hash = criador.ComputeHash(inputs);

            foreach (byte bt in hash)
            {
                resultado += bt.ToString();
            }

            return resultado;
        }       

        public void ApenasNumero(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true; 
        }

        public void ApenasNumero(KeyPressEventArgs e, bool validar)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',')
                e.Handled = true;
        }

        public void ApenasNumero(KeyPressEventArgs e, char separador='/')
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '/')
                e.Handled = true;
        }

        public void ApenasTexto(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }


        public void LimparCampos(Control.ControlCollection controls)
        {
            foreach (Control controle in controls)
            {
                if (controle is TextBox)
                    ((TextBox)(controle)).Text = "";

                if (controle is Bunifu.Framework.UI.BunifuMaterialTextbox)
                    ((Bunifu.Framework.UI.BunifuMaterialTextbox)(controle)).Text = "";

                if (controle is Guna.UI2.WinForms.Guna2CheckBox)
                    ((Guna.UI2.WinForms.Guna2CheckBox)(controle)).Checked = false;

                if (controle is Guna.UI2.WinForms.Guna2ComboBox)
                    ((Guna.UI2.WinForms.Guna2ComboBox)(controle)).Text = "";
            }
        }

        public void LimitarCaracteres(int limite, int quantCaracteres, KeyPressEventArgs e) {
            if (limite == quantCaracteres)
                e.Handled = false;
        }

        public string[] ConcaternarMatriz(string[,] matriz, string separador = " - ") {
            int index = 0;
            string[] vetor = new string[matriz.GetLength(0)];

            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++)
                    if (j < matriz.GetLength(1) - 1)
                        vetor[index] += matriz[i, j] + separador;
                    else
                        vetor[index] += matriz[i, j];
    
                index++;
            }

            return vetor;
        }

        public int RetornarDiaSemana(string dia) {
            string[] diasSemana = new string[7] { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };

            for (int i = 0; i < diasSemana.Length; i++)
                if (diasSemana[i] == dia)
                    return (i + 1);
            
            return 0;
        }

        public bool Confirmacao(string msg, string titulo) {
            frmMessageBox frm = new frmMessageBox(msg, titulo);
            frm.ShowDialog();

            if (frm.retorno)
                return true;

            return false;
        }

        public void Aviso(string msg, string titulo = "AVISO") {
            frmMessageBox frm = new frmMessageBox(msg, titulo, true);
            frm.ShowDialog();
        }

        public string[] RetornarDiasCorrespondentes(string[] dias) {
            string[] diasSemana = new string[dias.Length];
            int index = 0;

            foreach (string dia in dias) {
                switch (dia) {
                    case "1":
                        diasSemana[index] = "Domingo";
                        break;
                    case "2":
                        diasSemana[index] = "Segunda-Feira";
                        break;
                    case "3":
                        diasSemana[index] = "Terça-Feira";
                        break;
                    case "4":
                        diasSemana[index] = "Quarta-Feira";
                        break;
                    case "5":
                        diasSemana[index] = "Quinta-Feira";
                        break;
                    case "6":
                        diasSemana[index] = "Sexta-Feira";
                        break;
                    case "7":
                        diasSemana[index] = "Sábado";
                        break;
                }

                index++;
            }

            return diasSemana;
        }
        public void apresentarDiasSemana(DataGridView dgv, int pos = 1)
        {
            string[] dias = new string[dgv.Rows.Count];

            for (int i = 0; i < dias.Length; i++)
                dias[i] = dgv.Rows[i].Cells[pos].Value.ToString();

            dias = RetornarDiasCorrespondentes(dias);

            for (int i = 0; i < dias.Length; i++)
                dgv.Rows[i].Cells[pos].Value = dias[i];
        }
    }

}
