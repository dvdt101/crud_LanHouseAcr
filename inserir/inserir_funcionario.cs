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
    public partial class inserir_funcionario : Form
    {
        public inserir_funcionario()
        {
            InitializeComponent();
        }

        private void inserir_funcionario_Load(object sender, EventArgs e)
        {

        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection inserir_func = new MySqlConnection("server=localhost;port=3306;User Id=root;database=acr_2v; password=");
                inserir_func.Open();
                MySqlCommand inserirF = new MySqlCommand("INSERT INTO funcionario ( Salario, Cpf, Rua, Numero, Cidade, Estado, IdFuncionario, Função, Nome) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?);", inserir_func);
                
                inserirF.Parameters.Add("@Salario", MySqlDbType.Double).Value = salario_func.Text;
                inserirF.Parameters.Add("@Cpf", MySqlDbType.VarChar, 12).Value = cpf_func.Text;
                inserirF.Parameters.Add("@Rua", MySqlDbType.VarChar, 100).Value = rua_func.Text;
                inserirF.Parameters.Add("@Numero", MySqlDbType.VarChar, 5).Value = numero_func.Text;
                inserirF.Parameters.Add("@Cidade", MySqlDbType.VarChar, 20).Value = cidade_func.Text;
                inserirF.Parameters.Add("@Estado", MySqlDbType.VarChar, 20).Value = estado_func.Text;
                inserirF.Parameters.Add("@IdFuncionario", MySqlDbType.Int16).Value = chefe_func.Text;
                inserirF.Parameters.Add("@Função", MySqlDbType.VarChar, 45).Value = funçao_func.Text;
                inserirF.Parameters.Add("@Nome", MySqlDbType.VarChar, 45).Value = nome_func.Text;
                inserirF.ExecuteNonQuery();
                inserir_func.Close();
                MessageBox.Show("Funcionario inserido!!!");
            }
            catch
            {
                MessageBox.Show("erro");
            }
        }
    }
}
