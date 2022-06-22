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
    public partial class Form5 : Form
    {
        frmDashboard frm;

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


        public Form5()
        {
            frm = new frmDashboard();
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

 


        private void Cadastrar_Click(object sender, EventArgs e)
        {
            
            pnlNav1.Height = Cadastrar.Height;
            pnlNav1.Top = Cadastrar.Top;
            pnlNav1.Left = Cadastrar.Left;
            Cadastrar.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Gerenciar cadastro";

            this.pnlFormLoader.Controls.Clear();
            Form6 frmDashboard_Vrb = new Form6() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNav1.Height = button1.Height;
            pnlNav1.Top = button1.Top;
            button1.BackColor = Color.FromArgb(46, 51, 73);


            lbltitle.Text = "Logar";

            this.pnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        

       
      

        private void Cadastrar_Leave(object sender, EventArgs e)
        {
            Cadastrar.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(24, 30, 54);
        }

       

      

       public void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }

        private void pnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Informacoes_Click(object sender, EventArgs e)
        {
            pnlNav1.Height = Informacoes.Height;
            pnlNav1.Top = Informacoes.Top;
            Informacoes.BackColor = Color.FromArgb(46, 51, 73);


            lbltitle.Text = "Mais Informações";

            this.pnlFormLoader.Controls.Clear();
            informacoesForms frmDashboard_Vrb = new informacoesForms() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void Informacoes_Leave(object sender, EventArgs e)
        {
            Informacoes.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
