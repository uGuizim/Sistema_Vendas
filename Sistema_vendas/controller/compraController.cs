using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sistema_vendas;
using Sistema_vendas.model;
using Sistema_vendas.view;


namespace Sistema_compras.controller
{

    public class compraController
    {
        private MySqlConnection conexao;

        public compraController()
        {
            this.conexao = new conn().GetConnection();
        }

        public void cadastrarCompra(Compra obj)
        {
            try
            {
                string sql = @"INSERT INTO compra
                                (idfornecedor,data_compra,valor_total,idusuario)
                                VALUES
                                (@idfornecedor,@data_compra,@valor_total,@idusuario);";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@idfornecedor", obj.idfornecedor);
                executacmd.Parameters.AddWithValue("@data_compra", obj.data_compra);
                executacmd.Parameters.AddWithValue("@valor_total", obj.valor_total);
                executacmd.Parameters.AddWithValue("@idusuario", obj.idusuario);

                conexao.Open();
                //Cadastra a compra
                executacmd.ExecuteNonQuery();

                //Busca o ID da comprastrada para adicionar aos produtos
                sql = "select MAX(idcompra) as idcompra from compra";
                executacmd = new MySqlCommand(sql, conexao);

                /*Execute Scalar retorna a primeira coluna da primeira linha,
                 Geralmente usado para buscar valores com os comandos MAX, MIN, COUNT que retornam apenas um valor
                 */
                int idcompra = (Int32)executacmd.ExecuteScalar();  //Converte o resultado do comendo em inteiro para armazenar na variável

                //Percorre todos os produtos da venda e adiciona no banco de dados
                foreach (CompraProduto produto in obj.produtos)
                {

                    sql = @"INSERT INTO compra_produto
                                (idcompra,idproduto,quantidade,valor_unitario)
                                VALUES
                                (@idcompra,@idproduto,@quantidade,@valor_unitario);";

                    executacmd = new MySqlCommand(sql, conexao);

                    executacmd.Parameters.AddWithValue("@idcompra", idcompra);
                    executacmd.Parameters.AddWithValue("@idproduto", produto.idproduto);
                    executacmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
                    executacmd.Parameters.AddWithValue("@valor_unitario", produto.valor_unitario);

                    //Cadastra efetivamente o produto da venda no banco de dados
                    executacmd.ExecuteNonQuery();

                }


                MessageBox.Show("Compra cadastrada com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }

        }

        public DataTable listarCompras()
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = @"SELECT A.idcompra,A.data_compra,A.idfornecedor,
                                B.nome,A.valor_total,A.idusuario
                                FROM compra A
                                INNER JOIN fornecedor B ON (B.idfornecedor = A.idcliente);";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
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

        public DataTable listarItensCompra(int idcompra)
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = @"SELECT A.idproduto,B.nome,A.quantidade,
                                A.valor_unitario,(A.quantidade*A.valor_unitario) as subtotal 
                                FROM compra_produto A
                                INNER JOIN produto B ON (B.idproduto = A.idproduto) 
                                WHERE A.idcompra = @idcompra;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@idcompra", idcompra);

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


        public DataTable buscaPorNome(string nome)
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = @"SELECT A.idcompra,A.data_compra,A.idfornecedor,
                                B.nome,A.valor_total,A.idusuario
                                FROM compra A
                                INNER JOIN fornecedor B ON (B.idfornecedor = A.idfornecedor)
                                where B.nome like @nome;";

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

        public void alterarCompra(Compra obj)
        {
            try
            {
                //Passo 1: Altera a compra no BD
                string sql = @"UPDATE venda SET
                                    idfornecedor = @idfornecedor,
                                    data_compra = @data_compra,
                                    valor_total = @valor_total,
                                    idusuario = @idusuario
                                    WHERE idcompra = @idcompra;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@idfornecedor", obj.idfornecedor);
                executacmd.Parameters.AddWithValue("@data_compra", obj.data_compra);
                executacmd.Parameters.AddWithValue("@valor_total", obj.valor_total);
                executacmd.Parameters.AddWithValue("@idusuario", obj.idusuario);
                executacmd.Parameters.AddWithValue("@idcompra", obj.idcompra);

                conexao.Open();

                executacmd.ExecuteNonQuery();

                //Passo 2: Exclui os produtos já cadastrados na venda

                sql = "DELETE from compra_produto where idcompra = @idcompra";
                executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@idvenda", obj.idcompra);
                executacmd.ExecuteNonQuery();

                //Passo 3: Adiciona novamente todos os produtos atuais da venda
                //Percorre todos os produtos da venda e adiciona no banco de dados
                foreach (CompraProduto produto in obj.produtos)
                {

                    sql = @"INSERT INTO compra_produto
                                (idcompra,idproduto,quantidade,valor_unitario)
                                VALUES
                                (@idcompra,@idproduto,@quantidade,@valor_unitario);";

                    executacmd = new MySqlCommand(sql, conexao);

                    executacmd.Parameters.AddWithValue("@idvenda", obj.idcompra);
                    executacmd.Parameters.AddWithValue("@idproduto", produto.idproduto);
                    executacmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
                    executacmd.Parameters.AddWithValue("@valor_unitario", produto.valor_unitario);

                    //Cadastra efetivamente o produto da venda no banco de dados
                    executacmd.ExecuteNonQuery();

                }

                MessageBox.Show("Compra alterada com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar: " + ex.Message);
            }

        }

        public void excluirCompra(Compra obj)
        {
            try
            {
                //Passo 1 - Excluir inicialmente os itens da compra
                string sql = "DELETE from compra_produto where idcompra = @idcompra";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@idcompra", obj.idcompra);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Passo 2 - Excluir os dados da compra
                sql = "DELETE from compra where idcompra = @idcompra;";
                executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@idcompra", obj.idcompra);

                executacmd.ExecuteNonQuery();
                MessageBox.Show("Compra excluída com sucesso!");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu um erro: " + ex.Message);
            }

        }
    } }