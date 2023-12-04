using PizzariaDoZe.src.entities.@interface;

namespace PizzariaDoZe.src.entities
{
    internal class Ingrediente : Entity
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public string? descricaoIngrediente { get; set; }

        public Ingrediente(long id, string nome, string descricaoIngrediente)
        {
            this.Id = id;
            this.Nome = nome;
            this.descricaoIngrediente = descricaoIngrediente;

        }

        public string getName()
        {
            return "cad_ingredientes";
        }
        public object getId()
        {
            return Id;
        }
        
        public string getFields()
        {
            return "id, nome, descricao_ingrediente";
        }

        public string idField()
        {
            return "id";
        }
    }
}
