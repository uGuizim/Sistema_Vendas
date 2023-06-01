using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Sistema_vendas.model;

namespace Sistema_vendas.controller
{
    public class usuarioController
    {
        private MySqlConnection conexao;

        public usuarioController()
        {
            this.conexao = new conn().GetConnection();  
        }

        public void cadastrarUsuario(Usuario obj)
        {
            try
            {
                string sql = @"insert into usuario 
                                (nome,login,telefone,
                                senha) values 
                                (@nome,@login,@telefone,
                                @senha);";

                MySqlCommand executacmd = new MySqlCommand(sql,conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@login", obj.login);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
            
        }

        public DataTable listarUsuarios()
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "select * from usuario;";

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
                string sql = "select * from usuario where nome like @nome;";

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

        public void alterarUsuario(Usuario obj)
        {
            try
            {
                string sql = @"update usuario set nome = @nome,
                                login = @login,
                                telefone = @telefone,
                                senha = @senha
                                where idusuario = @idusuario;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@login", obj.login);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@idusuario", obj.idusuario);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Usuário alterado com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar: " + ex.Message);
            }

        }

        public void excluirUsuario(Usuario obj)
        {
            try
            {
                string sql = "delete from usuario where idusuario = @idusuario;";

                MySqlCommand executacmd = new MySqlCommand(sql,conexao);
                executacmd.Parameters.AddWithValue("@idusuario", obj.idusuario);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Usuário excluído com sucesso!");
                conexao.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Aconteceu um erro: " + ex.Message);
            }

        }


    }
}
