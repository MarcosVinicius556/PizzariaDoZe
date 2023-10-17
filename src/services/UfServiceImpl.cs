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
    internal class UfServiceImpl : UfService
    {
        private UfRepository? repository;

        public UfServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreateUfRepository();
            }
        }

        public void Save(Uf entity)
        {
            this.repository.Save(entity);
        }

        public void Update(Uf entity)
        {
            this.repository.Update(entity);
        }
        public Repository<Uf> GetRepository() => repository;
    }
}
