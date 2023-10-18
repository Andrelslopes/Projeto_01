using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Projeto_01
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNasc.Text != "")
            {
                try
                {
                    DateTime diasNascimento;
                    DateTime diasHoje;
                    diasNascimento = DateTime.Parse(txtNasc.Text);
                    diasHoje = System.DateTime.Today;

                    int AnoNascimento = DateTime.Parse(txtNasc.Text).Year;
                    int AnoAtual = System.DateTime.Now.Year;
                    int AnoIdade = AnoAtual - AnoNascimento;

                    if(diasNascimento > diasHoje)
                    {
                        MessageBox.Show("Atenção! \n Não é Permitido data maior que hoje!","Atenção!");
                    }

                    if (diasNascimento.DayOfYear > diasHoje.DayOfYear)
                    {
                        AnoIdade = AnoIdade - 1;
                    }

                    if (AnoIdade <= 17)
                    {
                        MessageBox.Show("Menor de Idade, Volte mais Tarde");
                    }
                    else
                    {
                        MessageBox.Show("Parabens já é maior de idade");
                    }

                    int qtdDiasVida = diasHoje.DayOfYear - diasNascimento.DayOfYear;

                    //MessageBox.Show("Data Válida");
                }
                catch
                {
                    MessageBox.Show("Data Invalida");
                    txtNasc.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Data é um campo Obrigatório");
            }

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            string conexao = "server=localhost;database=bd_gerestoq;uid=root;pwd=123456";
            MySqlConnection conexaoMySql = new MySqlConnection (conexao);
            conexaoMySql.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter ("select * from tb_clientes", conexaoMySql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgv_cliente.DataSource = dt;

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
