using PizzariaDoZe.src.entities.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.entities
{
    internal class Pais : Entity
    {

        public int IdPais { get; set; }
        public string NomePais { get; set; }

        public Pais()
        {
            this.IdPais = 0;
            this.NomePais = "";
        }

        public Pais(int idPais, string nomePais)
        {
            this.IdPais = idPais;
            this.NomePais = nomePais;
        }

        public string getName()
        {
            return "cad_paises";
        }

        public string getFields()
        {
            return "id_pais, nome_pais";
        }

        public object getId()
        {
            return IdPais;
        }

        public string idField()
        {
            return "id_pais";
        }
    }
}
