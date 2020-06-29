using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.DAL
{
    public class Emprestimo
    {
        private string strCon = CAMADAS.DAL.Conexao.getConexao();


        public List<MODEL.Emprestimo> Select()
        {
            List<MODEL.Emprestimo> LstEmprestimo = new List<MODEL.Emprestimo>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM EMPRESTIMO;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    CAMADAS.MODEL.Emprestimo emprestimo = new MODEL.Emprestimo();
                    emprestimo.ID = Convert.ToInt32(dados["ID"].ToString());
                    emprestimo.CLIENTE_ID = Convert.ToInt32(dados["CLIENTE_ID"].ToString());
                    emprestimo.NOME_CLI = dados["NOME_CLI"].ToString();
                    emprestimo.DATA = Convert.ToDateTime(dados["DATA"].ToString());

                    CAMADAS.DAL.Clientes dalCli = new Clientes();
                    CAMADAS.MODEL.Clientes cliente = dalCli.SelectID(emprestimo.CLIENTE_ID);
                    emprestimo.NOME_CLI = cliente.NOME;

                    LstEmprestimo.Add(emprestimo);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta do Emprestimo...");
            }
            finally
            {
                conexao.Close();
            }

            return LstEmprestimo;
        }

        public List<MODEL.Emprestimo> SelectByID(int ID)
        {
            List<MODEL.Emprestimo> LstEmprestimo = new List<MODEL.Emprestimo>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM EMPRESTIMO WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    CAMADAS.MODEL.Emprestimo emprestimo = new MODEL.Emprestimo();
                    emprestimo.ID = Convert.ToInt32(dados["ID"].ToString());
                    emprestimo.CLIENTE_ID = Convert.ToInt32(dados["CLIENTE_ID"].ToString());
                    emprestimo.DATA = Convert.ToDateTime(dados["DATA"].ToString());

                    CAMADAS.DAL.Clientes dalCli = new Clientes();
                    CAMADAS.MODEL.Clientes cliente = dalCli.SelectID(emprestimo.CLIENTE_ID);
                    emprestimo.NOME_CLI = cliente.NOME;

                    LstEmprestimo.Add(emprestimo);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta do Emprestimo...");
            }
            finally
            {
                conexao.Close();
            }

            return LstEmprestimo;
        }
        public void Inserir(MODEL.Emprestimo emprestimo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO EMPRESTIMO VALUES (@CLIENTE_ID, @DATA);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@CLIENTE_ID", emprestimo.CLIENTE_ID);
            cmd.Parameters.AddWithValue("@DATA", emprestimo.DATA);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na inserção de Emprestimo...");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void UPDATE(MODEL.Emprestimo emprestimo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE EMPRESTIMO SET CLIENTE_ID=@CLIENTE_ID, DATA=@DATA  ";
            sql += " WHERE ID=@ID";

            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", emprestimo.ID);
            cmd.Parameters.AddWithValue("@CLIENTE_ID", emprestimo.CLIENTE_ID);
            cmd.Parameters.AddWithValue("@DATA", emprestimo.DATA);


            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Emprestimo...");
            }
            finally
            {
                conexao.Close();
            }

        }
        public void Delete(int idEmprestimo)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM EMPRESTIMO WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", idEmprestimo);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro remoção de Emprestimo...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}