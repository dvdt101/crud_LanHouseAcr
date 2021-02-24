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
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //testar conecxão
            
            try
            {   //passa string os dados para fazer a conecxão
                MySqlConnection objcon = new MySqlConnection();
                //abre a conecxão com o banco
                objcon.Open();
                MessageBox.Show("Banco conectado!!!");
                // fecha conecxão
                objcon.Close();
            }
            catch(Exception a)
            {
                MessageBox.Show("ERRO:"+ a);
         
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inserir_tabelas janela_inserir = new inserir_tabelas();
            janela_inserir.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            select_tabelas StabelasJ = new select_tabelas();
            StabelasJ.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            info janela = new info();
            janela.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            consultaR janela = new consultaR();
            janela.ShowDialog();
        }

        private void ligar_Click(object sender, EventArgs e)
        {
            Menus.conexão_data janela = new Menus.conexão_data();
            janela.ShowDialog();
        }
    }
}
