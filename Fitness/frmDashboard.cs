using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Fitness
{
    
    public partial class frmDashboard : Form
    {
        DAOPessoa pessoa;
        string usuario;
        string senha;
        Form5 formdaora;
        public frmDashboard()
        {
            pessoa = new DAOPessoa();
            
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {

            
            try { 
            string conexao = "server=localhost;DataBase=appfitness;Uid=root;password=";
            var connection = new MySqlConnection(conexao);
            var comand = connection.CreateCommand();
               
               

         
            MySqlCommand query = new MySqlCommand("select* from Pessoa where usuario ='" + textBox3.Text + "' and senha ='" + textBox4.Text+"'", connection);
                    
            connection.Open();
                DataTable dataTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query);
                da.Fill(dataTable);

                foreach(DataRow list in dataTable.Rows)
                {
                    if (Convert.ToInt32(list.ItemArray[0]) > 0)
                    {
                       
                        
                        posLogin destino = new posLogin(textBox3.Text);
                        

                        destino.Show();
                       
                        
                    }
                    else
                    {
                        MessageBox.Show("errado");
                    }
                }

          









            }
            catch (Exception erro)
            {
                MessageBox.Show("erro"+erro) ;
            }



           



        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
