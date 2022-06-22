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
    public partial class MSGForm1 : Form
    {
        public MSGForm1()
        {
            InitializeComponent();
        }

        public MSGForm1(string valor)
        {
            InitializeComponent();
            textBox3.Text =valor;
           
            
        }





        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MSGForm1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
