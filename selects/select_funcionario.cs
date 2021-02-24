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

namespace conexão
{
    public partial class select_funcionario : Form
    {
        public String x;
        MySqlConnection conexão = new MySqlConnection("server=localhost;port=3306;User Id=root;database=acr_2v; password=");
        public select_funcionario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            
            conexão.Open();
            MySqlCommand select_cliente = new MySqlCommand("select Nome, Id, Salario,Função,IdFuncionario, rua,numero,estado,cidade from funcionario where cpf =?", conexão);
            select_cliente.Parameters.Clear();
            select_cliente.Parameters.Add("@cpf", MySqlDbType.VarChar, 12).Value = cpf.Text;
            select_cliente.CommandType = CommandType.Text;
            /*codigo para ler os dados do banco criar uma variavel mysqlreader e 
             atribuir o codigo ao objeto mais o codigo de execução*/
            MySqlDataReader ler;
            ler = select_cliente.ExecuteReader();
            ler.Read();
            nome.Text = ler.GetString(0);
            id_func.Text = ler.GetString(1);
            salario.Text = ler.GetString(2);
            funçao.Text = ler.GetString(3);
            rua.Text = ler.GetString(5);
            numero.Text = ler.GetString(6);
            estado.Text = ler.GetString(7);
            cidade.Text = ler.GetString(8);
             id_chefe.Text = ler.GetString(4);
                x = id_func.Text;
                conexão.Close();
            }
            catch(Exception a)
            {
                MessageBox.Show("ERRO:"+a);
            }
}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                conexão.Open();
                MySqlCommand deletar = new MySqlCommand("delete from funcionario where id= ?", conexão);
                deletar.Parameters.Clear();
                deletar.Parameters.Add("@idfuncionario", MySqlDbType.Int16).Value = x;
                deletar.CommandType = CommandType.Text;
                deletar.ExecuteNonQuery();
                MessageBox.Show("Funcionario deletado!!!");
                conexão.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO:" + a);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                conexão.Open();
                MySqlCommand update = new MySqlCommand("update funcionario set nome= ?,salario= ?,idfuncionario=?, rua=?, estado=?,Numero=?,cidade=?,função=? where Id = ?;", conexão);
                update.Parameters.Clear();
                update.Parameters.Add("@nome", MySqlDbType.VarChar, 40).Value = nome.Text;
                update.Parameters.Add("@salario", MySqlDbType.Double).Value = salario.Text;
                update.Parameters.Add("@Idfuncionario", MySqlDbType.Int16).Value = id_chefe.Text;
                update.Parameters.Add("@rua", MySqlDbType.VarChar, 100).Value = rua.Text;
                update.Parameters.Add("@estado", MySqlDbType.VarChar, 20).Value = estado.Text;
                update.Parameters.Add("@Numero", MySqlDbType.VarChar,5).Value = numero.Text;
                update.Parameters.Add("@cidade", MySqlDbType.VarChar, 20).Value = cidade.Text;
                update.Parameters.Add("@função", MySqlDbType.VarChar, 20).Value = funçao.Text;
                update.Parameters.Add("@id", MySqlDbType.Int16).Value = x;
               
                update.CommandType = CommandType.Text;
                update.ExecuteNonQuery();
                MessageBox.Show("Dados Atualizados");
                conexão.Close();




            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO" + a);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            data_funcionario janela = new data_funcionario();
            janela.ShowDialog();
        }

        private void select_funcionario_Load(object sender, EventArgs e)
        {

        }
    }
}
