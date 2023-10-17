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
    internal class ValorServiceImpl : ValorService
    {
        private ValorRepository? repository;

        public ValorServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreateValorRepository();
            }
        }

        public void Save(Valor entity)
        {
            this.repository!.Save(entity);
        }

        public void Update(Valor entity)
        {
            this.repository!.Update(entity);
        }
        public Repository<Valor> GetRepository() => repository!;
    }
}
