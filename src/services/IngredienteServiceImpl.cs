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
    internal class IngredienteServiceImpl : IngredienteService
    {
        private IngredienteRepository? repository;

        public IngredienteServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreateIngredienteRepository();
            }
        }

        public void Save(Ingrediente entity)
        {
            this.repository.Save(entity);
        }

        public void Update(Ingrediente entity)
        {
            this.repository.Update(entity);
        }
        public Repository<Ingrediente> GetRepository() => repository;
    }
}
