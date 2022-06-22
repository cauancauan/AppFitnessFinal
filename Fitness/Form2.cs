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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Calculadora_Click(object sender, EventArgs e)
        {
            Form1 formLogar = new Form1();
            formLogar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 formLogar = new Form3();
            formLogar.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 formLogar = new Form4();
            formLogar.ShowDialog();
        }
    }
}
