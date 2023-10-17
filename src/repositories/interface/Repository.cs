using MySql.Data.MySqlClient;
using PizzariaDoZe.src.entities;
using PizzariaDoZe.src.entities.@interface;
using PizzariaDoZe.src.repositories.singleton;
using System.Data;

namespace PizzariaDoZe.src.repositories.@interface
{
    /**
     * Interface genérica utilizada para marcar todos os métodos
     * que todas as entidades do banco de dados terão implementadas
     * por padrão
     */
    internal interface Repository<E> where E : Entity
    {

        abstract List<E> FindAll(E entity);
        abstract E FindById(E entity);
        abstract void Save(E entity);
        abstract void Update(E entity);

        void DeleteById(E entity)
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
            string SQLInsert = $"DELETE FROM {entity.getName()} WHERE {entity.idField} = {entity.getId()}";

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
                MessageBox.Show("Ocorreu um erro ao remover o registro no banco! " + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        

    }
}
