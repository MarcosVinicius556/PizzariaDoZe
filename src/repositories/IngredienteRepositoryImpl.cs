using PizzariaDoZe.src.entities;
using PizzariaDoZe.src.repositories.@interface;

namespace PizzariaDoZe.src.repositories
{
    /**
     * Esta interface herda tudo o que a repository já faz,
     * porém se precisar de algo muito específico,
     * o mesmo deverá ser criado aqui
     */
    internal class IngredienteRepositoryImpl : IngredienteRepository
    {

        public void Save(Ingrediente entity)
        {
            try
            {
                string SQLInsert = $"INSERT INTO ingredientes(nome) VALUES('{entity.Nome}')";

            } catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar Ingrediente! Erro: " + ex.Message);
            }
        }
        public void Update(Ingrediente entity)
        {
            try
            {
                string SQLUpdate = $"UPDATE ingredientes SET nome = '{entity.Nome}'";

            } catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar Ingrediente! Erro: " + ex.Message);
            }
        }
    }
}
