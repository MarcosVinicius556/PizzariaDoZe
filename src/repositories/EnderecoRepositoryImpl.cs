using MySql.Data.MySqlClient;
using PizzariaDoZe.src.entities;
using PizzariaDoZe.src.entities.@interface;
using PizzariaDoZe.src.repositories.@interface;
using PizzariaDoZe.src.repositories.singleton;
using PizzariaDoZe.src.services.factory;
using System.Data.Common;
using System.Data;
using System.Runtime.ConstrainedExecution;

namespace PizzariaDoZe.src.repositories
{
    /**
     * Esta interface herda tudo o que a repository já faz,
     * porém se precisar de algo muito específico,
     * o mesmo deverá ser criado aqui
     */
    internal class EnderecoRepositoryImpl : EnderecoRepository
    {
        public List<Endereco> FindAll(Endereco entity)
        {
            List<Endereco> list = new List<Endereco>();
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

                    Endereco endereco = new Endereco();
                    endereco.Id = (int)reader["id_endereco"];
                    endereco.Cep = (string)reader["cep"];
                    endereco.Logradouro = (string)reader["logradouro"];
                    endereco.Bairro = (string)reader["bairro"];

                    /* Busca os dados da cidade do endereco */
                    int idCidade = (int)reader["cidade_id"];
                    Cidade cidade = new Cidade();
                    /*cidade.IdCidade = idCidade;
                    cidade = ServiceFactory.createCidadeService().FindById(cidade);*/

                    endereco.Cidade = cidade;

                    list.Add(endereco);
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

        public Endereco findByCEP(string cep)
        {
            MySqlCommand command;
            Endereco entity = new Endereco();
            var conn = DatabaseConnectionSingleton.getConnection();
            DbTransaction transaction = null;
            string? sqlFindById = $"SELECT * FROM {entity.getName()} e WHERE e.cep = '{cep}'";
            try
            {

                transaction = conn.BeginTransaction();
                command = new MySqlCommand(sqlFindById, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    entity.Id = (int)reader["id_endereco"];
                    entity.Cep = (string)reader["cep"];
                    entity.Logradouro = (string)reader["logradouro"];
                    entity.Bairro = (string)reader["bairro"];

                    /* Busca os dados da cidade do endereco */
                    int idCidade = (int)reader["cidade_id"];
                    Cidade cidade = new Cidade();
                    cidade.IdCidade = idCidade;
                    //cidade  = ServiceFactory.createCidadeService().FindById(cidade);

                    entity.Cidade = cidade;

                }

                transaction.Commit();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao buscar o registro no banco! " + e.Message);
                transaction.Rollback(); 
            }

            return entity;
        }

        public Endereco FindById(Endereco entity)
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
                    entity.Id = (int)reader["id"];
                    entity.Cep = (string)reader["cep"];
                    entity.Logradouro = (string)reader["logradouro"];
                    entity.Bairro = (string)reader["bairro"];

                    /* Busca os dados da cidade do endereco */
                    int idCidade = (int)reader["id_cidade"];
                    Cidade cidade = new Cidade();
                    cidade.IdCidade = idCidade;
                    cidade = ServiceFactory.createCidadeService().FindById(cidade);

                    entity.Cidade = cidade;
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

        public void Save(Endereco entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection(); //id, cep, logradouro, bairro, id_cidade
            string SQLInsert = $"INSERT INTO {entity.getName()}({entity.getFields()}) VALUES(" +
                $"{entity.Id}" +
                $", '{entity.Cep}'" +
                $", '{entity.Logradouro}'" +
                $", '{entity.Bairro}'" +
                $", {(entity.Cidade != null ? entity.Cidade.IdCidade : 0)}" +
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
        public void Update(Endereco entity)
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
