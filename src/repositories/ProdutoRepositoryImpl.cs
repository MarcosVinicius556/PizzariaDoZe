using MySql.Data.MySqlClient;
using PizzariaDoZe.src.entities;
using PizzariaDoZe.src.repositories.@interface;
using PizzariaDoZe.src.repositories.singleton;
using System.Data;

namespace PizzariaDoZe.src.repositories
{
    /**
     * Esta interface herda tudo o que a repository já faz,
     * porém se precisar de algo muito específico,
     * o mesmo deverá ser criado aqui
     */
    internal class ProdutoRepositoryImpl : ProdutoRepository
    {
        public List<Produto> FindAll(Produto entity)
        {
            List<Produto> list = new List<Produto>();
            var conn = DatabaseConnectionSingleton.getConnection();
            MySqlCommand command;
            string? sqlFindAll = $"SELECT * FROM {entity.getName()} e";
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command = new MySqlCommand(sqlFindAll, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Produto prod = new Produto();
                    prod.IdProduto = (int)reader["id_produto"];
                    prod.DescricaoProduto = (string)reader["descricao_produto"];
                    prod.Valor = (Decimal)reader["valor"];
                    prod.Tipo = (char)reader["tipo"];
                    prod.MedidaUnitaria = (string)reader["medida_unitaria"];

                    list.Add(prod);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao buscar os registros no banco! " + e.Message);
            } finally
            {
                conn.Close();
            }

            return list;
        }

        public Produto FindById(Produto entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();
            string? sqlFindById = $"SELECT * FROM {entity.getName()} e WHERE {entity.idField()} = {entity.getId()}";
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command = new MySqlCommand(sqlFindById, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Produto prod = new Produto();
                    prod.IdProduto = (int)reader["id_produto"];
                    prod.DescricaoProduto = (string)reader["descricao_produto"];
                    prod.Valor = (Decimal)reader["valor"];
                    prod.Tipo = (char)reader["tipo"];
                    prod.MedidaUnitaria = (string)reader["medida_unitaria"];

                    entity = prod;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao buscar o registro no banco! " + e.Message);
            } finally
            {
                conn.Close();
            }

            return entity;
        }

        public void Save(Produto entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();
            /**
             * id_produto, descricao_produto, valor, tipo, medida_unitaria
             **/
            string SQLInsert = $"INSERT INTO {entity.getName()}({entity.getFields()}) VALUES(" +
                $"{entity.IdProduto}" +
                $", '{entity.DescricaoProduto}'" +
                $",  {entity.Valor}" +
                $", '{entity.Tipo}'" +
                $", '{entity.MedidaUnitaria}'" +
                $")";

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            try
            {

                command = new MySqlCommand(SQLInsert, conn);
                command.ExecuteReader();

            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao inserir o registro no banco! " + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void Update(Produto entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();
            string SQLUpdate = $"UPDATE {entity.getName()} SET descricao_produto = {entity.getDescricao}," +
                $"valor = {entity.getValor}," +
                $"tipo = {entity.getTipo}," +
                $"medida_unitaria = {entity.getMedidaUnitaria}" +
                $" WHERE id_produto = {entity.getId()}";

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command = new MySqlCommand(SQLUpdate, conn);
                command.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o registro no banco! " + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
