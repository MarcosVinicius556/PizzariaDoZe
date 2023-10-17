using PizzariaDoZe.src.services.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.services.factory
{
    /**
     * Classe no padão factory para unificar e facilitar o instanciar de cada objeto
     * Além de que devolve apenas a abstração de cada classe, escondendo a implementação 
     * e reduzindo ainda mais o acoplamente da aplicação
     */
    internal class ServiceFactory
    {

        public static IngredienteService createIngredienteService()
        {
            return new IngredienteServiceImpl();
        }

        public static CidadeService createCidadeService() 
        {
            return new CidadeServiceImpl();
        }

        public static ClienteService createClienteService()
        { 
            return new ClienteServiceImpl();
        }

        public static EnderecoService createEnderecoService() 
        {  
            return new EnderecoServiceImpl(); 
        }

        public static FuncionarioService createFuncionarioService() 
        { 
            return new FuncionarioServiceImpl();
        }

        public static PaisService createPaisService()
        { 
            return new PaisServiceImpl();
        }

        public static ProdutoService createProdutoService() 
        {
            return new ProdutoServiceImpl();
        }

        public static SaborService createSaborService()
        {
            return new SaborServiceImpl();
        }

        public static UfService createUfService() 
        { 
            return new UfServiceImpl();
        }

        public static ValorService createValorService() 
        { 
            return new ValorServiceImpl();
        }

    }
}
