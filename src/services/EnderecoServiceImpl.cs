using PizzariaDoZe.src.entities;
using PizzariaDoZe.src.repositories.factory;
using PizzariaDoZe.src.repositories.@interface;
using PizzariaDoZe.src.services.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.services
{
    internal class EnderecoServiceImpl : EnderecoService
    {
        private EnderecoRepository? repository;

        public EnderecoServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreateEnderecoRepository();
            }
        }

        public void Save(Endereco entity)
        {
            this.repository!.Save(entity);
        }

        public void Update(Endereco entity)
        {
            this.repository!.Update(entity);
        }
        public Repository<Endereco> GetRepository() => repository;

        public Endereco FindByCep(string cep)
        {
            return this.repository!.findByCEP(cep);
        }
    }
}
