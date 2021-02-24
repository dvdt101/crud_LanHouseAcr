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
    public partial class data_funcionario : Form
    {
        public data_funcionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexão = new MySqlConnection("server=localhost;port=3306;User Id=root;database=acr_2v; password=");
                conexão.Open();
                MySqlCommand select = new MySqlCommand("select * from funcionario", conexão);
                MySqlDataAdapter apt = new MySqlDataAdapter(select);
                DataTable tb = new DataTable();
                apt.Fill(tb);
                grid_func.DataSource = tb;
                conexão.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO" + a);
            }
        }

        private void grid_func_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_funcionario_Load(object sender, EventArgs e)
        {

        }
    }
}
