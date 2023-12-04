using MySql.Data.MySqlClient;
using PizzariaDoZe.src.entities;
using PizzariaDoZe.src.repositories.@interface;
using PizzariaDoZe.src.repositories.singleton;
using PizzariaDoZe.src.services.factory;
using System.Data;

namespace PizzariaDoZe.src.repositories
{
    /**
     * Esta interface herda tudo o que a repository já faz,
     * porém se precisar de algo muito específico,
     * o mesmo deverá ser criado aqui
     */
    internal class UfRepositoryImpl : UfRepository
    {
        public List<Uf> FindAll(Uf entity)
        {
            List<Uf> list = new List<Uf>();
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
                    Uf uf = new Uf();
                    uf.IdUf = (int)reader["id_uf"];
                    uf.NomeUf = (string)reader["nome_uf"];

                    int idPais = (int)reader["id_pais"];
                    Pais pais = new Pais();
                   /* pais.IdPais = idPais;
                    pais = ServiceFactory.createPaisService().FindById(pais); */

                    uf.Pais = pais;

                    list.Add(uf);
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

        public Uf FindById(Uf entity)
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
                    Uf uf = new Uf();
                    uf.IdUf = (int)reader["id_uf"];
                    uf.NomeUf = (string)reader["nome_uf"];

                    int idPais = (int)reader["id_pais"];
                    Pais pais = new Pais();
                    pais.IdPais = idPais;
                    pais = ServiceFactory.createPaisService().FindById(pais);

                    uf.Pais = pais;

                    entity = uf;
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

        public void Save(Uf entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();
            /**
             * id_uf, nome_uf, pais_id
             */
            string SQLInsert = $"INSERT INTO {entity.getName()}({entity.getFields()}) VALUES(" +
                $"{entity.IdUf}" +
                $", '{entity.NomeUf}'" +
                $", {(entity.Pais != null ? entity.Pais.IdPais : 0)}" +
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
        public void Update(Uf entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();
            string SQLUpdate = $"UPDATE {entity.getName()} SET nome_uf = {entity.NomeUf}," +
                $"pais_id = {entity.Pais.IdPais}" +
                $" WHERE id = {entity.getId()}";

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
