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

namespace conexão.Menus
{
    public partial class conexão_data : Form
    {
        

        public conexão_data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userL = user.Text;
            String passwordL = password.Text;
            String databaseL = database.Text;
            String portL = port.Text;
            String serverL = server.Text;

            try
            {
                Conecxão c1 = new Conecxão(serverL, portL, userL, databaseL, passwordL);
                MySqlConnection conexão = new MySqlConnection(c1.getconexao());
                conexão.Open();
            }
            catch(MySqlException err)
            {
                MessageBox.Show("ERRO:"+err);
            }
        }
    }
}
