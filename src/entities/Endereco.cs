using PizzariaDoZe.src.entities.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.entities
{
    internal class Endereco : Entity
    {
        public int Id { get; set; } 
        public string Cep { get; set; } 
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public Cidade Cidade { get; set; }

        public Endereco()
        {

        }

        public Endereco(int id, string cep, string logradouro, string bairro)
        {
            /* Neste caso não seria necessário utilizar o "this", mas eu acho bonitinho :) */
            this.Id = id;
            this.Cep = cep;
            this.Logradouro = logradouro;
            this.Bairro = bairro;
        }
        public string getFields()
        {
            return "id_endereco, cep, logradouro, bairro, cidade_id";
        }

        public object getId()
        {
            return Id;
        }

        public string getName()
        {
            return "tb_enderecos";
        }

        public string idField()
        {
            return "id_endereco";
        }
    }
}
