using PizzariaDoZe.src.entities.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.entities
{
    internal class Funcionario : Entity
    {

        public int IdFuncionario { get; set; }
        public string NomeFuncionario { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public string Senha { get; set; }
        public char Grupo { get; set; }
        public string Motorista { get; set; }
        public DateTime ValidadeMotorista { get; set; }
        public string Observacao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }

        public Funcionario()
        {
            this.IdFuncionario = 0;
            this.NomeFuncionario = "";
            this.Cpf = "";
            this.Matricula = "";
            this.Senha = "";
            this.Grupo = 'N';
            this.Motorista = "";
            this.Observacao = "";
            this.Telefone = "";
            this.Email = "";
            this.Endereco = new Endereco(); //Evitar "NullPointerException"
            this.Numero = 0;
            this.Complemento = "";
    }

        public Funcionario(int idFuncionario, string nomeFuncionario, string cpf, string matricula,
                           string senha, char grupo, string motorista, string observacao, string telefone,
                           string email, int numero, string complemento)
        {
            this.IdFuncionario = idFuncionario;
            this.NomeFuncionario = nomeFuncionario;
            this.Cpf = cpf;
            this.Matricula = matricula;
            this.Senha = senha;
            this.Grupo = grupo;
            this.Motorista = motorista;
            this.Observacao = observacao;
            this.Telefone = telefone;
            this.Email = email;
            this.Endereco = new Endereco(); //Evitar "NullPointerException"
            this.Numero = numero;
            this.Complemento = complemento;
        }

        public string getName()
        {
            return "tb_funcionarios";
        }

        public string getFields()
        {
            return "id_funcionario, nome_funcionario, " +
                   "cpf, matricula, senha, grupo, " +
                   "motorista, observacao, telefone, " +
                   "email, endereco_id, numero, " +
                   "complemento";
        }

        public object getId()
        {
            return IdFuncionario;
        }

        public string idField()
        {
            return "id_funcionario";
        }
    }
}
