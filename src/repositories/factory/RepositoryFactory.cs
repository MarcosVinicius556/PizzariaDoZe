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

        public static CidadeRepository CreateCidadeRepository() 
        { 
            return new CidadeRepositoryImpl(); 
        }

        public static ClienteRepository CreateClienteRepository() 
        { 
            return new ClienteRepositoryImpl();
        }

        public static EnderecoRepository CreateEnderecoRepository() 
        {
            return new EnderecoRepositoryImpl();
        }

        public static FuncionarioRepository CreateFuncionarioRepository() 
        { 
            return new FuncionarioRepositoryImpl();
        }

        public static PaisRepository CreatePaisRepository() 
        { 
            return new PaisRepositoryImpl();
        }

        public static ProdutoRepository CreateProdutoRepository() 
        { 
            return new ProdutoRepositoryImpl();
        }

        public static SaborRepository CreateSaborRepository()
        {
            return new SaborRepositoryImpl();
        }

        public static UfRepository CreateUfRepository() 
        {
            return new UfRepositoryImpl();
        }

        public static ValorRepository CreateValorRepository() 
        { 
            return new ValorRepositoryImpl();
        }

    }
}
