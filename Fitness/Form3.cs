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
    public partial class Form3 : Form
    {
        double calculo1;
        double calculo2;
        double calculo3;
        double calculo4;
        double calculofinal;

        public Form3()
        {

            InitializeComponent();
            textBox5.ReadOnly = true;
            textBox10.ReadOnly = true;
            textBox15.ReadOnly = true;
            textBox20.ReadOnly = true;
            textBox21.ReadOnly = true;


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.fatsecret.com.br/calorias-nutri%C3%A7%C3%A3o/");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Calcular1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") 
            {
                textBox1.Text = "0";
            }
            if(textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            if(textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            if(textBox4.Text == "")
            {
                textBox4.Text = "0";
            }

           
            
            int cafe1 = Convert.ToInt32(textBox1.Text);
            int cafe2 = Convert.ToInt32(textBox2.Text);
            int cafe3 = Convert.ToInt32(textBox3.Text);
            int cafe4 = Convert.ToInt32(textBox4.Text);

            calculo1 = cafe1 + cafe2 + cafe3 + cafe4;

            textBox5.Text = "" + calculo1;
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "0";
            }
            if (textBox7.Text == "")
            {
                textBox7.Text = "0";
            }
            if (textBox8.Text == "")
            {
                textBox8.Text = "0";
            }
            if (textBox9.Text == "")
            {
                textBox9.Text = "0";
            }    
            int almoco1 = Convert.ToInt32(textBox6.Text);
            int almoco2 = Convert.ToInt32(textBox7.Text);
            int almoco3 = Convert.ToInt32(textBox8.Text);
            int almoco4 = Convert.ToInt32(textBox9.Text);

            calculo2 = almoco1 + almoco2 + almoco3 + almoco4;

            textBox10.Text = "" + calculo2;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculofinal = calculo1 + calculo2+calculo3+calculo4;
            textBox21.Text = "Você consumiu no total: " + calculofinal;
            
        }

        private void textBox21_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                textBox11.Text = "0";
            }
            if (textBox12.Text == "")
            {
                textBox12.Text = "0";
            }
            if (textBox13.Text == "")
            {
                textBox13.Text = "0";
            }
            if (textBox14.Text == "")
            {
                textBox14.Text = "0";
            }
            int janta1 = Convert.ToInt32(textBox11.Text);
            int janta2 = Convert.ToInt32(textBox12.Text);
            int janta3 = Convert.ToInt32(textBox13.Text);
            int janta4 = Convert.ToInt32(textBox14.Text);

            calculo3 = janta1 + janta2 + janta3 + janta4;

            textBox15.Text = "" + calculo3;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

   
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox16.Text == "")
            {
                textBox16.Text = "0";
            }
            if (textBox17.Text == "")
            {
                textBox17.Text = "0";
            }
            if (textBox18.Text == "")
            {
                textBox18.Text = "0";
            }
            if (textBox19.Text == "")
            {
                textBox19.Text = "0";
            }
            int outro1 = Convert.ToInt32(textBox16.Text);
            int outro2 = Convert.ToInt32(textBox17.Text);
            int outro3 = Convert.ToInt32(textBox18.Text);
            int outro4 = Convert.ToInt32(textBox19.Text);

            calculo4 = outro1+outro2+outro3+outro4;

            textBox20.Text = "" + calculo4;
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }
            if (textBox25.Text == "")
            {
                textBox25.Text = "0";
            }
            if (textBox24.Text == "")
            {
                textBox24.Text = "0";
            }
            if (textBox23.Text == "")
            {
                textBox23.Text = "0";
            }
            if (textBox22.Text == "")
            {
                textBox22.Text = "0";
            }




            int cafe1 = Convert.ToInt32(textBox1.Text);
            int cafe2 = Convert.ToInt32(textBox2.Text);
            int cafe3 = Convert.ToInt32(textBox3.Text);
            int cafe4 = Convert.ToInt32(textBox4.Text);
            int cafe5 = Convert.ToInt32(textBox25.Text);
            int cafe6 = Convert.ToInt32(textBox24.Text);
            int cafe7 = Convert.ToInt32(textBox23.Text);
            int cafe8 = Convert.ToInt32(textBox22.Text);


            calculo1 = cafe1 + cafe2 + cafe3 + cafe4 + cafe5 + cafe6 +cafe7 +cafe8;

            textBox5.Text = "" + calculo1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "0";
            }
            if (textBox7.Text == "")
            {
                textBox7.Text = "0";
            }
            if (textBox8.Text == "")
            {
                textBox8.Text = "0";
            }
            if (textBox9.Text == "")
            {
                textBox9.Text = "0";
            }
            if (textBox29.Text == "")
            {
                textBox29.Text = "0";
            }
            if (textBox28.Text == "")
            {
                textBox28.Text = "0";
            }
            if (textBox27.Text == "")
            {
                textBox27.Text = "0";
            }
            if (textBox26.Text == "")
            {
                textBox26.Text = "0";
            }



            int almoco1 = Convert.ToInt32(textBox6.Text);
            int almoco2 = Convert.ToInt32(textBox7.Text);
            int almoco3 = Convert.ToInt32(textBox8.Text);
            int almoco4 = Convert.ToInt32(textBox9.Text);
            int almoco5 = Convert.ToInt32(textBox29.Text);
            int almoco6 = Convert.ToInt32(textBox28.Text);
            int almoco7 = Convert.ToInt32(textBox27.Text);
            int almoco8 = Convert.ToInt32(textBox26.Text);

            calculo2 = almoco1 + almoco2 + almoco3 + almoco4 + almoco5 +almoco6 + almoco7+almoco8;

            textBox10.Text = "" + calculo2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                textBox11.Text = "0";
            }
            if (textBox12.Text == "")
            {
                textBox12.Text = "0";
            }
            if (textBox13.Text == "")
            {
                textBox13.Text = "0";
            }
            if (textBox14.Text == "")
            {
                textBox14.Text = "0";
            }
            if (textBox33.Text == "")
            {
                textBox33.Text = "0";
            }
            if (textBox32.Text == "")
            {
                textBox32.Text = "0";
            }
            if (textBox31.Text == "")
            {
                textBox31.Text = "0";
            }
            if (textBox30.Text == "")
            {
                textBox30.Text = "0";
            }



            int janta1 = Convert.ToInt32(textBox11.Text);
            int janta2 = Convert.ToInt32(textBox12.Text);
            int janta3 = Convert.ToInt32(textBox13.Text);
            int janta4 = Convert.ToInt32(textBox14.Text);
            int janta5 = Convert.ToInt32(textBox33.Text);
            int janta6 = Convert.ToInt32(textBox32.Text);
            int janta7 = Convert.ToInt32(textBox31.Text);
            int janta8 = Convert.ToInt32(textBox30.Text);


            calculo3 = janta1 + janta2 + janta3 + janta4+janta5+janta6+janta7+janta8;

            textBox15.Text = "" + calculo3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox16.Text == "")
            {
                textBox16.Text = "0";
            }
            if (textBox17.Text == "")
            {
                textBox17.Text = "0";
            }
            if (textBox18.Text == "")
            {
                textBox18.Text = "0";
            }
            if (textBox19.Text == "")
            {
                textBox19.Text = "0";
            }
            if (textBox37.Text == "")
            {
                textBox37.Text = "0";
            }
            if (textBox36.Text == "")
            {
                textBox36.Text = "0";
            }
            if (textBox35.Text == "")
            {
                textBox35.Text = "0";
            }
            if (textBox34.Text == "")
            {
                textBox34.Text = "0";
            }



            int outro1 = Convert.ToInt32(textBox16.Text);
            int outro2 = Convert.ToInt32(textBox17.Text);
            int outro3 = Convert.ToInt32(textBox18.Text);
            int outro4 = Convert.ToInt32(textBox19.Text);
            int outro5 = Convert.ToInt32(textBox37.Text);
            int outro6 = Convert.ToInt32(textBox36.Text);
            int outro7 = Convert.ToInt32(textBox35.Text);
            int outro8 = Convert.ToInt32(textBox34.Text);

            calculo4 = outro1 + outro2 + outro3 + outro4+outro5+outro6+outro7+outro8;

            textBox20.Text = "" + calculo4;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            calculofinal = calculo1 + calculo2 + calculo3 + calculo4;
            textBox21.Text = "" + calculofinal;
        }

        private void textBox22_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
