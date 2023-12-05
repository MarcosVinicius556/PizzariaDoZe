using PizzariaDoZe.src.entities;
using PizzariaDoZe.src.services.factory;
using PizzariaDoZe.src.services.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.controllers
{
    /**
     * Classe controller para ser a intermediadora entre o serviço e a view do usuário
     */
    internal class FormEnderecoController
    {

        private EnderecoService service;

        public FormEnderecoController() { 
            if(service == null) 
            {
                service = ServiceFactory.createEnderecoService();
            }
        }

        internal void DeleteById(string text)
        {
            try
            {
                Endereco obj = new Endereco();
                obj.Id = int.Parse(text);
                service.DeleteById(obj);
                MessageBox.Show("Registro removido com sucesso!");
            } catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao remover o registro");
            }
            
        }

        internal List<Endereco> LoadAll()
        {
            List<Endereco> lst = new List<Endereco>();
            try
            {
                
                MessageBox.Show("Busca de registro efetuada com sucesso!");
            } catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao buscar o registro!");
            }
            return lst;
        }

        internal Endereco LoadById(string v)
        {
            Endereco obj = null;
            try
            {
                obj = new Endereco();
                obj.Id = int.Parse(v);
                obj = service.FindById(obj);
                MessageBox.Show($"Registro localizado!");
            } catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao tentar buscar o endereco");
            }
            return obj;
        }

        internal void Save(Endereco endereco)
        {
            try
            {
                service.Save(endereco);
                MessageBox.Show("registro salvo com sucesso!");
            } catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao salvar o ingrediente");
            }
            
        }

        internal void remove(string id)
        {
            Endereco ender = new Endereco();
            if(id != null && id != "")
            {
                ender.Id = int.Parse(id);
                service.DeleteById(ender);
            } else
            {
                MessageBox.Show("Este registro não possui ID e por isso não pode ser removido!");
            }
        }

        internal void Update(Endereco newEndereco)
        {
            try
            {
                if (newEndereco != null)
                {
                    service.Update(newEndereco);
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
