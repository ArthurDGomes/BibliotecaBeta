using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.DAL
{
    public class Revista
    {
        
            private string strCon = Conexao.getConexao();
            public List<MODEL.Revista> Select()
            {
                List<MODEL.Revista> LstRevista = new List<MODEL.Revista>();
                SqlConnection conexao = new SqlConnection(strCon);
                string sql = "SELECT * FROM REVISTA ";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                try
                {
                    conexao.Open();
                    SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dados.Read())
                    {
                        MODEL.Revista revista = new MODEL.Revista();
                        revista.ID = Convert.ToInt32(dados["ID"].ToString());
                        revista.TITULO = dados["TITULO"].ToString();
                        revista.EDITORA = dados["EDITORA"].ToString();
                        revista.VALOR = Convert.ToSingle(dados["VALOR"].ToString());
                        revista.SITUACAO = Convert.ToInt32(dados["SITUACAO"].ToString());
                        LstRevista.Add(revista);
                    }
                }
                catch
                {
                    Console.WriteLine("Deu erro na consulta de Revistas");
                }
                finally
                {
                    conexao.Close();
                }
                return LstRevista;
            }
            public List<MODEL.Revista> SelectID(int ID)
            {
                List<MODEL.Revista> LstRevista = new List<MODEL.Revista>();
                SqlConnection conexao = new SqlConnection(strCon);
                string sql = "SELECT * FROM REVISTA WHERE ID=@ID; ";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@ID", ID);
                try
                {
                    conexao.Open();
                    SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dados.Read())
                    {
                        MODEL.Revista revista = new MODEL.Revista();
                        revista.ID = Convert.ToInt32(dados["ID"].ToString());
                        revista.TITULO = dados["TITULO"].ToString();
                        revista.EDITORA = dados["EDITORA"].ToString();
                        revista.VALOR = Convert.ToSingle(dados["VALOR"].ToString());
                        revista.SITUACAO = Convert.ToInt32(dados["SITUACAO"].ToString());
                        LstRevista.Add(revista);
                }
                }
                catch
                {
                    Console.WriteLine("Deu erro na consulta de Revista");
                }
                finally
                {
                    conexao.Close();
                }
                return LstRevista;
            }
            public List<MODEL.Revista> SelectTitulo(string TITULO)
            {
                List<MODEL.Revista> LstRevista = new List<MODEL.Revista>();
                SqlConnection conexao = new SqlConnection(strCon);
                string sql = "SELECT * FROM REVISTA WHERE (TITULO LIKE @TITULO) ; ";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@TITULO", "%" + TITULO.Trim() + "%");
                try
                {
                    conexao.Open();
                    SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dados.Read())
                    {
                        MODEL.Revista revista = new MODEL.Revista();
                        revista.ID = Convert.ToInt32(dados["ID"].ToString());
                        revista.TITULO = dados["TITULO"].ToString();
                        revista.EDITORA = dados["EDITORA"].ToString();
                        revista.VALOR = Convert.ToSingle(dados["VALOR"].ToString());
                        revista.SITUACAO = Convert.ToInt32(dados["SITUACAO"].ToString());
                        LstRevista.Add(revista);
                }
                }
                catch
                {
                    Console.WriteLine("Deu erro na consulta de Revista");
                }
                finally
                {
                    conexao.Close();
                }
                return LstRevista;
            }
            public void Inserir(MODEL.Revista revista)
            {
                SqlConnection conexao = new SqlConnection(strCon);
                string sql = " INSERT INTO REVISTA VALUES (@TITULO, @EDITORA, @VALOR, @SITUACAO)";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@TITULO", revista.TITULO);
                cmd.Parameters.AddWithValue("@EDITORA", revista.EDITORA);
                cmd.Parameters.AddWithValue("@VALOR", revista.VALOR);
                cmd.Parameters.AddWithValue("@SITUACAO", revista.SITUACAO);
                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();

                }
                catch
                {
                    Console.WriteLine("Erro na inserção de Revista...");
                }
                finally
                {
                    conexao.Close();
                }
            }
            public void UPDATE(MODEL.Revista revista)
            {
                SqlConnection conexao = new SqlConnection(strCon);
                string sql = "UPDATE REVISTA SET @TITULO, @EDITORA, @VALOR, @SITUACAO ";
                sql += " WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@ID", revista.ID);
                cmd.Parameters.AddWithValue("@TITULO", revista.TITULO);
                cmd.Parameters.AddWithValue("@EDITORA", revista.EDITORA);
                cmd.Parameters.AddWithValue("@VALOR", revista.VALOR);
                cmd.Parameters.AddWithValue("@SITUACAO", revista.SITUACAO);

                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("Erro na atualização do Revista...");
                }
                finally
                {
                    conexao.Close();
                }
            }
            public void Delete(int IDRevista)
            {
                SqlConnection conexao = new SqlConnection(strCon);
                string sql = "DELETE FROM REVISTA WHERE ID=@ID;";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@ID", IDRevista);
                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("Erro na remoção do Revista...");
                }
                finally
                {
                    conexao.Close();
                }
            }
    }
}

