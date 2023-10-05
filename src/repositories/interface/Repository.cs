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

        E FindById(E entity)
        {
            try
            {
                Console.WriteLine("Executando: findById()");
                Console.WriteLine($"Id: {entity.getId()}");
                Console.WriteLine($"Tabela: {entity.getName()}");
                Console.WriteLine($"Colunas do banco: {entity.getFields()}");
                /**
                 * Transação do banco aqui
                 */
            }
            catch (Exception e)
            {
                /**
                 * Tratativa personalizada para a exceção aqui
                 */
            }

            return entity;
            
        }
        List<E> FindAll(E entity)
        {
            try
            {
                /**
                 * Transação do banco aqui
                 */
                Console.WriteLine("Executando: findAll()");
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

            /**
             * Remover após implementações estarem prontas
             */
            return new List<E>();
        }
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
        abstract void Save(E entity);
        abstract void Update(E entity);

    }
}
