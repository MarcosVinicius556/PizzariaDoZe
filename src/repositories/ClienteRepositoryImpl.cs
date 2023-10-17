using MySql.Data.MySqlClient;
using PizzariaDoZe.src.entities;
using PizzariaDoZe.src.repositories.@interface;
using PizzariaDoZe.src.repositories.singleton;
using PizzariaDoZe.src.services.factory;

namespace PizzariaDoZe.src.repositories
{
    /**
     * Esta interface herda tudo o que a repository já faz,
     * porém se precisar de algo muito específico,
     * o mesmo deverá ser criado aqui
     */
    internal class ClienteRepositoryImpl : ClienteRepository
    {
        public List<Cliente> FindAll(Cliente entity)
        {
            List<Cliente> list = new List<Cliente>();
            var conn = DatabaseConnectionSingleton.getConnection();
            MySqlCommand command;
            string? sqlFindAll = $"SELECT * FROM {entity.getName()} e";
            try
            {
                conn.Open();
                command = new MySqlCommand(sqlFindAll, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = (int)reader["id_cliente"];
                    cliente.NomeCliente = (string)reader["nome_cliente"];
                    cliente.Cpf = (string)reader["cpf"];
                    cliente.Telefone = (string)reader["telefone"];
                    cliente.Email = (string)reader["email"];
                    cliente.Numero = (int)reader["numero"];
                    cliente.Complemento = (string)reader["complemento"];

                    Endereco endereco = new Endereco();
                    endereco.Id = (int)reader["id_endereco"];
                    endereco = ServiceFactory.createEnderecoService().FindById(endereco);

                    cliente.Endereco = endereco;

                    list.Add(cliente);
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

        public Cliente FindById(Cliente entity)
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
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = (int)reader["id_cliente"];
                    cliente.NomeCliente = (string)reader["nome_cliente"];
                    cliente.Cpf = (string)reader["cpf"];
                    cliente.Telefone = (string)reader["telefone"];
                    cliente.Email = (string)reader["email"];
                    cliente.Numero = (int)reader["numero"];
                    cliente.Complemento = (string)reader["complemento"];

                    Endereco endereco = new Endereco();
                    endereco.Id = (int)reader["id_endereco"];
                    endereco = ServiceFactory.createEnderecoService().FindById(endereco);

                    cliente.Endereco = endereco;

                    entity = cliente;
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

        public void Save(Cliente entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();
            string SQLInsert = $"INSERT INTO {entity.getName()}({entity.getFields()}) VALUES('?')"; //TODO Implementar os campos quando for necessário

            try
            {
                conn.Open();
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
        public void Update(Cliente entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();
            string SQLUpdate = $"UPDATE {entity.getName()} SET nome = '?' WHERE id = {entity.getId()}";

            try
            {
                conn.Open();
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
