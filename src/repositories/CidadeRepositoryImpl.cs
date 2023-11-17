using MySql.Data.MySqlClient;
using PizzariaDoZe.src.entities;
using PizzariaDoZe.src.repositories.@interface;
using PizzariaDoZe.src.repositories.singleton;
using PizzariaDoZe.src.services.factory;
using System.Data.Common;
using System.Data;

namespace PizzariaDoZe.src.repositories
{
    /**
     * Esta interface herda tudo o que a repository já faz,
     * porém se precisar de algo muito específico,
     * o mesmo deverá ser criado aqui
     */
    internal class CidadeRepositoryImpl : CidadeRepository
    {
        public List<Cidade> FindAll(Cidade entity)
        {
            List<Cidade> list = new List<Cidade>();
            var conn = DatabaseConnectionSingleton.getConnection();
            MySqlCommand command;
            DbTransaction transaction = null;
            string? sqlFindAll = $"SELECT * FROM {entity.getName()} e";
            try
            {
                transaction = conn.BeginTransaction();
                command = new MySqlCommand(sqlFindAll, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cidade cidade = new Cidade();
                    cidade.IdCidade = (int)reader["id_cidade"];
                    cidade.NomeCidade = (string)reader["nome_cidade"];

                    int idUf = (int)reader["id_uf"];
                    Uf uf = new Uf();
                    uf.IdUf = idUf;
                    /*uf = ServiceFactory.createUfService().FindById(uf); */
                    cidade.Uf = uf;

                    list.Add(cidade);
                }
                transaction.Commit();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao buscar os registros no banco! " + e.Message);
                transaction.Rollback();
            } finally
            {
                conn.Close();
            }

            return list;
        }

        public Cidade FindById(Cidade entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();
            DbTransaction transaction = null;
            string? sqlFindById = $"SELECT * FROM {entity.getName()} e WHERE {entity.idField()} = {entity.getId()}";
            try
            {
                transaction = conn.BeginTransaction();
                command = new MySqlCommand(sqlFindById, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    entity.IdCidade = (int)reader["id_cidade"];
                    entity.NomeCidade = (string)reader["nome_cidade"];
                    int idUf = (int)reader["id_uf"];
                    Uf uf = new Uf();
                    uf.IdUf = idUf;
                    uf = ServiceFactory.createUfService().FindById(uf);
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

        public void Save(Cidade entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();                   //id,                       nome_cidade,          uf_id
            string SQLInsert = $"INSERT INTO {entity.getName()}({entity.getFields()}) VALUES({entity.IdCidade}, '{entity.NomeCidade}', {(entity.Uf != null ? entity.Uf.IdUf : 0)})";
            DbTransaction transaction = null;
            try
            {
                transaction = conn.BeginTransaction();
                command = new MySqlCommand(SQLInsert, conn);
                command.ExecuteReader();
                transaction.Commit();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao inserir o registro no banco! " + e.Message);
                transaction.Rollback();
            }
            finally
            {
                conn.Close();
            }
        }
        public void Update(Cidade entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();
            string SQLUpdate = $"UPDATE {entity.getName()} SET ? = '?' WHERE id = {entity.getId()}";

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
