using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.DAL
{
    public class Livros
    {
        private string strCon = Conexao.getConexao();
        public List<MODEL.Livros> Select()
        {
            List<MODEL.Livros> LstLivros = new List<MODEL.Livros>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM LIVROS ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Livros livros = new MODEL.Livros();
                    livros.ID = Convert.ToInt32(dados["ID"].ToString());
                    livros.TITULO = dados["TITULO"].ToString();
                    livros.EDITORA = dados["EDITORA"].ToString();
                    livros.AUTOR = dados["AUTOR"].ToString();
                    livros.VALOR = Convert.ToSingle(dados["VALOR"].ToString());
                    livros.SITUACAO = Convert.ToInt32(dados["SITUACAO"].ToString());
                    LstLivros.Add(livros);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Livros");
            }
            finally
            {
                conexao.Close();
            }
            return LstLivros;
        }
        public List<MODEL.Livros> SelectID(int ID)
        {
            List<MODEL.Livros> LstLivros = new List<MODEL.Livros>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM LIVROS WHERE ID=@ID; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("ID", ID);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Livros livros = new MODEL.Livros();
                    livros.ID = Convert.ToInt32(dados["ID"].ToString());
                    livros.TITULO = dados["TITULO"].ToString();
                    livros.EDITORA = dados["EDITORA"].ToString();
                    livros.AUTOR = dados["AUTOR"].ToString();
                    livros.VALOR = Convert.ToSingle(dados["VALOR"].ToString());
                    livros.SITUACAO = Convert.ToInt32(dados["SITUACAO"].ToString());
                    LstLivros.Add(livros);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Livros");
            }
            finally
            {
                conexao.Close();
            }
            return LstLivros;
        }
        public List<MODEL.Livros> SelectTitulo(string TITULO)
        {
            List<MODEL.Livros> LstLivros = new List<MODEL.Livros>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM LIVROS WHERE (TITULO LIKE @TITULO) ; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@TITULO", "%" + TITULO.Trim() + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Livros livros = new MODEL.Livros();
                    livros.ID = Convert.ToInt32(dados["ID"].ToString());
                    livros.TITULO = dados["TITULO"].ToString();
                    livros.EDITORA = dados["EDITORA"].ToString();
                    livros.AUTOR = dados["AUTOR"].ToString();
                    livros.VALOR = Convert.ToSingle(dados["VALOR"].ToString());
                    livros.SITUACAO = Convert.ToInt32(dados["SITUACAO"].ToString());
                    LstLivros.Add(livros);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Livros");
            }
            finally
            {
                conexao.Close();
            }
            return LstLivros;
        }
        public void Inserir(MODEL.Livros livros)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " INSERT INTO LIVROS VALUES (@TITULO, @EDITORA, @AUTOR, @VALOR, @SITUACAO)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@TITULO", livros.TITULO);
            cmd.Parameters.AddWithValue("@EDITORA", livros.EDITORA);
            cmd.Parameters.AddWithValue("@AUTOR", livros.AUTOR);
            cmd.Parameters.AddWithValue("@VALOR", livros.VALOR);
            cmd.Parameters.AddWithValue("@SITUACAO", livros.SITUACAO);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na inserção de Livros...");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void UPDATE(MODEL.Livros livros)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE LIVROS SET @TITULO, @EDITORA, @AUTOR, @VALOR, @SITUACAO ";
            sql += " WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", livros.ID);
            cmd.Parameters.AddWithValue("@TITULO", livros.TITULO);
            cmd.Parameters.AddWithValue("@EDITORA", livros.EDITORA);
            cmd.Parameters.AddWithValue("@AUTOR", livros.AUTOR);
            cmd.Parameters.AddWithValue("@VALOR", livros.VALOR);
            cmd.Parameters.AddWithValue("@SITUACAO", livros.SITUACAO);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização do Livros...");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Delete(int IDLivros)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM LIVROS WHERE ID=@ID;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", IDLivros);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remoção do Livros...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
