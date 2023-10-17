using PizzariaDoZe.src.entities.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.entities
{
    internal class Cidade : Entity
    {

        public int IdCidade { get; set; }
        public string NomeCidade { get; set; }
        public Uf Uf { get; set; }

        public Cidade()
        {
            this.IdCidade = 0;
            this.NomeCidade = "";
        }

        public Cidade(int idCidade, string nomeCidade)
        {
            this.IdCidade = idCidade;
            this.NomeCidade = nomeCidade;
        }

        public string getName()
        {
            return "cidade";
        }

        public string getFields()
        {
            return "id, nome_cidade, uf_id";
        }

        public object getId()
        {
            return IdCidade;
        }

        public string idField()
        {
            return "id_cidade";
        }
    }
}
