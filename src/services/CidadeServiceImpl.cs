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
    internal class CidadeServiceImpl : CidadeService
    {
        private CidadeRepository? repository;

        public CidadeServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreateCidadeRepository();
            }
        }

        public void Save(Cidade entity)
        {
            this.repository!.Save(entity);
        }

        public void Update(Cidade entity)
        {
            this.repository!.Update(entity);
        }
        public Repository<Cidade> GetRepository() => repository!;
    }
}
