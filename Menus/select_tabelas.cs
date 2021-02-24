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
    public partial class select_tabelas : Form
    {
        public select_tabelas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            consultarCliente consultar = new consultarCliente();
            consultar.ShowDialog();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            select_funcionario selectFJ = new select_funcionario();
            selectFJ.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectPC janela = new selectPC();
            janela.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectcartao janela = new selectcartao();
            janela.ShowDialog();
        }



        private void select_tabelas_Load(object sender, EventArgs e)
        {

        }
    }
}
