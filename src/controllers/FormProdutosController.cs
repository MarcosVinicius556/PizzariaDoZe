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
    internal class FormProdutosController
    {

        private ProdutoService service;

        public FormProdutosController() { 
            if(service == null) 
            {
                service = ServiceFactory.createProdutoService();
            }
        }

        internal void DeleteById(string text)
        {
            try
            {
                Produto obj = new Produto();
                obj.IdProduto = int.Parse(text);
                service.DeleteById(obj);
                MessageBox.Show("Registro removido com sucesso!");
            } catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao remover o registro");
            }
            
        }

        internal void LoadAll()
        {
            try
            {
                MessageBox.Show("Busca de registro efetuada com sucesso!");
            } catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao buscar o registro!");
            }
        }

        internal Produto LoadById(string v)
        {
            Produto obj = null;
            try
            {
                obj = new Produto();
                obj.IdProduto = int.Parse(v);
                obj = service.FindById(obj);
                MessageBox.Show($"Registro localizado!");
            } catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao tentar buscar o Ingrediente");
            }
            return obj;
        }

        internal void Save(Produto obj)
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
            Produto func = new Produto();
            if(id != "")
            {
                func.IdProduto = int.Parse(id);
                service.DeleteById(func);
            } else
            {
                MessageBox.Show("Este registro não possui ID e por isso não pode ser removido!");
            }
        }

        internal void Update(string text, string text1)
        {
            try
            {
                if (text != null)
                {
                    Produto temp = new Produto();
                    service.Update(temp);
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
