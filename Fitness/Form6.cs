using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness
{
    public partial class Form6 : Form
    {

        DAOPessoa pessoa;
        public string data_source = "server=localhost;DataBase=appfitness;Uid=root;password=";
        public Form6()
        {
            InitializeComponent();
            pessoa = new DAOPessoa();
            textBox5.Text = Convert.ToString(pessoa.ConsultarCodigo() +1);
            textBox5.ReadOnly = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlNav1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void Limpar()
        {
            textBox5.Text = "" + pessoa.ConsultarCodigo();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }//fim do limpar

        public void AtivarCampos()
        {
            
                textBox5.ReadOnly = false;
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox1.BackColor = Color.FromArgb(5, 30, 54);
                textBox2.BackColor = Color.FromArgb(5, 30, 54);
                textBox3.BackColor = Color.FromArgb(5, 30, 54);
                textBox4.BackColor = Color.FromArgb(5, 30, 54);

           
        }

            public void InativarCampos()
            {
                textBox5.ReadOnly = true;
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox1.BackColor = Color.FromArgb(24, 30, 54);
                textBox2.BackColor = Color.FromArgb(24, 30, 54);
                textBox3.BackColor = Color.FromArgb(24, 30, 54);
                textBox4.BackColor = Color.FromArgb(24, 30, 54);
            }

        public void AtivarTodosCampos()
        {
            textBox5.ReadOnly = false;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox1.BackColor = Color.FromArgb(24, 30, 54);
            textBox2.BackColor = Color.FromArgb(24, 30, 54);
            textBox3.BackColor = Color.FromArgb(24, 30, 54);
            textBox4.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.ReadOnly == false)
                {
                    Limpar();
                    InativarCampos();
                }
                else { 
               


                    int codigo = Convert.ToInt32(textBox5.Text);
                    string nome = textBox1.Text;
                    string email = textBox2.Text;
                    string usuario = textBox3.Text;
                    string senha = textBox4.Text;



                    pessoa.inserir(nome, email, usuario, senha);
                    Limpar();
                }




            }
            catch(Exception erro)
            {
                MessageBox.Show(""+erro);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox5.ReadOnly == true)
            {
                AtivarCampos();
            }
            else { 
            textBox1.Text = pessoa.ConsultarNome(Convert.ToInt32(textBox5.Text));
            textBox2.Text = pessoa.ConsultarEmail(Convert.ToInt32(textBox5.Text));
            textBox3.Text = pessoa.ConsultarUsuario(Convert.ToInt32(textBox5.Text));
            textBox4.Text = pessoa.ConsultarSenha(Convert.ToInt32(textBox5.Text));
            }
        }//fim botão consultar

        private void button2_Click_1(object sender, EventArgs e)
        {
            AtivarTodosCampos();
            if(textBox1.Text == "") { 
            textBox1.Text = pessoa.ConsultarNome(Convert.ToInt32(textBox5.Text));
            textBox2.Text = pessoa.ConsultarEmail(Convert.ToInt32(textBox5.Text));
            textBox3.Text = pessoa.ConsultarUsuario(Convert.ToInt32(textBox5.Text));
            textBox4.Text = pessoa.ConsultarSenha(Convert.ToInt32(textBox5.Text));
            }
            else 
            
            { 

            //atualizar nome

            pessoa.Atualizar(Convert.ToInt32(textBox5.Text), "nome", textBox1.Text);

            // atualizar email

            pessoa.Atualizar(Convert.ToInt32(textBox5.Text), "email", textBox2.Text);

            // atualizar usuario

            pessoa.Atualizar(Convert.ToInt32(textBox5.Text), "usuario", textBox3.Text);

            //atualizar senha

            pessoa.Atualizar(Convert.ToInt32(textBox5.Text), "senha", textBox4.Text);
                Limpar();
            }

        }// fim do atualizar

        private void button3_Click_1(object sender, EventArgs e)
        {
            AtivarCampos();
            pessoa.Deletar(Convert.ToInt32(textBox5.Text));
            Limpar();
        }
    }
}
