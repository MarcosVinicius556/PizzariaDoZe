using PizzariaDoZe.src.entities.@interface;

namespace PizzariaDoZe.src.entities
{
    internal class Ingrediente : Entity
    {
        public long Id { get; set; }
        public string? Nome { get; set; }

        public Ingrediente() { }

        public Ingrediente(long id, string nome) {
            this.Id = id;
            this.Nome = nome;
        }

        public string getName()
        {
            return "ingrediente";
        }
        public object getId()
        {
            return Id;
        }
        
        public string getFields()
        {
            return "id, nome";
        }

    }
}
