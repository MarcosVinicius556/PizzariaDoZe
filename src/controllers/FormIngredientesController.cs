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
            } catch(Exception e)
            {
                Console.WriteLine("Ocorreu um erro ao deletar o ingrediente");
            }
            
        }

        internal void LoadAll()
        {
            try
            {
                ingredienteService.FindAll(new Ingrediente());
            } catch(Exception e)
            {
                Console.WriteLine("Ocorreu um erro ao buscar todos os ingredientes");
            }
        }

        internal void LoadById(string v)
        {
            try
            {
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.Id = long.Parse(v);
                ingredienteService.FindById(ingrediente);
            } catch(Exception e)
            {
                Console.WriteLine("Ocorreu um erro ao tentar buscar o Ingrediente");
            }
        }

        internal void Save(string text)
        {
            try
            {
                ingredienteService.Save(new Ingrediente());
            } catch(Exception e)
            {
                Console.WriteLine("Ocorreu um erro ao salvar o ingrediente");
            }
            
        }

        internal void Update(string text, string text1)
        {
            try
            {
                ingredienteService.Update(new Ingrediente());
            } catch(Exception e)
            {

            }
            
        }
    }
}
