using MySql.Data.MySqlClient;
using PizzariaDoZe.src.entities;
using PizzariaDoZe.src.entities.@interface;

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
            try
            {
                /**
                 * Transação do banco aqui
                 */
                Console.WriteLine("Executando: deleteById()");
                Console.WriteLine($"Id: {entity.getId()}");
                Console.WriteLine($"Tabela: {entity.getName()}");
                Console.WriteLine($"Colunas do banco: {entity.getFields()}");
            }
            catch (Exception e)
            {
                /**
                 * Tratativa personalizada para a exceção aqui
                 */
            }
        }
        

    }
}
