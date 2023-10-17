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
    internal class SaborServiceImpl : SaborService
    {
        private SaborRepository? repository;

        public SaborServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreateSaborRepository();
            }
        }

        public void Save(Sabor entity)
        {
            this.repository!.Save(entity);
        }

        public void Update(Sabor entity)
        {
            this.repository!.Update(entity);
        }
        public Repository<Sabor> GetRepository() => repository!;
    }
}
