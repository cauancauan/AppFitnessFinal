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
    class DAOPessoa
    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;
        public string resultado;

        public int[] vetorCodigo;
        public string[] vetorNome;
        public string[] vetorEmail;
        public string[] vetorUsuario;
        public string[] vetorSenha;
        public int i;
        public int contador;
        public string msg;
        public int contarCodigo;
        public DAOPessoa()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=appfitness;Uid=root;password=");
            try
            {
                conexao.Open();
                
            }
            catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado"+erro);
                conexao.Close();
            }
        }//fim dao pessoa

        public void inserir(string nome, string email, string usuario, string senha)
        {
            try
            {
                dados = "('','" + nome + "','" + email + "','" + usuario + "','" + senha + "')";
                comando = "Insert into Pessoa(codigo, nome, email, usuario, senha) values" + dados;


                MySqlCommand sql = new MySqlCommand(comando, conexao);
                resultado = "" + sql.ExecuteNonQuery();
                if(resultado == "1")
                {
                    MessageBox.Show("Cadastrado com sucesso");
                    
                }
                else
                {
                    MessageBox.Show("Não cadastrado");
                }

            }
            catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado" +erro);
            }
        }//fim do inserir

        public void PreencherVetor()
        {
            string query = "select * from Pessoa";

            vetorCodigo = new int[100];
            vetorNome = new string[100];
            vetorEmail = new string[100];
            vetorUsuario = new string[100];
            vetorSenha = new string[100];


            for (int i = 0; i < 100; i++)
            {
                vetorCodigo[i] = 0;
                vetorNome[i] = "";
                vetorEmail[i] = "";
                vetorUsuario[i] = "";
                vetorSenha[i] = "";
            }//fim do for

            MySqlCommand coletar = new MySqlCommand(query, conexao);
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            contarCodigo = 0;

            while (leitura.Read())
            {
                vetorCodigo[i] = Convert.ToInt32(leitura["codigo"]);
                vetorNome[i] = leitura["nome"] +"";
                vetorEmail[i] = leitura["email"] + "";
                vetorUsuario[i] = leitura["usuario"] + "";
                vetorSenha[i] = leitura["senha"] + "";
                contarCodigo = contador;
                i++;
                contador++;
            }//Fim do while

            leitura.Close();

        }//Fim do preencher vetor

        public string ConsultarTudo()
        {
            PreencherVetor();
            msg = "";
            for(i = 0; i< contador; i++)
            {
                msg += "Código: " + vetorCodigo[i] +
                      ", Nome:" + vetorNome[i] +
                      ", E-Mail: " + vetorEmail[i] +
                      ", Usuário: " + vetorUsuario[i] +
                      ", Senha: " + vetorSenha[i] +
                      "\n\n";
            }

            return msg;
        }// fim consultar tudo

        public int ConsultarCodigo()
        {
            PreencherVetor();
            return vetorCodigo[contarCodigo];
        }// fim consultar codigo


        public string ConsultarNome(int cod)
        {

            PreencherVetor();
            for(i = 0; i < contador; i++)
            {
                if(vetorCodigo[i] == cod)
                {
                    return vetorNome[i];
                }//fim if
            }//fim for
            return "Nome não encontrado";
        }// Fim consultar nome

        public string ConsultarEmail(int cod)
        {

            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (vetorCodigo[i] == cod)
                {
                    return vetorEmail[i];
                }//fim if
            }//fim for
            return "E-Mail não encontrado";
        }// Fim consultar email

        public string ConsultarUsuario(int cod)
        {

            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (vetorCodigo[i] == cod)
                {
                    return vetorUsuario[i];
                }//fim if
            }//fim for
            return "Usuário não encontrado";
        }// Fim consultar usuario

        public string ConsultarSenha(int cod)
        {

            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (vetorCodigo[i] == cod)
                {
                    return vetorSenha[i];
                }//fim if
            }//fim for
            return "Senha não encontrado";
        }// Fim consultar nome

        public void Atualizar(int cod, string campo, string novoDado)
        {
            try
            {
                string query = "update pessoa set " + campo + " = '" + novoDado + "' where codigo ='" + cod + "'";
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                if (resultado == "1")
                {
                    MessageBox.Show("Atualizado com sucesso");

                }
                else
                {
                    MessageBox.Show("Não atualizado");
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("" + erro);
            }
        }//fim do atualizar

        public void Deletar(int cod)
        {
            try
            {
                string query = "delete from pessoa where codigo = '" + cod + "'";
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                if (resultado == "1")
                {
                    MessageBox.Show("Deletado com sucesso");

                }
                else
                {
                    MessageBox.Show("Não deletado");
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("" + erro);
            }
        }


    }//fim classe daopessoa
}//fim projeto
