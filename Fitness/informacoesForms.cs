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
    public partial class informacoesForms : Form
    {
        public informacoesForms()
        {
            InitializeComponent();
            box1.ReadOnly = true;
            textBox1.ReadOnly = true;

        }

        private void box1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
