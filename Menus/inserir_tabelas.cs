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
    
    public partial class inserir_tabelas : Form
    {
        public inserir_tabelas()
        {
            
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clienteI insert_cliente = new clienteI();
            insert_cliente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inserir_funcionario inserirF = new inserir_funcionario();
            inserirF.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inserir_pc janelaPC = new inserir_pc();
            janelaPC.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inserir_aluguel janelaIalu = new inserir_aluguel();
            janelaIalu.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            inserirCartão cartaoJ = new inserirCartão();
            cartaoJ.ShowDialog();
        }

  

       

        private void inserir_tabelas_Load(object sender, EventArgs e)
        {

        }
    }
}
