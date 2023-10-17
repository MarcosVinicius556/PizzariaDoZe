using PizzariaDoZe.src.entities;
using PizzariaDoZe.src.services.factory;
using PizzariaDoZe.src.services.@interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.controllers
{

    internal class FormPrincipalEnderecoController
    {

        private EnderecoService? enderecoService;
        public FormPrincipalEnderecoController()
        {
            if(enderecoService == null)
            {
                enderecoService = ServiceFactory.createEnderecoService();
            }
        }

        public void Buscar(string cep)
        {
            Endereco endereco = enderecoService!.FindByCep(cep);
        }

    }
}
