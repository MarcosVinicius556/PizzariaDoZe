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
    internal class FormValorController
    {

        private ValorService service;

        public FormValorController() { 
            if(service == null) 
            {
                service = ServiceFactory.createValorService();
            }

        }

        internal void DeleteById(string text)
        {
            try
            {
                Valor obj = new Valor();
                obj.Id = int.Parse(text);
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

        internal void LoadById(string v)
        {
            try
            {
                Valor obj = new Valor();
                obj.Id = int.Parse(v);
                obj = service.FindById(obj);
                MessageBox.Show($"Registro localizado!");
            } catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao tentar buscar o Ingrediente");
            }
        }

        internal void Save(Valor valor)
        {
            try
            {
                service.Save(valor);
                MessageBox.Show("Ingrediente salvo com sucesso!");
            } catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao salvar o ingrediente");
            }
            
        }

        internal void remove(string id)
        {
            Valor valor = new Valor();
            if(id != "")
            {
                valor.Id = int.Parse(id);
                service.DeleteById(valor);
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
                    Valor temp = new Valor();
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
