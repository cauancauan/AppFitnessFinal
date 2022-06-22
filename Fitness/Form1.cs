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
    public partial class Form1 : Form
    {
        MSGForm1 transferir;
        public string calculo;
        public Form1()
        {
            InitializeComponent();
            transferir = new MSGForm1();
            textBox1.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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

        

        private void Calcular_Click(object sender, EventArgs e)
        {
            
            
            if (comboBox1.Text == "Homem")
            {
                if(comboBox2.Text == "Sedentário (pouco ou nenhum exercício)")
                {
                    double calculo = 0;
                    double calculo1 = 0;
                    double calculo2 = 0;
                    double calculo3 = 0;
                    int peso = Convert.ToInt32(textBox2.Text);
                    double altura = Convert.ToDouble(textBox3.Text);
                    int idade = Convert.ToInt32(textBox4.Text);
                    calculo = 10 * peso + 6.25 * altura - 5 * idade +5;
                    calculo1 = calculo * 1.2;
                    calculo3 = altura / 100;     
                    calculo2 =  Math.Round(peso / (calculo3*calculo3),2);

                    textBox1.Text = ""+calculo;
                    textBox5.Text = ""+calculo1;
                    textBox6.Text = "" + calculo2;
                    
                }
                if(comboBox2.Text == "Levemente ativo (exercício leve 1 a 3 dias por semana)")
                {
                    double calculo = 0;
                    double calculo1 = 0;
                    double calculo2 = 0;
                    double calculo3 = 0;
                    int peso = Convert.ToInt32(textBox2.Text);
                    double altura = Convert.ToDouble(textBox3.Text);
                    int idade = Convert.ToInt32(textBox4.Text);
                    calculo = 10 * peso + 6.25 * altura - 5 * idade + 5;
                    calculo1 = calculo * 1.375;
                    calculo3 = altura / 100;
                    calculo2 = Math.Round(peso / (calculo3 * calculo3), 2);
                    textBox1.Text = "" + calculo;
                    textBox5.Text = "" + calculo1;
                    textBox6.Text = "" + calculo2;

                }
                if (comboBox2.Text == "Moderadamente ativo (exercício moderado, faz esportes 3 a 5 dias por semana)")
                {
                    double calculo = 0;
                    double calculo1 = 0;
                    double calculo2 = 0;
                    double calculo3 = 0;
                    int peso = Convert.ToInt32(textBox2.Text);
                    double altura = Convert.ToDouble(textBox3.Text);
                    int idade = Convert.ToInt32(textBox4.Text);
                    calculo = 10 * peso + 6.25 * altura - 5 * idade + 5;
                    calculo1 = calculo * 1.55;
                    calculo3 = altura / 100;
                    calculo2 = Math.Round(peso / (calculo3 * calculo3), 2);
                    textBox1.Text = "" + calculo;
                    textBox5.Text = "" + calculo1;
                    textBox6.Text = "" + calculo2;

                }
                if (comboBox2.Text == "Altamente ativo (exercício pesado de 5 a 6 dias por semana)")
                {
                    double calculo = 0;
                    double calculo1 = 0;
                    double calculo2 = 0;
                    double calculo3 = 0;
                    int peso = Convert.ToInt32(textBox2.Text);
                    double altura = Convert.ToDouble(textBox3.Text);
                    int idade = Convert.ToInt32(textBox4.Text);
                    calculo = 10 * peso + 6.25 * altura - 5 * idade + 5;
                    calculo1 = calculo * 1.725;
                    calculo3 = altura / 100;
                    calculo2 = Math.Round(peso / (calculo3 * calculo3), 2);
                    textBox1.Text = "" + calculo;
                    textBox5.Text = "" + calculo1;
                    textBox6.Text = "" + calculo2;

                }
                if (comboBox2.Text == "Extremamente ativo (exercício pesado diariamente e até 2 vezes por dia)")
                {
                    double calculo = 0;
                    double calculo1 = 0;
                    double calculo2 = 0;
                    double calculo3 = 0;
                    int peso = Convert.ToInt32(textBox2.Text);
                    double altura = Convert.ToDouble(textBox3.Text);
                    int idade = Convert.ToInt32(textBox4.Text);
                    calculo = 10 * peso + 6.25 * altura - 5 * idade + 5;
                    calculo1 = calculo * 1.9;
                    calculo3 = altura / 100;
                    calculo2 = Math.Round(peso / (calculo3 * calculo3), 2);
                    textBox1.Text = "" + calculo;
                    textBox5.Text = "" + calculo1;
                    textBox6.Text = "" + calculo2;

                }


            }

            if (comboBox1.Text == "Mulher")
            {
                if (comboBox2.Text == "Sedentário (pouco ou nenhum exercício)")
                {
                    double calculo = 0;
                    double calculo1 = 0;
                    double calculo2 = 0;
                    double calculo3 = 0;
                    int peso = Convert.ToInt32(textBox2.Text);
                    double altura = Convert.ToDouble(textBox3.Text);
                    int idade = Convert.ToInt32(textBox4.Text);
                    calculo = 10 * peso + 6.25 * altura - 5 * idade - 161;
                    calculo1 = calculo * 1.2;
                    calculo3 = altura / 100;
                    calculo2 = Math.Round(peso / (calculo3 * calculo3), 2);
                    textBox1.Text = "" + calculo;
                    textBox5.Text = "" + calculo1;
                    textBox6.Text = "" + calculo2;

                }
                if (comboBox2.Text == "Levemente ativo (exercício leve 1 a 3 dias por semana)")
                {
                    double calculo = 0;
                    double calculo1 = 0;
                    double calculo2 = 0;
                    double calculo3 = 0;
                    int peso = Convert.ToInt32(textBox2.Text);
                    double altura = Convert.ToDouble(textBox3.Text);
                    int idade = Convert.ToInt32(textBox4.Text);
                    calculo = 10 * peso + 6.25 * altura - 5 * idade - 161;
                    calculo1 = calculo * 1.375;
                    calculo3 = altura / 100;
                    calculo2 = Math.Round(peso / (calculo3 * calculo3), 2);
                    textBox1.Text = "" + calculo;
                    textBox5.Text = "" + calculo1;
                    textBox6.Text = "" + calculo2;

                }
                if (comboBox2.Text == "Moderadamente ativo (exercício moderado, faz esportes 3 a 5 dias por semana)")
                {
                    double calculo = 0;
                    double calculo1 = 0;
                    double calculo2 = 0;
                    double calculo3 = 0;
                    int peso = Convert.ToInt32(textBox2.Text);
                    double altura = Convert.ToDouble(textBox3.Text);
                    int idade = Convert.ToInt32(textBox4.Text);
                    calculo = 10 * peso + 6.25 * altura - 5 * idade - 161;
                    calculo1 = calculo * 1.55;
                    calculo3 = altura / 100;
                    calculo2 = Math.Round(peso / (calculo3 * calculo3), 2);
                    textBox1.Text = "" + calculo;
                    textBox5.Text = "" + calculo1;
                    textBox6.Text = "" + calculo2;

                }
                if (comboBox2.Text == "Altamente ativo (exercício pesado de 5 a 6 dias por semana)")
                {
                    double calculo = 0;
                    double calculo1 = 0;
                    double calculo2 = 0;
                    double calculo3 = 0;
                    int peso = Convert.ToInt32(textBox2.Text);
                    double altura = Convert.ToDouble(textBox3.Text);
                    int idade = Convert.ToInt32(textBox4.Text);
                    calculo = 10 * peso + 6.25 * altura - 5 * idade - 161;
                    calculo1 = calculo * 1.725;
                    calculo3 = altura / 100;
                    calculo2 = Math.Round(peso / (calculo3 * calculo3), 2);
                    textBox1.Text = "" + calculo;
                    textBox5.Text = "" + calculo1;
                    textBox6.Text = "" + calculo2;

                }
                if (comboBox2.Text == "Extremamente ativo (exercício pesado diariamente e até 2 vezes por dia)")
                {
                    double calculo = 0;
                    double calculo1 = 0;
                    double calculo2 = 0;
                    double calculo3 = 0;
                    int peso = Convert.ToInt32(textBox2.Text);
                    double altura = Convert.ToDouble(textBox3.Text);
                    int idade = Convert.ToInt32(textBox4.Text);
                    calculo = 10 * peso + 6.25 * altura - 5 * idade - 161;
                    calculo1 = calculo * 1.9;
                    calculo3 = altura / 100;
                    calculo2 = Math.Round(peso / (calculo3 * calculo3), 2);
                    textBox1.Text = "" + calculo;
                    textBox5.Text = "" + calculo1;
                    textBox6.Text = "" + calculo2;

                }
            }





        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
