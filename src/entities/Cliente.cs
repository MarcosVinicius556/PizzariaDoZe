using PizzariaDoZe.src.entities.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.entities
{
    internal class Cliente : Entity
    {

        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }

        public Cliente()
        {
            this.IdCliente = 0;
            this.NomeCliente = "";
            this.Cpf = "";
            this.Telefone = "";
            this.Email = "";
            this.Endereco = new Endereco();
            this.Numero = 0;
            this.Complemento = "";
        }

        public Cliente(int idCliente, string nomeCliente, string cpf, 
                       string telefone, string email, int numero, 
                       string complemento)
        {
            this.IdCliente = idCliente;
            this.NomeCliente = nomeCliente;
            this.Cpf = cpf;
            this.Telefone = telefone;
            this.Email = email;
            this.Endereco = new Endereco();
            this.Numero = numero;
            this.Complemento = complemento;
        }

        public string getName()
        {
            return "tb_clientes";
        }

        public string getFields()
        {
            return "id_cliente, nome_cliente, cpf, telefone, email, endereco_id, numero, complemento";
        }

        public object getId()
        {
            return IdCliente;
        }

        public string idField()
        {
            return "id_cliente";
        }
    }
}
