using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA.CAMADAS.DAL
{
    public class Itens
    {
        private string strCon = Conexao.getConexao();
        public List<MODEL.Itens> Select()
        {
            List<MODEL.Itens> LstItens = new List<MODEL.Itens>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM ITENS ; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Itens itens = new MODEL.Itens();
                    itens.ID = Convert.ToInt32(dados["ID"].ToString());
                    itens.EMPRESTIMO_ID = Convert.ToInt32(dados["EMPRESTIMO_ID"].ToString());
                    itens.LIVRO_ID = Convert.ToInt32(dados["LIVRO_ID"].ToString());
                    itens.ENTREGA = Convert.ToDateTime(value: dados["ENTREGA"].ToString());
                    /*recuperar nome do livro
                    CAMADAS.BLL.Livros bllLivro = new BLL.Livros();
                    List<MODEL.Livros> listaLivro = bllLivro.SelectByID(item.livroID);
                    item.titulo = listaLivro[0].titulo;*/
                    LstItens.Add(itens);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Itens");
            }
            finally
            {
                conexao.Close();
            }
            return LstItens;
        }
        public List<MODEL.Itens> SelectByEmp(int ID)
        {
            List<MODEL.Itens> lstItens = new List<MODEL.Itens>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM ITENS WHERE emprestimo ID=@ID;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    //preencher com dados do item
                    CAMADAS.MODEL.Itens item = new MODEL.Itens();
                    item.ID = Convert.ToInt32(dados["ID"].ToString());
                    item.EMPRESTIMO_ID = Convert.ToInt32(dados["EMPRESTIMO_ID"].ToString());
                    item.LIVRO_ID = Convert.ToInt32(dados["LIVRO_ID"].ToString());
                    item.ENTREGA = Convert.ToDateTime(dados["ENTREGA"].ToString());

                    //recuperar nome do livro
                   // CAMADAS.BLL.Livros bllLivro = new BLL.Livros();
                    //CAMADAS.DAL.Livros DalLivros = new CAMADAS.DAL.Livros();
                   // List<MODEL.Livros> listaLivro = bllLivro.SelectID(item.LIVRO_ID);
                    // .titulo = listaLivro[0].TITULO;

                    lstItens.Add(item);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Itens...");
            }
            finally
            {
                conexao.Close();
            }

            return lstItens;
        }
        public void Inserir(MODEL.Itens itens)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " INSERT INTO ITENS VALUES (@ENTREGA)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@EMPRESTIMO_ID", itens.EMPRESTIMO_ID);
            cmd.Parameters.AddWithValue("@LIVRO_ID", itens.LIVRO_ID);
            cmd.Parameters.AddWithValue("@ENTREGA", itens.ENTREGA);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na inserção de itens...");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void UPDATE(MODEL.Itens itens)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE ITENS SET emprestimo ID=@EMPRESTIMO_ID, LIVRO_ID=@LIVRO_ID, ENTREGA=@ENTREGA  ";
            sql += " WHERE id=@id";

            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", itens.ID);
            cmd.Parameters.AddWithValue("@EMPRESTIMO_ID", itens.EMPRESTIMO_ID);
            cmd.Parameters.AddWithValue("@LIVRO_ID",itens.LIVRO_ID);
            cmd.Parameters.AddWithValue("@ENTREGA", itens.ENTREGA);


            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Itens...");
            }
            finally
            {
                conexao.Close();
            }

        }
        public void Delete(int ID)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM ITENS WHERE ID=@ID;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro remoção de Itens...");
            }
            finally
            {
                conexao.Close();
            }
        }


    }
}

