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
    public partial class datacliente : Form
    {
        public datacliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost;port=3306;User Id=root;database=acr_2v; password=");
                conectar.Open();
                MySqlCommand consultar = new MySqlCommand("select Idcliente, nome, numero_doc, tipo, rua, número, estado, cidade from cliente;", conectar);
                MySqlDataAdapter apt = new MySqlDataAdapter(consultar);
                DataTable tb = new DataTable();
                apt.Fill(tb);
                conectar.Close();
                data_client.DataSource = tb;
             
               
            }
            catch(Exception a)
            {
                MessageBox.Show("erro"+a);
            }
        }

        private void data_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datacliente_Load(object sender, EventArgs e)
        {

        }
    }
}
