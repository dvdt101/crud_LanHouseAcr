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
    public partial class inserirCartão : Form
    {
        MySqlConnection conexão = new MySqlConnection("server=localhost;port=3306;User Id=root;database=acr_2v; password=");
        public inserirCartão()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                conexão.Open();
                MySqlCommand inserir = new MySqlCommand("INSERT INTO `cartão_acesso` (Id, Saldo, IdCliente) VALUES (?, ?, ?)", conexão);
                inserir.Parameters.Add("@Id", MySqlDbType.Int16).Value = idcard.Text;
                inserir.Parameters.Add("@Saldo", MySqlDbType.Double).Value = saldo.Text;
                inserir.Parameters.Add("@Idcliente", MySqlDbType.Int16).Value = idclient.Text;
                inserir.ExecuteNonQuery();
                MessageBox.Show("Dados Inseridos com sucesso!!!");
                conexão.Close();
            }
            catch(Exception a) { MessageBox.Show("erro:"+a); }
        }

        private void inserirCartão_Load(object sender, EventArgs e)
        {

        }

        private void Procurar_Click(object sender, EventArgs e)
        {
            try
            {
               
                conexão.Open();
                MySqlCommand select_cliente = new MySqlCommand("select IdCliente from Cliente where Numero_doc = ?", conexão);
                select_cliente.Parameters.Clear();
                select_cliente.Parameters.Add("@Numero_doc", MySqlDbType.VarChar, 12).Value = foundClient.Text;
                select_cliente.CommandType = CommandType.Text;
                /*codigo para ler os dados do banco criar uma variavel mysqlreader e 
                 atribuir o codigo ao objeto mais o codigo de execução*/
                MySqlDataReader ler;
                ler = select_cliente.ExecuteReader();
                ler.Read();
                idclient.Text = ler.GetString(0);
                conexão.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO:" + a);
            }
        }
    }
}
