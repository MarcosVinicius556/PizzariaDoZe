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
        E GetEntity();
        void SetEntity(E entity);


        E FindById(object id)
        {
            try
            {
                Console.WriteLine("Executando: findById()");
                Console.WriteLine($"Id: {GetEntity().getId()}");
                Console.WriteLine($"Tabela: {GetEntity().getName()}");
                Console.WriteLine($"Colunas do banco: {GetEntity().getFields()}");
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

            /**
             * Remover após implementações estarem prontas
             */
            throw new Exception();
        }
        List<E> FindAll()
        {
            try
            {
                /**
                 * Transação do banco aqui
                 */
                Console.WriteLine("Executando: findAll()");
                Console.WriteLine($"Id: {GetEntity().getId()}");
                Console.WriteLine($"Tabela: {GetEntity().getName()}");
                Console.WriteLine($"Colunas do banco: {GetEntity().getFields()}");
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
            throw new Exception();
        }
        void DeleteById(object id)
        {
            try
            {
                /**
                 * Transação do banco aqui
                 */
                Console.WriteLine("Executando: deleteById()");
                Console.WriteLine($"Id: {GetEntity().getId()}");
                Console.WriteLine($"Tabela: {GetEntity().getName()}");
                Console.WriteLine($"Colunas do banco: { ().getFields()}");
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
            throw new Exception();
        }
        abstract void Save(E entity);
        abstract void Update(E entity);

    }
}
