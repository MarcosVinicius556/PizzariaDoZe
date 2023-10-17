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
    internal class ProdutoServiceImpl : ProdutoService
    {
        private ProdutoRepository? repository;

        public ProdutoServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreateProdutoRepository();
            }
        }

        public void Save(Produto entity)
        {
            this.repository.Save(entity);
        }

        public void Update(Produto entity)
        {
            this.repository.Update(entity);
        }
        public Repository<Produto> GetRepository() => repository;
    }
}
