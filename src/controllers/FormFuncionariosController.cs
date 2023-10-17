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
    internal class FormFuncionariosController
    {

        private FuncionarioService service;

        public FormFuncionariosController() { 
            if(service == null) 
            {
                service = ServiceFactory.createFuncionarioService();
            }
        }

        internal void DeleteById(string text)
        {
            try
            {
                Funcionario obj = new Funcionario();
                obj.IdFuncionario = int.Parse(text);
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
                Funcionario obj = new Funcionario();
                obj.IdFuncionario = int.Parse(v);
                obj = service.FindById(obj);
                MessageBox.Show($"Registro localizado!");
            } catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao tentar buscar o Ingrediente");
            }
        }

        internal void Save(Funcionario funcionario)
        {
            try
            {
                service.Save(funcionario);
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
                    Funcionario temp = new Funcionario();
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
