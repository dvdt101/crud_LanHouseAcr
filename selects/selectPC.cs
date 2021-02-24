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
    public partial class selectPC : Form
    {
        MySqlConnection conexão = new MySqlConnection("server=localhost;port=3306;User Id=root;database=acr_2v; password=");
        public selectPC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                conexão.Open();
                MySqlCommand select = new MySqlCommand("select especificações, desempenho, statu, descrição from computador where idcomputador = ?;", conexão);
                select.Parameters.Clear();
                select.Parameters.Add("idcliente", MySqlDbType.VarChar, 12).Value = id.Text ;
                select.CommandType = CommandType.Text;
                /*codigo para ler os dados do banco criar uma variavel mysqlreader e 
                 atribuir o codigo ao objeto mais o codigo de execução*/
                MySqlDataReader ler;
                ler = select.ExecuteReader();
                ler.Read();
                espec.Text = ler.GetString(0);
                desempenho.Text = ler.GetString(1);
                status.Text = ler.GetString(2);
                descrição.Text = ler.GetString(3);
                conexão.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO:" + a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               
                conexão.Open();
                MySqlCommand deletar = new MySqlCommand("delete from computador where idcomputador = ?", conexão);
                deletar.Parameters.Clear();
                deletar.Parameters.Add("@idCliente", MySqlDbType.Int16).Value = id.Text;
                deletar.CommandType = CommandType.Text;
                deletar.ExecuteNonQuery();
                MessageBox.Show("Computador deletado!!!");
            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO:" + a);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                conexão.Open();
                MySqlCommand update = new MySqlCommand("update computador set desempenho= ?,descrição=?, statu=?, especificações=? where Idcomputador = ?;", conexão);
                update.Parameters.Clear();
                update.Parameters.Add("@desempenho", MySqlDbType.Int16).Value = desempenho.Text;
                update.Parameters.Add("@descrição", MySqlDbType.VarChar,100).Value = descrição.Text;
                update.Parameters.Add("@statu", MySqlDbType.Int16).Value = status.Text;
                update.Parameters.Add("@especificações", MySqlDbType.VarChar, 150).Value = espec.Text;
                update.Parameters.Add("@computador", MySqlDbType.Int16).Value = id.Text;
                update.CommandType = CommandType.Text;
                update.ExecuteNonQuery();
                MessageBox.Show("Dados Atualizados");
                conexão.Close();




            }
            catch (Exception a)
            {
                MessageBox.Show("ERRO" + a);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            data_pc janela = new data_pc();
            janela.ShowDialog();
        }

        private void selectPC_Load(object sender, EventArgs e)
        {

        }
    }
    }

