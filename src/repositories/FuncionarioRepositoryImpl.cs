using MySql.Data.MySqlClient;
using PizzariaDoZe.src.entities;
using PizzariaDoZe.src.repositories.@interface;
using PizzariaDoZe.src.repositories.singleton;
using PizzariaDoZe.src.services.factory;
using System;
using System.Data;

namespace PizzariaDoZe.src.repositories
{
    //PARA FAZER DEPOIS ALGUNS AJUSTES TU QUE DISSE ASS:Alan
    /**
     * Esta interface herda tudo o que a repository já faz,
     * porém se precisar de algo muito específico,
     * o mesmo deverá ser criado aqui
     */
    internal class FuncionarioRepositoryImpl : FuncionarioRepository
    {
        public List<Funcionario> FindAll(Funcionario entity)
        {
            List<Funcionario> list = new List<Funcionario>();
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
                    Funcionario func = new Funcionario();

                    func.IdFuncionario = (int)reader["id_funcionario"];
                    func.NomeFuncionario = (string)reader["nome_funcionario"];
                    func.Cpf = (string)reader["cpf"];
                    func.Matricula = (string)reader["matricula"];
                    func.Senha = (string)reader["senha"];
                    //func.Grupo = (char)reader["grupo"]; TO DO
                    func.Motorista = (string)reader["motorista"];
                    //func.ValidadeMotorista = (DateTime)reader["validade_motorista"]; TO DO
                    func.Observacao = (string)reader["observacao"];
                    func.Telefone = (string)reader["telefone"];
                    func.Email = (string)reader["email"];
                    //func.Numero = (int)reader["numero"]; //TO DO
                    func.Complemento = (string)reader["complemento"];

                    Endereco endereco = new Endereco();
                    endereco.Id = (int)reader["endereco_id"];
                    //endereco = ServiceFactory.createEnderecoService().FindById(endereco);

                    func.Endereco = endereco;

                    list.Add(func);
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

        public Funcionario FindById(Funcionario entity)
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
                    Funcionario func = new Funcionario();

                    func.IdFuncionario = (int)reader["id_funcionario"];
                    func.NomeFuncionario = (string)reader["nome_funcionario"];
                    func.Cpf = (string)reader["cpf"];
                    func.Matricula = (string)reader["matricula"];
                    func.Senha = (string)reader["senha"];
                    //func.Grupo = (char)reader["grupo"]; TODO
                    func.Motorista = (string)reader["motorista"];
                    func.ValidadeMotorista = (DateTime)reader["validade_motorista"];
                    func.Observacao = (string)reader["observacao"];
                    func.Telefone = (string)reader["telefone"];
                    func.Email = (string)reader["email"];
                    func.Numero = (int)reader["numero"];
                    func.Complemento = (string)reader["complemento"];

                    Endereco endereco = new Endereco();
                    endereco.Id = (int)reader["id_endereco"];
                    //endereco = ServiceFactory.createEnderecoService().FindById(endereco);

                    func.Endereco = endereco;

                    entity = func;
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

        public void Save(Funcionario entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();
            /*
             * id_funcionario, nome_funcionario, 
             * cpf, matricula, senha, grupo,
             * motorista, observacao, telefone,
             * email, endereco_id, numero,
             * complemento
             */
            string SQLInsert = $"INSERT INTO {entity.getName()}({entity.getFields()}) VALUES(" +
                
                $"'{entity.NomeFuncionario}'" +
                $", '{entity.Cpf}'" +
                $", '{entity.Matricula}'" +
                $", '{entity.Senha}'" +
                $", '{entity.Grupo}'" +
                $", '{entity.Motorista}'" +
                $", '{entity.ValidadeMotorista}'" +
                $", '{entity.Observacao}'" +
                $", '{entity.Telefone}'" +
                $", '{entity.Email}'" +
                $"{(entity.Endereco != null ?", " + entity.Endereco.Id + "": "")}" +
                $",  {entity.Numero}" +
                $", '{entity.Complemento}'" +
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
        public void Update(Funcionario entity)
        {
            MySqlCommand command;
            var conn = DatabaseConnectionSingleton.getConnection();
            string SQLUpdate = $"UPDATE {entity.getName()} SET nome = {entity.NomeFuncionario}, cpf = {entity.Cpf}" +
                $", matricula = {entity.Matricula} senha = {entity.Senha}, grupo = {entity.Grupo}, motorista = {entity.Motorista}" +
                $", validade_motorista = {entity.ValidadeMotorista}, observacao = {entity.Observacao}, telefone = {entity.Telefone}" +
                $", email = {entity.Email}, endereco_id = {entity.Endereco}, numero = {entity.Numero}, complemento = {entity.Complemento}" +
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
