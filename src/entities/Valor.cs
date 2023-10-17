using PizzariaDoZe.src.entities.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.entities
{
    internal class Valor : Entity
    {

        public int Id { get; set; }
        public char Tamanho { get; set; }
        public char Categoria { get; set; }
        public Decimal ValorPizza { get; set; }
        public Decimal ValorBorda { get; set; }

        public Valor()
        {
            this.Id = 0;
            this.Tamanho = 'P';
            this.Categoria = 'P';
            this.ValorPizza = new Decimal(0);
            this.ValorBorda = new Decimal(0);
        }

        public Valor(int id, char tamanho, char categoria, Decimal valorPizza, Decimal valorBorda)
        {
            this.Id = id;
            this.Tamanho = tamanho;
            this.Categoria = categoria;
            this.ValorPizza = valorPizza;
            this.ValorBorda = valorBorda;
        }

        public string getName()
        {
            return "valor";
        }

        public string getFields()
        {
            return "id, tamanho, categoria, valor, valor_borda";
        }

        public object getId()
        {
            return Id;
        }

        public string idField()
        {
            return "id";
        }
    }
}
