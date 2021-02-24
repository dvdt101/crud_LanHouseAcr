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
    public partial class consultaR : Form
    {
        MySqlConnection conexão = new MySqlConnection("server=localhost;port=3306;User Id=root;database=acr_2v; password=");
        public consultaR()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                conexão.Open();
                MySqlCommand consultar = new MySqlCommand("select Idcliente, nome, numero_doc, tipo, rua, número, estado, cidade from cliente;", conexão);
                MySqlDataAdapter apt = new MySqlDataAdapter(consultar);
                DataTable tb = new DataTable();
                apt.Fill(tb);
                conexão.Close();
                grid_ALL.DataSource = tb;


            }
            catch (Exception a)
            {
                MessageBox.Show("erro" + a);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                conexão.Open();
                MySqlCommand select = new MySqlCommand("select * from funcionario", conexão);
                MySqlDataAdapter apt = new MySqlDataAdapter(select);
                DataTable tb = new DataTable();
                apt.Fill(tb);
                grid_ALL.DataSource = tb;
                conexão.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO" + a);
            }
        }

        private void Computadores_Click(object sender, EventArgs e)
        {
            try
            {
               
                conexão.Open();
                MySqlCommand consultar = new MySqlCommand("select Idcomputador,Especificações as espec, Desempenho, statu as status, Descrição as description from computador;", conexão);
                MySqlDataAdapter apt = new MySqlDataAdapter(consultar);
                DataTable tb = new DataTable();
                apt.Fill(tb);
                grid_ALL.DataSource = tb;
                conexão.Close();
            }
            catch (Exception A)
            {
                MessageBox.Show("ERRO:" + A);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
               
                conexão.Open();
                MySqlCommand consultar = new MySqlCommand("select idaluguel,dataaluguel as data_aluguel, tipopagamento as tipo_pagamento, tempoalugado as tempo_alugado, valor,valordesconto as valor_desconto,idfuncionario, Idcartão as id_card from Aluguel; ", conexão);
                MySqlDataAdapter apt = new MySqlDataAdapter(consultar);
                DataTable tb = new DataTable();
                apt.Fill(tb);
                grid_ALL.DataSource = tb;
                conexão.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO" + a);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            conexão.Open();
            MySqlCommand table = new MySqlCommand("select * from cartão_acesso", conexão);
            MySqlDataAdapter apt = new MySqlDataAdapter(table);
            DataTable tb = new DataTable();
            apt.Fill(tb);
            grid_ALL.DataSource = tb;
            conexão.Close();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            conexão.Open();
            MySqlCommand select = new MySqlCommand("select * from aluguelcomputador", conexão);
            MySqlDataAdapter apt = new MySqlDataAdapter(select);
            DataTable tb = new DataTable();
            apt.Fill(tb);
            grid_ALL.DataSource = tb;
            conexão.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            conexão.Open();
            MySqlCommand table = new MySqlCommand("select * from vw_infoC;", conexão);
            MySqlDataAdapter apt = new MySqlDataAdapter(table);
            DataTable tb = new DataTable();
            apt.Fill(tb);
           grid_ALL.DataSource = tb;
            conexão.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                conexão.Open();
                MySqlCommand table = new MySqlCommand("select * from vw_select_r", conexão);
                MySqlDataAdapter apt = new MySqlDataAdapter(table);
                DataTable tb = new DataTable();
                apt.Fill(tb);
                grid_ALL.DataSource = tb;
                conexão.Close();
            }catch(Exception a)
            {
                MessageBox.Show("erro"+a);
            }
        }

        private void consultaR_Load(object sender, EventArgs e)
        {

        }
    }
}
