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
    internal class FuncionarioServiceImpl : FuncionarioService
    {
        private FuncionarioRepository? repository;

        public FuncionarioServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreateFuncionarioRepository();
            }
        }

        public void Save(Funcionario entity)
        {
            this.repository!.Save(entity);
        }

        public void Update(Funcionario entity)
        {
            this.repository!.Update(entity);
        }
        public Repository<Funcionario> GetRepository() => repository!;
    }
}
