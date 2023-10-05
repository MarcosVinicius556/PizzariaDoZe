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
    internal class FormIngredientesController
    {

        private IngredienteService ingredienteService;

        public FormIngredientesController() { 
            if(ingredienteService == null) 
            {
                ingredienteService = ServiceFactory.createIngredienteService();
            }
        }

        internal void DeleteById(string text)
        {
            try
            {
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.Id = long.Parse(text);
                ingredienteService.DeleteById(ingrediente);
                MessageBox.Show("Ingrediente removido com sucesso!");
            } catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o ingrediente");
            }
            
        }

        internal void LoadAll()
        {
            try
            {
                ingredienteService.FindAll(new Ingrediente());
                MessageBox.Show("Busca de ingredientes efetuada com sucesso!");
            } catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao buscar todos os ingredientes");
            }
        }

        internal void LoadById(string v)
        {
            try
            {
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.Id = long.Parse(v);
                ingredienteService.FindById(ingrediente);
                MessageBox.Show($"Ingrediente {ingrediente.Nome} localizado!");
            } catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao tentar buscar o Ingrediente");
            }
        }

        internal void Save(string text)
        {
            try
            {
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.Nome = text;
                ingredienteService.Save(ingrediente);
                MessageBox.Show("Ingrediente salvo com sucesso!");
            } catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao salvar o ingrediente");
            }
            
        }

        internal void Update(string text, string text1)
        {
            try
            {
                if (text != null)
                {
                    Ingrediente temp = new Ingrediente(long.Parse(text), text1);
                    ingredienteService.Update(temp);
                } else
                {
                    MessageBox.Show("Informe um id para atualizar");
                }
            } catch(Exception e)
            {
                MessageBox.Show("Não foi possível atualizar o ingrediente!");
            }
            
        }
    }
}
