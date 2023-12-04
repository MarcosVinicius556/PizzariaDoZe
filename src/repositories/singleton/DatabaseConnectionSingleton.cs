using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.repositories.singleton
{
    /**
     * Instancia única do banco de dados
     */
    internal class DatabaseConnectionSingleton
    {
        private static MySqlConnection conn;

        public static MySqlConnection getConnection()
        {

            if(conn == null)
            {
                string server = "server=localhost;";
                string uid = "uid=root;";
                string pwd = "pwd=root;";
                string db = "database=pizzaria";
                string strConnection = server + uid + pwd + db;
                try
                {
                    conn = new MySqlConnection(strConnection);
                    conn.Open();
                    Console.WriteLine("Conexão com o banco de dados OK!");
                } catch(Exception e)
                {
                    MessageBox.Show("Erro ao se conecta ao banco de dados: " + e.Message);
                }
            }

            return conn;
        }
        
    }
}
