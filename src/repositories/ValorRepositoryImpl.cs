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
    internal class ValorRepositoryImpl : ValorRepository
    {
        public List<Valor> FindAll(Valor entity)
        {
            List<Valor> list = new List<Valor>();
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
                    Valor valor = new Valor();
                    valor.Id = (int)reader["id"];
                    valor.Tamanho = (char)reader["tamanho"];
                    valor.Categoria = (char)reader["categoria"];
                    valor.ValorPizza = (Decimal)reader["valor"];
                    valor.ValorBorda = (Decimal)reader["valor_borda"];

                    list.Add(valor);
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

        public Valor FindById(Valor entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();
            string? sqlFindById = $"SELECT * FROM {entity.getName()} e WHERE {entity.idField()} = {entity.getId()}";
            try
            {
                conn.Open() ;
                command = new MySqlCommand(sqlFindById, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Valor valor = new Valor();

                    valor.Id = (int)reader["id"];
                    valor.Tamanho = (char)reader["tamanho"];
                    valor.Categoria = (char)reader["categoria"];
                    valor.ValorPizza = (Decimal)reader["valor"];
                    valor.ValorBorda = (Decimal)reader["valor_borda"];

                    entity = valor;
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

        public void Save(Valor entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();
            /**
             * id, tamanho, categoria, valor, valor_borda
             */
            string SQLInsert = $"INSERT INTO {entity.getName()}({entity.getFields()}) VALUES(" +
                $"{entity.Id}" +
                $", '{entity.Tamanho}'" +
                $", '{entity.Categoria}'" +
                $", '{entity.ValorPizza}'" +
                $", '{entity.ValorBorda}'" +
                $")";

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
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
        public void Update(Valor entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();
            string SQLUpdate = $"UPDATE {entity.getName()} SET nome = '?' WHERE id = {entity.getId()}";

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
