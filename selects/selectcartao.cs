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
    public partial class selectcartao : Form
    {
        MySqlConnection conexão = new MySqlConnection("server=localhost;port=3306;User Id=root;database=acr_2v; password=");
        public selectcartao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                conexão.Open();
                MySqlCommand select_cliente = new MySqlCommand("select cartão_acesso.Id, cartão_acesso.saldo from cartão_acesso where cartão_acesso.IdCliente = ?;", conexão);
                select_cliente.Parameters.Clear();
                select_cliente.Parameters.Add("idcliente", MySqlDbType.VarChar, 12).Value = idcliente.Text;
                select_cliente.CommandType = CommandType.Text;
                /*codigo para ler os dados do banco criar uma variavel mysqlreader e 
                 atribuir o codigo ao objeto mais o codigo de execução*/
                MySqlDataReader ler;
                ler = select_cliente.ExecuteReader();
                ler.Read();
                id_card.Text = ler.GetString(0);
                saldo_A.Text = ler.GetString(1);
                conexão.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO:" + a);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
               
                conexão.Open();
                MySqlCommand update = new MySqlCommand("update cartão_acesso set saldo=? where id= ?;", conexão);
                update.Parameters.Clear();

                update.Parameters.Add("@saldo", MySqlDbType.Double).Value = Convert.ToDouble(saldo.Text) + Convert.ToDouble(saldo_A.Text);
                update.Parameters.Add("@id", MySqlDbType.Int16).Value = id_card.Text;
               
                update.CommandType = CommandType.Text;
                update.ExecuteNonQuery();
                MessageBox.Show("Recargar Efetuada!");
               conexão.Close();




            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO" + a);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
               
                conexão.Open();
                MySqlCommand select_cliente = new MySqlCommand("select IdCliente from Cliente where Numero_doc = ?", conexão);
                select_cliente.Parameters.Clear();
                select_cliente.Parameters.Add("@Numero_doc", MySqlDbType.VarChar, 12).Value = found.Text;
                select_cliente.CommandType = CommandType.Text;
                /*codigo para ler os dados do banco criar uma variavel mysqlreader e 
                 atribuir o codigo ao objeto mais o codigo de execução*/
                MySqlDataReader ler;
                ler = select_cliente.ExecuteReader();
                ler.Read();
                idcliente.Text = ler.GetString(0);
                conexão.Close();

            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO:" + a);
            }
        }

        private void selectcartao_Load(object sender, EventArgs e)
        {

        }
    }
}
