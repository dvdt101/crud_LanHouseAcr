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
    public partial class inserir_pc : Form
    {
        public inserir_pc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection inserir_pc = new MySqlConnection("server=localhost;port=3306;User Id=root;database=acr_2v; password=");
                inserir_pc.Open();
                MySqlCommand inserirP = new MySqlCommand("INSERT INTO computador (Idcomputador, Especificações, Desempenho, Statu,Descrição) VALUES (?, ?, ?, ?, ?)", inserir_pc);
                inserirP.Parameters.Add("@Idcomputador", MySqlDbType.Int16).Value = id_pc.Text;
                inserirP.Parameters.Add("@Especificações", MySqlDbType.VarChar, 120).Value = espec.Text;
                inserirP.Parameters.Add("@Desempenho", MySqlDbType.Int16).Value = desempenho.Text;
                inserirP.Parameters.Add("@Statu",MySqlDbType.Int16).Value = status.Text;
                inserirP.Parameters.Add("@Descrição", MySqlDbType.VarChar, 100).Value = descricao.Text;
                inserirP.ExecuteNonQuery();
                inserir_pc.Close();
                MessageBox.Show("computador inserido");

            }
            catch
            {
                MessageBox.Show("erro");
            }
        }

        private void inserir_pc_Load(object sender, EventArgs e)
        {

        }
    }
}
