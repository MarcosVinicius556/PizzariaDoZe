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
    internal class SaborRepositoryImpl : SaborRepository
    {
        public List<Sabor> FindAll(Sabor entity)
        {
            List<Sabor> list = new List<Sabor>();
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
                    Sabor sabor = new Sabor();
                    sabor.IdSabor = (int)reader["id_sabor"];
                    sabor.DescricaoSabor = (string)reader["descricao_sabor"];
                    sabor.Foto = (Bitmap)reader["foto"];
                    sabor.Categoria = (char)reader["categoria"];
                    sabor.Tipo = (char)reader["tipo"];

                    list.Add(sabor);
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

        public Sabor FindById(Sabor entity)
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
                    Sabor sabor = new Sabor();

                    sabor.IdSabor = (int)reader["id_sabor"];
                    sabor.DescricaoSabor = (string)reader["descricao_sabor"];
                    sabor.Foto = (Bitmap)reader["foto"];
                    sabor.Categoria = (char)reader["categoria"];
                    sabor.Tipo = (char)reader["tipo"];

                    entity = sabor;
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

        public void Save(Sabor entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();
            /*
             * id_sabor, descricao_sabor, foto, categoria, tipo
             */
            string SQLInsert = $"INSERT INTO {entity.getName()}({entity.getFields()}) VALUES(" +
                $"{entity.IdSabor}" +
                $", '{entity.DescricaoSabor}'" +
                $", '{entity.Foto}'" +
                $", '{entity.Categoria}'" +
                $", '{entity.Tipo}'" +
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
        public void Update(Sabor entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();
            string SQLUpdate = $"UPDATE {entity.getName()} SET descricao_sabor = {entity.DescricaoSabor}, " +
                               $"categoria = {entity.Categoria}, " +
                               $"tipo = {entity.Tipo} " +
                               $"WHERE id = {entity.getId()}";

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
