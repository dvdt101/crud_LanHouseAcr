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
    public partial class data_pc : Form
    {
        public data_pc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection com = new MySqlConnection("server=localhost;port=3306;User Id=root;database=acr_2v; password=");
                com.Open();
                MySqlCommand consultar = new MySqlCommand("select * from computador", com);
                MySqlDataAdapter apt = new MySqlDataAdapter(consultar);
                DataTable tb = new DataTable();
                apt.Fill(tb);
                grid_pc.DataSource = tb;
                com.Close();
            }
            catch(Exception A)
            {
                MessageBox.Show("ERRO:"+ A);
            }

        }

        private void grid_pc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_pc_Load(object sender, EventArgs e)
        {

        }
    }
}
