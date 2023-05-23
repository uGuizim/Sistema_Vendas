using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_vendas
{
    public class conn
    {
        public MySqlConnection GetConnection()
        {
            string conexao = "server=localhost; " +
                "user=root; password=Guilherme.e25; " +
                "database=sistema_vendas;";

            return new MySqlConnection(conexao);
        }
    }
}
