using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Sistema_vendas.model;

namespace Sistema_vendas.controller
{
    public class produtoController
    {
        private MySqlConnection conexao;

        public produtoController()
        {
            this.conexao = new conn().GetConnection();  
        }

        public void cadastrarProduto(Produto obj)
        {
            try
            {
                string sql = @"insert into produto 
                                (nome,unidade_medida,marca,
                                cor,quantidade,valor_unitario,
                                idfornecedor) values 
                                (@nome,@unidade_medida,@marca,
                                @cor,@quantidade,@valor_unitario,
                                @idfornecedor);";

                MySqlCommand executacmd = new MySqlCommand(sql,conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@unidade_medida", obj.unidade_medida);
                executacmd.Parameters.AddWithValue("@marca", obj.marca);
                executacmd.Parameters.AddWithValue("@cor", obj.cor);
                executacmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
                executacmd.Parameters.AddWithValue("@valor_unitario", obj.valor_unitario);
                executacmd.Parameters.AddWithValue("@idfornecedor", obj.idfornecedor);


                
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Produto cadastrado com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
            
        }

        public DataTable listarProdutos()
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "select * from produto;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabela);

                conexao.Close();
                return tabela;
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
                return null;
            }

        }


        public DataTable buscaPorNome(string nome)
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "select * from produto where nome like @nome;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabela);

                conexao.Close();
                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
                return null;
            }

        }

        public void alterarProduto(Produto obj)
        {
            try
            {
                string sql = @"update produto set nome = @nome,
                                unidade_medida = @unidade_medida,
                                marca = @marca,
                                cor = @cor,
                                quantidade = @quantidade,
                                valor_unitario = @valor_unitario,
                                idfornecedor = @idfornecedor
                                where idproduto = @idproduto;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@unidade_medida", obj.unidade_medida);
                executacmd.Parameters.AddWithValue("@marca", obj.marca);
                executacmd.Parameters.AddWithValue("@cor", obj.cor);
                executacmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
                executacmd.Parameters.AddWithValue("@valor_unitario", obj.valor_unitario);
                executacmd.Parameters.AddWithValue("@idfornecedor", obj.idfornecedor);
                executacmd.Parameters.AddWithValue("@idproduto", obj.idproduto);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Produto alterado com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar: " + ex.Message);
            }

        }

        public void excluirProduto(Produto obj)
        {
            try
            {
                string sql = "delete from produto where idproduto = @idproduto;";

                MySqlCommand executacmd = new MySqlCommand(sql,conexao);
                executacmd.Parameters.AddWithValue("@idproduto", obj.idproduto);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Produto excluído com sucesso!");
                conexao.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Aconteceu um erro: " + ex.Message);
            }

        }

        public Produto buscaPorID(int id)
        {
            try
            {
                string sql =
                    "select * from produto where idproduto = @id";
                MySqlCommand executacmd =
                    new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);

                conexao.Open();

                MySqlDataReader resultado = executacmd.ExecuteReader();

                Produto p = new Produto();

                if (resultado.HasRows)
                {
                    while (resultado.Read())
                    {
                        p.idproduto = resultado.GetInt16("idproduto");
                        p.nome = resultado.GetString("nome");
                        p.quantidade = resultado.GetFloat("quantidade");
                        p.valor_unitario = resultado.GetFloat("valor_unitario");
                        p.marca = resultado.GetString("marca");
                        p.unidade_medida = resultado.GetString("unidade_medida");
                        p.cor = resultado.GetString("cor");
                        p.idfornecedor = resultado.GetInt16("idfornecedor");
                    }

                    resultado.Close();
                    conexao.Close();
                    return p;
                }
                else
                {
                    resultado.Close();
                    conexao.Close();
                    return null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
                return null;
            }
        }



    }
}
