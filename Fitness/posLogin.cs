using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Fitness
{
    public partial class posLogin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
                int nHeightEllipse

         );
        public posLogin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        public posLogin(string valor)
        {

            InitializeComponent();
            label1.Text = valor;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlNav1.Height = button2.Height;
            pnlNav1.Top = button2.Top;
            button2.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Dúvidas";

            this.pnlFormLoader.Controls.Clear();
            Form4 frmDashboard_Vrb = new Form4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlNav1.Height = button3.Height;
            pnlNav1.Top = button3.Top;
            button3.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Calcular IMC/TDEE/TMB";

            this.pnlFormLoader.Controls.Clear();
            Form1 frmDashboard_Vrb = new Form1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlNav1.Height = button4.Height;
            pnlNav1.Top = button4.Top;
            button4.BackColor = Color.FromArgb(46, 51, 73);
            this.Close();
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button6_Leave(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

     

        private void button6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNav1.Height = button1.Height;
            pnlNav1.Top = button1.Top;
            button1.BackColor = Color.FromArgb(46, 51, 73);
            lbltitle.Text = "Receitas";

            this.pnlFormLoader.Controls.Clear();
            receitasFORMS frmDashboard_Vrb = new receitasFORMS() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

       

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void calorias_Click(object sender, EventArgs e)
        {
            pnlNav1.Height = calorias.Height;
            pnlNav1.Top = calorias.Top;
            calorias.BackColor = Color.FromArgb(46, 51, 73);


            lbltitle.Text = "Contador de calorias";

            this.pnlFormLoader.Controls.Clear();
            Form3 frmDashboard_Vrb = new Form3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void calorias_Leave(object sender, EventArgs e)
        {
            calorias.BackColor = Color.FromArgb(24, 30, 54);
        }


        private void Dicas_Click(object sender, EventArgs e)
        {
            pnlNav1.Height = Dicas.Height;
            pnlNav1.Top = Dicas.Top;
            Dicas.BackColor = Color.FromArgb(46, 51, 73);


            lbltitle.Text = "Dicas de Emagrecimento";

            this.pnlFormLoader.Controls.Clear();
            DicasEmForms frmDashboard_Vrb = new DicasEmForms() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void pnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dicas_Leave(object sender, EventArgs e)
        {
            Dicas.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void DicasMassa_Click(object sender, EventArgs e)
        {
            pnlNav1.Height = DicasMassa.Height;
            pnlNav1.Top = DicasMassa.Top;
            DicasMassa.BackColor = Color.FromArgb(46, 51, 73);


            lbltitle.Text = "Dicas para ganho de massa muscular";

            this.pnlFormLoader.Controls.Clear();
            DicasGanhoMassa frmDashboard_Vrb = new DicasGanhoMassa() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void DicasMassa_Leave(object sender, EventArgs e)
        {
            DicasMassa.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            pnlNav1.Height = button5.Height;
            pnlNav1.Top = button5.Top;
            button5.BackColor = Color.FromArgb(46, 51, 73);


            lbltitle.Text = "Biotipos";

            this.pnlFormLoader.Controls.Clear();
            biotiposForms frmDashboard_Vrb = new biotiposForms() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void button5_Leave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
