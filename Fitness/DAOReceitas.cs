using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Fitness
{
    class DAOReceitas
    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;
        public string resultado;

        public string[] vetorIngredientes;
        public string[] vetorModoDePreparo;
        public string[] vetorNomeReceitas;

        public int i;
        public int contador;
        public string msg;
        public DAOReceitas()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=appfitness;Uid=root;password=");
            try
            {
                conexao.Open();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado" + erro);
                conexao.Close();
            }
        }//fim dao pessoa
        public void inserir(string ingredientes, string modoDePreparo, string nomeReceita)
        {
            try
            {
                dados = "('" + ingredientes + "','" + modoDePreparo+"','"+nomeReceita+"')";
                comando = "Insert into receitas(ingredientes, modoDePreparo, nomeReceita) values" + dados;


                MySqlCommand sql = new MySqlCommand(comando, conexao);
                resultado = "" + sql.ExecuteNonQuery();
                MessageBox.Show(resultado + " linha afetada");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado" + erro);
            }
        }//fim do inserir

        public void PreencherVetor()
        {
            string query = "select * from receitas";

           
            vetorIngredientes = new string[100];
            vetorModoDePreparo = new string[100];
            vetorNomeReceitas = new string[100];
         


            for (int i = 0; i < 100; i++)
            {
               
                vetorIngredientes[i] = "";
                vetorModoDePreparo[i] = "";
                vetorNomeReceitas[i] = "";
               
            }//fim do for

            MySqlCommand coletar = new MySqlCommand(query, conexao);
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;

            while (leitura.Read())
            {
                
                vetorIngredientes[i] = leitura["ingredientes"] + "";
                vetorModoDePreparo[i] = leitura["modoDePreparo"] + "";
                vetorNomeReceitas[i] = leitura["nomeReceita"] + "";
                
                i++;
                contador++;
            }//Fim do while

            leitura.Close();

        }//Fim do preencher vetor

        public string ConsultarTudo()
        {
            PreencherVetor();
            msg = "";

            for (i = 0; i < contador; i++)
            {
                msg += "Nome da Receita: " +vetorNomeReceitas[i]+
                    "\nIngredientes: \n" + vetorIngredientes[i] +
                      "\nModo de preparo\n" + vetorModoDePreparo[i] +
                      "\n\n";
            }// fim do for

            return msg;

        }// fim do consultar tudo

   
    }
}
