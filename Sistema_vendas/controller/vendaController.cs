using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Sistema_vendas.model;
using Sistema_vendas.view;

namespace Sistema_vendas.controller
{
    public class vendaController
    {
        private MySqlConnection conexao;

        public vendaController()
        {
            this.conexao = new conn().GetConnection();  
        }

        public void cadastrarVenda(Venda obj)
        {
            try
            {
                string sql = @"INSERT INTO venda
                                (idcliente,data_venda,valor_total,idusuario)
                                VALUES
                                (@idcliente,@data_venda,@valor_total,@idusuario);";

                MySqlCommand executacmd = new MySqlCommand(sql,conexao);

                executacmd.Parameters.AddWithValue("@idcliente", obj.idcliente);
                executacmd.Parameters.AddWithValue("@data_venda", obj.data_venda);
                executacmd.Parameters.AddWithValue("@valor_total", obj.valor_total);
                executacmd.Parameters.AddWithValue("@idusuario", obj.idusuario);

                conexao.Open();
                //Cadastra a venda
                executacmd.ExecuteNonQuery();


                //Busca o ID da venda cadastrada para adicionar aos produtos
                sql = "select MAX(idvenda) as idvenda from venda";
                executacmd = new MySqlCommand(sql, conexao);

                /*Execute Scalar retorna a primeira coluna da primeira linha,
                 Geralmente usado para buscar valores com os comandos MAX, MIN, COUNT que retornam apenas um valor
                 */
                int idvenda = (Int32)executacmd.ExecuteScalar();  //Converte o resultado do comendo em inteiro para armazenar na variável

                //Percorre todos os produtos da venda e adiciona no banco de dados
                foreach (VendaProduto produto in obj.produtos)
                {
                    
                    sql = @"INSERT INTO venda_produto
                                (idvenda,idproduto,quantidade,valor_unitario)
                                VALUES
                                (@idvenda,@idproduto,@quantidade,@valor_unitario);";

                    executacmd = new MySqlCommand(sql, conexao);

                    executacmd.Parameters.AddWithValue("@idvenda", idvenda);
                    executacmd.Parameters.AddWithValue("@idproduto", produto.idproduto);
                    executacmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
                    executacmd.Parameters.AddWithValue("@valor_unitario", produto.valor_unitario);

                    //Cadastra efetivamente o produto da venda no banco de dados
                    executacmd.ExecuteNonQuery();

                }


                MessageBox.Show("Venda cadastrada com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
            
        }

        public DataTable listarVendas()
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = @"SELECT A.idvenda,A.data_venda,A.idcliente,
                                B.nome,A.valor_total,A.idusuario
                                FROM venda A
                                INNER JOIN cliente B ON (B.idcliente = A.idcliente);";

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

        public DataTable listarItensVenda(int idvenda)
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = @"SELECT A.idproduto,B.nome,A.quantidade,
                                A.valor_unitario,(A.quantidade*A.valor_unitario) as subtotal 
                                FROM venda_produto A
                                INNER JOIN produto B ON (B.idproduto = A.idproduto) 
                                WHERE A.idvenda = @idvenda;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@idvenda", idvenda);

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
                string sql = @"SELECT A.idvenda,A.data_venda,A.idcliente,
                                B.nome,A.valor_total,A.idusuario
                                FROM venda A
                                INNER JOIN cliente B ON (B.idcliente = A.idcliente)
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

        public void alterarVenda(Venda obj)
        {
            try
            {
                //Passo 1: Altera a venda no BD
                string sql = @"UPDATE venda SET
                                    idcliente = @idcliente,
                                    data_venda = @data_venda,
                                    valor_total = @valor_total,
                                    idusuario = @idusuario
                                    WHERE idvenda = @idvenda;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@idcliente", obj.idcliente);
                executacmd.Parameters.AddWithValue("@data_venda", obj.data_venda);
                executacmd.Parameters.AddWithValue("@valor_total", obj.valor_total);
                executacmd.Parameters.AddWithValue("@idusuario", obj.idusuario);
                executacmd.Parameters.AddWithValue("@idvenda", obj.idvenda);

                conexao.Open();
                
                executacmd.ExecuteNonQuery();

                //Passo 2: Exclui os produtos já cadastrados na venda

                sql = "DELETE from venda_produto where idvenda = @idvenda";
                executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@idvenda", obj.idvenda);
                executacmd.ExecuteNonQuery();

                //Passo 3: Adiciona novamente todos os produtos atuais da venda
                //Percorre todos os produtos da venda e adiciona no banco de dados
                foreach (VendaProduto produto in obj.produtos)
                {

                    sql = @"INSERT INTO venda_produto
                                (idvenda,idproduto,quantidade,valor_unitario)
                                VALUES
                                (@idvenda,@idproduto,@quantidade,@valor_unitario);";

                    executacmd = new MySqlCommand(sql, conexao);

                    executacmd.Parameters.AddWithValue("@idvenda", obj.idvenda);
                    executacmd.Parameters.AddWithValue("@idproduto", produto.idproduto);
                    executacmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
                    executacmd.Parameters.AddWithValue("@valor_unitario", produto.valor_unitario);

                    //Cadastra efetivamente o produto da venda no banco de dados
                    executacmd.ExecuteNonQuery();

                }

                MessageBox.Show("Venda alterada com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar: " + ex.Message);
            }

        }

        public void excluirVenda(Venda obj)
        {
            try
            {
                //Passo 1 - Excluir inicialmente os itens da venda
                string sql = "DELETE from venda_produto where idvenda = @idvenda";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@idvenda", obj.idvenda);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //Passo 2 - Excluir os dados da venda
                sql = "DELETE from venda where idvenda = @idvenda;";
                executacmd = new MySqlCommand(sql,conexao);
                executacmd.Parameters.AddWithValue("@idvenda", obj.idvenda);

                executacmd.ExecuteNonQuery();
                MessageBox.Show("Venda excluída com sucesso!");
                conexao.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Aconteceu um erro: " + ex.Message);
            }

        }


    }
}
