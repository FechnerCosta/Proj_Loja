using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Loja.Modelos;

namespace Loja.DAL
{
    public class VendasDAL
    {
        public DataTable ListaDeProdutos
        {
            get
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = Dados.StringDeConexao;
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Produtos", cn);

                DataTable dt = new DataTable();

                da.Fill(dt);
                cn.Close();
                return dt;

            }
        }

        public DataTable ListaDeClientes
        {
            get
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = Dados.StringDeConexao;
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM clientes", cn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
                  
            }
        }

        static public ProdutoInformation getWithId(int id)
        {
            ProdutoInformation obj = new ProdutoInformation();

            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = Dados.StringDeConexao;
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Produtos WHERE codigo = " + id, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                obj.Codigo = Convert.ToInt32(dt.Rows[0]["codigo"]);
                obj.Nome = Convert.ToString(dt.Rows[0]["nome"]);
                obj.Preco = Convert.ToDecimal(dt.Rows[0]["preco"]);
                cn.Close();        
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro no servidor: " + ex.Message);
            }
            return obj;
        }

        public DataTable Listagem(string filtro)
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;

                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "seleciona_vendas";
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter pfiltro;
                pfiltro = da.SelectCommand.Parameters.Add("@filtro", SqlDbType.Text);
                pfiltro.Value = filtro;

                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Incluir (VendaInformation venda)
        {
            SqlConnection cn = new SqlConnection();
            SqlTransaction t = null;
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;

                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = cn;
                cmd1.CommandText = @"INSERT INTO vendas (CodigoCliente, codigoProduto , Data, Quantidade,Faturado)
                                                          VALUES (@CodigoCliente, @CodigoProduto, @Data, @Quantidade, @Faturado); select @@IDENTITY;";
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = cn;
                cmd2.CommandText = @"UPDATE Produtos SET Estoque = Estoque - @Quantidade WHERE Codigo = @CodigoProduto";

                cn.Open();

                t = cn.BeginTransaction(IsolationLevel.Serializable);

                cmd1.Transaction = t;
                cmd2.Transaction = t;

                cmd1.Parameters.AddWithValue("@codigocliente", venda.CodigoCliente);
                cmd1.Parameters.AddWithValue("@codigoproduto", venda.CodigoProduto);
                cmd1.Parameters.AddWithValue("@data", venda.Data);
                cmd1.Parameters.AddWithValue("@quantidade", venda.Quantidade);
                cmd1.Parameters.AddWithValue("@faturado", venda.Faturado);

                cmd2.Parameters.AddWithValue("@quantidade", venda.Quantidade);
                cmd2.Parameters.AddWithValue("@codigoproduto", venda.CodigoProduto);

                venda.Codigo = Convert.ToInt32(cmd1.ExecuteScalar());
                cmd2.ExecuteNonQuery();

                t.Commit();
                                                                     
            }
            catch (Exception ex)
            {
                t.Rollback();
                throw new Exception("Erro no Servidor: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int codigo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "exclui_venda";

                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Value = codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("nao foi possivel exluir a venda" + codigo);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("servidor SQL Erro: " + ex.Number);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
