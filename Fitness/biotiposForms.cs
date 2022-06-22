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
    public partial class biotiposForms : Form
    {
        public biotiposForms()
        {
            InitializeComponent();
            box1.ReadOnly = true;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;


        }

        private void box1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tuasaude.com/como-identificar-o-seu-biotipo/#:~:text=O%20biotipo%20corporal%20corresponde%20ao,muscular%20e%20quantidade%20de%20gordura.");
        }
    }
}
