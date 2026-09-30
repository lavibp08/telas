using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class cadastrar : Form
    {
        dao bd;//chamando a classe dao
        public cadastrar()
        {
            InitializeComponent();
            bd = new dao();//Instanciando a variável BD e Abrindo a conexão com o banco
        }//fim do construtor

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Coletando os dados da tela para enviar ao banco de dados
                long cpf = Convert.ToInt64(RemoverFormatacaoCPF(maskedTextBox1.Text));
                string nome = textBox2.Text;
                string telefone = maskedTextBox2.Text;
                string endereco = textBox4.Text;

                //Cadastro no banco
                MessageBox.Show(bd.Cadastrar(cpf, nome, telefone, endereco));

                //Limpar a tela
                LimparTela();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//fim do botão cadastrar

        public void LimparTela()
        {
            maskedTextBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox2.Text = "";
            textBox4.Text = "";
        }//fim do método

        public string RemoverFormatacaoCPF(string cpf)
        {
            //Replace - método que substitue um caractere por outro
            string cpfAlterado = cpf.Replace(",", "");//troca a "," por "vazio".
            cpfAlterado = cpfAlterado.Replace("-", "");

            return cpfAlterado;
        }//fim remover

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }//fim codigo

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim telefone

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim CPF

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//fim endereco

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim nome

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim voltar

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }//fim da classe
}//fim do projeto
