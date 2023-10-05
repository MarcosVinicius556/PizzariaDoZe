using PizzariaDoZe.src.repositories.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.repositories.factory
{
    /**
     * Classe global para facilitar e unificar as instancias de classes repository
     */
    internal class RepositoryFactory
    {

        public static IngredienteRepository CreateIngredienteRepository()
        {
            return new IngredienteRepositoryImpl();
        }

    }
}
