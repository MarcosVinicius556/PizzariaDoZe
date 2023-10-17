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
    internal class PaisServiceImpl : PaisService
    {
        private PaisRepository? repository;

        public PaisServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreatePaisRepository();
            }
        }

        public void Save(Pais entity)
        {
            this.repository.Save(entity);
        }

        public void Update(Pais entity)
        {
            this.repository.Update(entity);
        }
        public Repository<Pais> GetRepository() => repository;
    }
}
