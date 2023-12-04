using PizzariaDoZe.src.entities.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.entities
{
    public class Uf : Entity
    {

        public int IdUf { get; set; }
        public string NomeUf { get; set; }
        public Pais Pais { get; set; }

        public Uf()
        {
            this.IdUf = 0;
            this.NomeUf = "";
        }

        public Uf(int idUf, string nomeUf)
        {
            this.IdUf = idUf;
            this.NomeUf = nomeUf;
        }

        public string getName()
        {
            return "cad_uf";
        }

        public string getFields()
        {
            return "id_uf, nome_uf, pais_id";
        }

        public object getId()
        {
            return IdUf;
        }

        public string idField()
        {
            return "id_uf";
        }
    }
}
