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
using MySql.Data;

namespace conexão
{
    public partial class consultarCliente : Form
    {
        public String x = null;
        MySqlConnection conexão = new MySqlConnection("server=localhost;port=3306;User Id=root;database=acr_2v; password=");
        public consultarCliente()
        {
            InitializeComponent();
        }

        private void consultarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
               conexão.Open();
                MySqlCommand select_cliente = new MySqlCommand("select Nome, IdCliente, tipo, rua,número,estado,cidade from Cliente where Numero_doc = ?", conexão);
                select_cliente.Parameters.Clear();
                select_cliente.Parameters.Add("@Numero_doc", MySqlDbType.VarChar,12).Value = num_doc.Text;
                select_cliente.CommandType = CommandType.Text;
                /*codigo para ler os dados do banco criar uma variavel mysqlreader e 
                 atribuir o codigo ao objeto mais o codigo de execução*/
                MySqlDataReader ler;
                ler = select_cliente.ExecuteReader();
                ler.Read();
                nome.Text = ler.GetString(0);
                idcliente.Text = ler.GetString(1);
                tipo.Text = ler.GetString(2);
                rua.Text = ler.GetString(3);
                num_end.Text = ler.GetString(4);
                estado.Text = ler.GetString(5);
                cidade.Text = ler.GetString(6);
                conexão.Close();
                //solução para impedir que o usuario altere a id
                x = idcliente.Text;
            }catch(Exception a)
            {
                MessageBox.Show("ERRO:"+a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               
                conexão.Open();
                MySqlCommand deletar = new MySqlCommand("delete from cliente where idcliente = ?", conexão);
                deletar.Parameters.Clear();
                deletar.Parameters.Add("@idCliente", MySqlDbType.Int16).Value = x;
                deletar.CommandType = CommandType.Text;
                deletar.ExecuteNonQuery();
                MessageBox.Show("Cliente deletado!!!");
                conexão.Close();
            }
            catch(Exception a)
            {
                MessageBox.Show("ERRO:"+a);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
               
                conexão.Open();
                MySqlCommand update = new MySqlCommand("update cliente set nome= ?,tipo=?, rua=?, estado=?,Número=?,cidade=? where Idcliente = ?;", conexão);
                update.Parameters.Clear();
                update.Parameters.Add("@nome", MySqlDbType.VarChar, 40).Value = nome.Text;
                update.Parameters.Add("@tipo", MySqlDbType.Int16).Value = tipo.Text;
                update.Parameters.Add("@rua", MySqlDbType.VarChar, 100).Value = rua.Text;
                update.Parameters.Add("@estado", MySqlDbType.VarChar, 20).Value = estado.Text;
                update.Parameters.Add("@Número", MySqlDbType.VarChar,5).Value = num_end.Text;
                update.Parameters.Add("@cidade", MySqlDbType.VarChar, 20).Value = cidade.Text;
                update.Parameters.Add("@Idcliente", MySqlDbType.Int16).Value = x;
                update.CommandType = CommandType.Text;
                update.ExecuteNonQuery();
                MessageBox.Show("Dados Atualizados");
                conexão.Close();


                

            }catch(Exception a)
            {
                MessageBox.Show("ERRO"+ a);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            datacliente janela = new datacliente();
            janela.ShowDialog();
        }
    }
}
