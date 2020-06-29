using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace BIBLIOTECA.CAMADAS.DAL
{
    public class Clientes
    {
        private string strCon = Conexao.getConexao();
        public List<MODEL.Clientes> Select()
        {
            List<MODEL.Clientes> lstClientes = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM CLIENTES; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Clientes cliente = new MODEL.Clientes();
                    cliente.ID = Convert.ToInt32(dados["ID"].ToString());
                    cliente.NOME = dados["NOME"].ToString();
                    cliente.CURSO = dados["CURSO"].ToString();
                    cliente.DIAS = Convert.ToInt32(dados["DIAS"].ToString());
                    cliente.MULTA = Convert.ToSingle(dados["MULTA"].ToString());
                    lstClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Clientes");
            }
            finally
            {
                conexao.Close();
            }
            return lstClientes;
        }
        public List<MODEL.Clientes> SelectNome(string NOME)
        {
            List<MODEL.Clientes> lstClientes = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Clientes WHERE (NOME LIKE @NOME)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@NOME", "%" + NOME.Trim() + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Clientes cliente = new MODEL.Clientes();
                    cliente.ID = Convert.ToInt32(dados["ID"].ToString());
                    cliente.NOME = dados["NOME"].ToString();
                    cliente.CURSO = dados["CURSO"].ToString();
                    cliente.DIAS = Convert.ToInt32(dados["DIAS"].ToString());
                    cliente.MULTA = Convert.ToSingle(dados["MULTA"].ToString());
                    lstClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Clientes");
            }
            finally
            {
                conexao.Close();
            }
            return lstClientes;
        }
        public List<MODEL.Clientes> SelectbyID(int ID)
        {
            List<MODEL.Clientes> lstClientes = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM CLIENTES WHERE ID=@ID ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Clientes cliente = new MODEL.Clientes();
                    cliente.ID = Convert.ToInt32(dados["ID"].ToString());
                    cliente.NOME = dados["NOME"].ToString();
                    cliente.CURSO = dados["CURSO"].ToString();
                    cliente.DIAS = Convert.ToInt32(dados["DIAS"].ToString());
                    cliente.MULTA = Convert.ToSingle(dados["MULTA"].ToString());
                    lstClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Clientes");
            }
            finally
            {
                conexao.Close();
            }
            return lstClientes;
        }
        public MODEL.Clientes SelectID(int ID)
        {
            MODEL.Clientes cliente = new MODEL.Clientes();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM CLIENTES WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dados.Read())
                {
                    cliente.ID = Convert.ToInt32(dados["ID"].ToString());
                    cliente.NOME = dados["NOME"].ToString();
                    cliente.CURSO = dados["CURSO"].ToString();
                    cliente.DIAS = Convert.ToInt32(dados["DIAS"].ToString());
                    cliente.MULTA = Convert.ToSingle(dados["MULTA"].ToString());
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de Clientes por ID...");
            }
            finally
            {
                conexao.Close();
            }

            return cliente;
        }
        public void Inserir(MODEL.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " INSERT INTO CLIENTES VALUES (@NOME, @CURSO, @DIAS, @MULTA)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@NOME", cliente.NOME);
            cmd.Parameters.AddWithValue("@CURSO", cliente.CURSO);
            cmd.Parameters.AddWithValue("@DIAS", cliente.DIAS);
            cmd.Parameters.AddWithValue("@MULTA", cliente.MULTA);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na inserção de Clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void UPDATE(MODEL.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            //string sql = "UPDATE Clientes SET NOME=@NOME, CURSO=@CURSO, DIAS=@DIAS, MULTA=@MULTA WHERE ID=@ID";
            string sql = "UPDATE Clientes SET NOME=@NOME, CURSO=@CURSO, DIAS=@DIAS, MULTA=@MULTA ";
            sql += " WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", cliente.ID);
            cmd.Parameters.AddWithValue("@NOME", cliente.NOME);
            cmd.Parameters.AddWithValue("@CURSO", cliente.CURSO);
            cmd.Parameters.AddWithValue("@DIAS", cliente.DIAS);
            cmd.Parameters.AddWithValue("@MULTA", cliente.MULTA);


            try
            {
                 conexao.Open();
                 cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização do Clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Delete(int IDCliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Clientes WHERE ID=@ID;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", IDCliente);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro remoção de Clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
