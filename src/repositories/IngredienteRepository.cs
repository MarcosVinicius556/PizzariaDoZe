using PizzariaDoZe.src.entities;
using PizzariaDoZe.src.repositories.@interface;

namespace PizzariaDoZe.src.repositories
{
    /**
     * Esta interface herda tudo o que a repository já faz,
     * porém se precisar de algo muito específico,
     * o mesmo deverá ser criado aqui
     */
    internal class IngredienteRepository : Repository<Ingrediente>
    {

        public Ingrediente? entity { get; set; }
        public Ingrediente GetEntity() => entity;
        public void SetEntity(Ingrediente entity)
        {
            throw new NotImplementedException();
        }

        public void Save(Ingrediente entity)
        {

        }
        public void Update(Ingrediente entity)
        {

        }
    }
}
