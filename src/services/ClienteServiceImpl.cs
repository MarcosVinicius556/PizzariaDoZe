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
    internal class ClienteServiceImpl : ClienteService
    {
        private ClienteRepository? repository;

        public ClienteServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreateClienteRepository();
            }
        }

        public void Save(Cliente entity)
        {
            this.repository!.Save(entity);
        }

        public void Update(Cliente entity)
        {
            this.repository!.Update(entity);
        }
        public Repository<Cliente> GetRepository() => repository!;
    }
}
