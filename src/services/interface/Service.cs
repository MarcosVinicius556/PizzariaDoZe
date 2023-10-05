using PizzariaDoZe.src.entities.@interface;
using PizzariaDoZe.src.repositories.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.services.@interface
{
    /**
     * Classe de serviço, para caso algo além de uma busca no 
     * banco de dados precise ser executado, ou seja necessário 
     * uma tratativa diferente para algum retorno do banco
     * Default methods para as implementações do repository;
     */
    internal interface Service<E> where E : Entity
    {

        /**
         * Cada service será obrigado a implementar este método, 
         * que irá retornar um repositório responsável pela entidade 
         * a qual está sendo requisitado. Dessa forma podemos utilizar esta 
         * classe de forma ainda mais genérica
         */
        Repository<E> GetRepository();

        public E FindById(E entity)
        {
            return GetRepository().FindById(entity);
        }
       
        public List<E> FindAll(E entity)
        {
           return GetRepository().FindAll(entity);
        }
        void DeleteById(E entity)
        {
            GetRepository().DeleteById(entity);
        }
        abstract void Save(E entity);
        abstract void Update(E entity);

    }

}
