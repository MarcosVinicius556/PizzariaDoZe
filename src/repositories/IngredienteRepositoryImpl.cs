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
    internal class IngredienteRepositoryImpl : IngredienteRepository
    {
        public List<Ingrediente> FindAll(Ingrediente entity)
        {
            List<Ingrediente> ingredientes = new List<Ingrediente>();
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
                    long id = (long) reader["id"];
                    string nome = (string) reader["nome"];

                    entity = new Ingrediente(id, nome);
                    ingredientes.Add(entity);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao buscar os ingredientes no banco! " + e.Message);
            } finally
            {
                conn.Close();
            }

            return ingredientes;
        }

        public Ingrediente FindById(Ingrediente entity)
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
                    long id = (long) reader["id"];
                    string nome = (string) reader["nome"];

                    entity = new Ingrediente(id, nome);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao buscar o ingrediente no banco! " + e.Message);
            } finally
            {
                conn.Close();
            }

            return entity;
        }

        public void Save(Ingrediente entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();
            string SQLInsert = $"INSERT INTO ingredientes(nome) VALUES('{entity.Nome}')";

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
                MessageBox.Show("Ocorreu um erro ao buscar o ingrediente no banco! " + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void Update(Ingrediente entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();
            string SQLUpdate = $"UPDATE ingredientes SET nome = '{entity.Nome}' WHERE id = {entity.getId()}";

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
                MessageBox.Show("Ocorreu um erro ao buscar o ingrediente no banco! " + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
