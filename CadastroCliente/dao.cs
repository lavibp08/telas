using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//Importar os elementos do MySql

namespace CadastroCliente
{

    internal class dao
    {
        public MySqlConnection conexao;//Amazenar os parâmetros de configuração com o BD

        public dao()
        {
            this.conexao = new MySqlConnection("server=localhost;Database=cadastroCliente;Uid=root;password=");
            try
            {
                this.conexao.Open();//Abrir a conexao com o Banco
            }
            catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//fim do construtor

        public string Cadastrar(long cpf, string nome, string telefone, string endereco)
        {
            string inserir = $"insert into cliente(codigo, cpf, nome, telefone, endereco)" +
                             $"values('','{cpf}','{nome}','{telefone}','{endereco}')";

            //Executar no banco
            MySqlCommand sql = new MySqlCommand(inserir, this.conexao);
            string resultado = sql.ExecuteNonQuery() + " Cadastro!";
            return resultado;
        }//fim do método cadastrar
    }//fim da classe
}//fim do projeto
