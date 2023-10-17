using PizzariaDoZe.src.entities;
using PizzariaDoZe.src.services.factory;
using PizzariaDoZe.src.services.@interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.controllers
{

    internal class FormPrincipalController
    {

        private EnderecoService? enderecoService;
        private CidadeService? cidadeService;
        private ClienteService? clienteService;
        private FuncionarioService? funcionarioService;
        private IngredienteService? ingredienteService;
        private PaisService? paisService;
        private ProdutoService? produtoService;
        private SaborService? saborService;
        private UfService? ufService;
        private ValorService? valorService;
        public FormPrincipalController()
        {
            initServices();
        }

        private void initServices()
        {
            if (enderecoService == null)
            {
                enderecoService = ServiceFactory.createEnderecoService();
            }
            if (cidadeService == null)
            {
                cidadeService = ServiceFactory.createCidadeService();
            }
            if (clienteService == null)
            {
                clienteService = ServiceFactory.createClienteService();
            }
            if (funcionarioService == null)
            {
                funcionarioService = ServiceFactory.createFuncionarioService();
            }
            if (ingredienteService == null)
            {
                ingredienteService = ServiceFactory.createIngredienteService();
            }
            if (paisService == null)
            {
                paisService = ServiceFactory.createPaisService();
            }
            if (produtoService == null)
            {
                produtoService = ServiceFactory.createProdutoService();
            }
            if (cidadeService == null)
            {
                saborService = ServiceFactory.createSaborService();
            }
            if (ufService == null)
            {
                ufService = ServiceFactory.createUfService();
            }
            if (valorService == null)
            {
                valorService = ServiceFactory.createValorService();
            }
        }

        public DataTable BuscarCidades()
        {
            List<Cidade> cidades = cidadeService!.FindAll(new Cidade());
            return cidadeService.CreateDataTableFromList(cidades);
        }

        public DataTable BuscarClientes()
        {
            List<Cliente> clientes = clienteService!.FindAll(new Cliente());
            return clienteService.CreateDataTableFromList(clientes);
        }

        public DataTable BuscarEnderecos()
        {
            List<Endereco> enderecos = enderecoService!.FindAll(new Endereco());
            return enderecoService.CreateDataTableFromList(enderecos);
        }

        public DataTable BuscarFuncionarios()
        {
            List<Funcionario> funcionarios = funcionarioService!.FindAll(new Funcionario());
            return funcionarioService.CreateDataTableFromList(funcionarios);
        }

        public DataTable BuscarIngredientes()
        {
            List<Ingrediente> ingredientes = ingredienteService!.FindAll(new Ingrediente());
            return ingredienteService.CreateDataTableFromList(ingredientes);
        }

        public DataTable BuscarPaises()
        {
            List<Pais> paises = paisService!.FindAll(new Pais());
            return paisService.CreateDataTableFromList(paises);
        }

        public DataTable BuscarProdutos()
        {
            List<Produto> produtos = produtoService!.FindAll(new Produto());
            return produtoService.CreateDataTableFromList(produtos);
        }

        public DataTable BuscarSabores()
        {
            List<Sabor> sabores = saborService!.FindAll(new Sabor());
            return saborService.CreateDataTableFromList(sabores);
        }

        public DataTable BuscarUfs()
        {
            List<Uf> ufs = ufService!.FindAll(new Uf());
            return ufService.CreateDataTableFromList(ufs);
        }

        public DataTable BuscarValores()
        {
            List<Valor> valores = valorService!.FindAll(new Valor());
            return valorService.CreateDataTableFromList(valores);
        }

    }
}
