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
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
        }

        private void cliente_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Botão de cadastrar
            cadastrar cad = new cadastrar();
            cad.ShowDialog();//Mostrar na tela
            //fim do método cadastrar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botão de consultar
            consultar con = new consultar();
            con.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Botão de atualizar
            atualizar atu = new atualizar();
            atu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Botão de Encerrar
            encerrar enc = new encerrar();
            enc.ShowDialog();
        }
    }
}
