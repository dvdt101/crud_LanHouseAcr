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
   
    

    public partial class inserir_aluguel : Form
    {
        
        //VARIAVEIS
        public double x, y;//usadas para calcular e descontar valor do aluguel no cartão
        public Int16 id;//usada para salvar resultado da conversão para int
        public String id_con;//usada para receber a id do ultimo aluguel feito
        public Int16 idN;// usada para salvar id do novo aluguel
        public String comboboxselect;//usada para combobox de computador
        public Int16 comboOption;//usada para combox de computador

            MySqlConnection conexão = new MySqlConnection("server=localhost;port=3306;User Id=root;database=acr_2v; password=");

        public inserir_aluguel()
        {
            InitializeComponent();
            // itens para combobox
            pc_nivel.Items.Add(1);
            pc_nivel.Items.Add(2);
            pc_nivel.Items.Add(3);
            try
            {
                // COLOCAR NOVO ID PARA UM NOVO ALUGUEL (PEGAR ID ULTIMO ALUGUEL E SOMA COM MAIS 1)
                conexão.Open();
                MySqlCommand max = new MySqlCommand("select max(idaluguel) from aluguel", conexão);
                max.CommandType = CommandType.Text;
                /*codigo para ler os dados do banco criar uma variavel mysqlreader e 
                 atribuir o codigo ao objeto mais o codigo de execução*/
                MySqlDataReader ler;
                ler = max.ExecuteReader();
                ler.Read();
                id_con = ler.GetString(0);
                id = Convert.ToInt16(id_con);
                idN = ++id;
                idaluguel.Text = Convert.ToString(idN);
                conexão.Close();
            }
            catch (Exception a) { MessageBox.Show("ERR0"+a); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                conexão.Open();
                MySqlCommand inserir = new MySqlCommand("INSERT INTO `aluguel` (`IdAluguel`, `dataAluguel`, `TipoPagamento`, `TempoAlugado`, `Valor`, `ValorDesconto`, `Idfuncionario`,Idcartão) VALUES (?, ?, ?, ?, ?, ?, ?,?);", conexão);
               inserir.Parameters.Add("@IdAluguel", MySqlDbType.Int16).Value = idN;
                inserir.Parameters.Add("@dataAluguel", MySqlDbType.DateTime).Value = DateTime.Now;
                inserir.Parameters.Add("@TipoPagamento", MySqlDbType.VarChar, 20).Value = tipopag.Text;
                inserir.Parameters.Add("@TempoAlugado", MySqlDbType.VarChar,8).Value = tempoA.Text;
                inserir.Parameters.Add("@Valor", MySqlDbType.Double).Value = valor.Text;
                inserir.Parameters.Add("@ValorDesconto", MySqlDbType.Double).Value = valordes.Text;
                inserir.Parameters.Add("@Idfuncionario", MySqlDbType.Int16).Value = idfuc.Text;
                inserir.Parameters.Add("@Idcartão", MySqlDbType.Int16).Value = idcard.Text;
                conexão.Close();
                //consultar saldo do cliente
                conexão.Open();
                MySqlCommand select = new MySqlCommand("select saldo from cartão_acesso where id= ?",conexão);
                select.Parameters.Clear();
                select.Parameters.Add("saldo", MySqlDbType.Int16).Value = idcard.Text;
                select.CommandType = CommandType.Text;
                /*codigo para ler os dados do banco criar uma variavel mysqlreader e 
                 atribuir o codigo ao objeto mais o codigo de execução*/
                MySqlDataReader ler;
                ler = select.ExecuteReader();
                ler.Read();
                y = ler.GetInt16(0);
                conexão.Close();
                //descontar valor do aluguel no saldo do cartão
                conexão.Open();
                MySqlCommand update = new MySqlCommand("update cartão_acesso set saldo=? where id= ? ", conexão);
                update.Parameters.Clear();
                x = Convert.ToDouble(valor.Text) - Convert.ToDouble(valordes.Text);
                x = y - x;
                update.Parameters.Add("saldo_cartão", MySqlDbType.Double).Value = x;
                update.Parameters.Add("@Idcartão", MySqlDbType.Int16).Value = idcard.Text;
                //executando no banco
                inserir.ExecuteNonQuery();
                update.ExecuteNonQuery();
                MessageBox.Show("Aluguel Efetuado");
                conexão.Close();
            }
            catch(Exception a)
            {
                MessageBox.Show("erro" + a);
            }
        }

        private void inserir_aluguel_Load(object sender, EventArgs e)
        {

        }

        private void idaluguel_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                comboboxselect = pc_nivel.SelectedItem.ToString();
                comboOption = Convert.ToInt16(comboboxselect);
                conexão.Open();
                if (comboOption == 1)
                {
                    MySqlCommand select1 = new MySqlCommand("select idcomputador,statu from computador where statu = 1 and  Desempenho = 1;", conexão);
                    MySqlDataAdapter apt = new MySqlDataAdapter(select1);
                    DataTable tb = new DataTable();
                    apt.Fill(tb);
                    gridpc.DataSource = tb;
                }
                else if (comboOption == 2)
                {
                    MySqlCommand select2 = new MySqlCommand("select idcomputador,statu from computador where statu = 1 and  Desempenho = 2;", conexão);
                    MySqlDataAdapter apt2 = new MySqlDataAdapter(select2);
                    DataTable tb2 = new DataTable();
                    apt2.Fill(tb2);
                    gridpc.DataSource = tb2;
                }
                else
                {
                    MySqlCommand select3 = new MySqlCommand("select idcomputador,statu from computador where statu = 1 and  Desempenho = 3;", conexão);
                    MySqlDataAdapter apt3 = new MySqlDataAdapter(select3);
                    DataTable tb3 = new DataTable();
                    apt3.Fill(tb3);
                    gridpc.DataSource = tb3;
                }
                conexão.Close();


            }
            catch (Exception A)
            {
                MessageBox.Show("ERRO:" + A);
            }
        }

        private void adcionar_Click(object sender, EventArgs e)
        {
            try
            {
                //inserir computador selecionado na aluguelcomputador
                conexão.Open();
                MySqlCommand inserir = new MySqlCommand("INSERT INTO `aluguelcomputador` (IdComputador, IdAluguel) VALUES ( ?, ?)", conexão);
                inserir.Parameters.Add("@IdComputador", MySqlDbType.Int16).Value = id_pc_adc.Text;
                inserir.Parameters.Add("@IdAluguel", MySqlDbType.Int16).Value = idN;
                inserir.ExecuteNonQuery();
                
                conexão.Close();
                //mostrar computador selecionado na tabela
                conexão.Open();
                MySqlCommand select = new MySqlCommand("select idaluguelcomputador as selected, idcomputador, idaluguel from aluguelcomputador where idaluguel = ?", conexão);
                select.Parameters.Add("@idaluguel", MySqlDbType.Int16).Value = idN;
                MySqlDataAdapter apt = new MySqlDataAdapter(select);
                DataTable tb = new DataTable();
                apt.Fill(tb);
                grid_aluguelpc.DataSource = tb;
                conexão.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("erro:" + a);
            }

        }

        private void grid_aluguelpc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                conexão.Open();
                MySqlCommand deletar = new MySqlCommand("delete from aluguelcomputador where idaluguelcomputador = ?", conexão);
                deletar.Parameters.Clear();
                deletar.Parameters.Add("@idaluguelc", MySqlDbType.Int16).Value = delete_select.Text;
                deletar.CommandType = CommandType.Text;
                deletar.ExecuteNonQuery();
                conexão.Close();
                //recarregar tabela
                conexão.Open();
                MySqlCommand select = new MySqlCommand("select idaluguelcomputador as selected, idcomputador from aluguelcomputador where idaluguel = ?", conexão);
                select.Parameters.Add("@idaluguel", MySqlDbType.Int16).Value = idN;
                MySqlDataAdapter apt = new MySqlDataAdapter(select);
                DataTable tb = new DataTable();
                apt.Fill(tb);
                grid_aluguelpc.DataSource = tb;
                conexão.Close();

            }
            catch (Exception a)
            {
                MessageBox.Show("erro"+ a);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("preencha todos os campos para a realização do aluguel");
            MessageBox.Show("Depois selecione o computador ou computadores que será usado aperte no último botão para realizar aluguel");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
