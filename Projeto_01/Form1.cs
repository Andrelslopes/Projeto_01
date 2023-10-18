using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_01
{
    public partial class Form1 : Form
    {
        int contador = 5;
        string user;
        public Form1()
        {
            InitializeComponent();
        }
        //PROJETO NOVO
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ( txtUser.Text == "" || txtPass.Text == "") // testa se a text box está vazia
            {
                MessageBox.Show("Usuário ou Senha não pode estar vazio.");
            }
            else
            {
                contador -= 1; //decrementa o a variavel contador para mostrar a quantidade de tentativas disponiveis no ultimo msgbox 

                if (contador <= 0)
                {
                    MessageBox.Show("Usúario ou Senha invalidos","Acesso Negado");
                    this.Close();
                }
                else
                {
                    if (txtUser.Text == "etec" && txtPass.Text == "etec") // testa o usuário e senha para entrar no sistema
                    {
                        user = txtUser.Text;
                        MessageBox.Show("Olá " +user+" \nSeja Bem Vindo ao Sistema" );
                        Menu telaMenu = new Menu();
                        telaMenu.Show(); // chama a tela de cadastro do cliente
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usário Incorreto! \n Restam " + contador + " tentativas", "Login Inválido");
                    }
                }
            }   
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
