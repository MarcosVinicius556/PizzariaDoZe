using PizzariaDoZe.src.entities;
using PizzariaDoZe.src.services.factory;
using PizzariaDoZe.src.services.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PizzariaDoZe.src.controllers
{
    /**
     * Classe controller para ser a intermediadora entre o serviço e a view do usuário
     */
    internal class FormClienteController
    {

        private ClienteService service;
        private EnderecoService enderService;

        public FormClienteController() { 
            if(service == null) 
            {
                service = ServiceFactory.createClienteService();
            }
        }

        internal void DeleteById(string text)
        {
            try
            {
                Cliente obj = new Cliente();
                obj.IdCliente = int.Parse(text);
                service.DeleteById(obj);
                MessageBox.Show("Registro removido com sucesso!");
            } catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao remover o registro");
            }
            
        }

        internal List<Cliente> LoadAll()
        {
            List<Cliente> lst = new List<Cliente>();
            try
            {
                
                MessageBox.Show("Busca de registro efetuada com sucesso!");
            } catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao buscar o registro!");
            }
            return lst;
        }

        internal Cliente LoadById(string v)
        {
            Cliente obj = null;
            try
            {
                obj = new Cliente();
                obj.IdCliente = int.Parse(v);
                obj = service.FindById(obj);
                MessageBox.Show($"Registro localizado!");
            } catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao tentar buscar o endereco");
            }
            return obj;
        }

        internal Endereco loadEnderecoById(int id)
        {
            Endereco endereco = new Endereco { Id = id };
            return enderService.FindById(endereco);
        }

        internal void Save(Cliente obj)
        {
            try
            {
                service.Save(obj);
                MessageBox.Show("registro salvo com sucesso!");
            } catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao salvar o ingrediente");
            }
            
        }

        internal void remove(string id)
        {
            Cliente obj = new Cliente();
            if(id != null && id != "")
            {
                obj.IdCliente = int.Parse(id);
                service.DeleteById(obj);
            } else
            {
                MessageBox.Show("Este registro não possui ID e por isso não pode ser removido!");
            }
        }

        internal void Update(Cliente newObj)
        {
            try
            {
                if (newObj != null)
                {
                    service.Update(newObj);
                } else
                {
                    MessageBox.Show("Informe um id para atualizar");
                }
            } catch(Exception e)
            {
                MessageBox.Show("Não foi possível atualizar o registro!");
            }
            
        }
    }
}
