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
    public partial class clienteI : Form
    {
        public clienteI()
        {
            InitializeComponent();
            comboEstado.Items.Add("PE");
            comboEstado.Items.Add("CE");
            comboEstado.Items.Add("SE");
            comboEstado.Items.Add("PA");
            comboEstado.Items.Add("RJ");
            comboEstado.Items.Add("SP");
            combotipo.Items.Add("1");
            combotipo.Items.Add("2");

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection insert_cliente = new MySqlConnection("server=localhost;port=3306;User Id=root;database=acr_2v; password=");
                insert_cliente.Open();


                MySqlCommand insert = new MySqlCommand("INSERT INTO cliente ( Nome, Numero_Doc, Tipo, Rua, Número, Estado, cidade) VALUES ( ?, ?, ?, ?, ?, ?, ?);", insert_cliente);
                
             
                insert.Parameters.Add("@Nome", MySqlDbType.VarChar, 40).Value = nomecliente.Text;
                insert.Parameters.Add("@Numero_Doc", MySqlDbType.VarChar, 12).Value = numerodoc.Text;
                insert.Parameters.Add("@Tipo", MySqlDbType.Int16).Value = combotipo.SelectedItem.ToString();
                insert.Parameters.Add("@Rua", MySqlDbType.VarChar, 100).Value = rua.Text;
                insert.Parameters.Add("@Número", MySqlDbType.VarChar,5).Value = numeroend.Text;
                insert.Parameters.Add("@Estado", MySqlDbType.VarChar, 3).Value = comboEstado.SelectedItem.ToString();
                insert.Parameters.Add("@Cidade", MySqlDbType.VarChar, 20).Value = cidade.Text;
                
             insert.ExecuteNonQuery();
                MessageBox.Show("Cliente Inserido!!!");
                insert_cliente.Close();
               

            }
            catch(Exception ERR) { MessageBox.Show("Não foi possivel inserir " + ERR); }
        }

        private void clienteI_Load(object sender, EventArgs e)
        {

        }

        private void combocidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numeroend_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
