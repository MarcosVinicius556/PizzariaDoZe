using PizzariaDoZe.src.entities;
using PizzariaDoZe.src.repositories.factory;
using PizzariaDoZe.src.repositories.@interface;
using PizzariaDoZe.src.services.@interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.services
{
    internal class FuncionarioServiceImpl : FuncionarioService
    {
        private FuncionarioRepository? repository;

        public FuncionarioServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreateFuncionarioRepository();
            }
        }

        public void Save(Funcionario entity)
        {
            this.repository!.Save(entity);
        }

        public void Update(Funcionario entity)
        {
            this.repository!.Update(entity);
        }
        public Repository<Funcionario> GetRepository() => repository!;

        public DataTable CreateDataTableFromList<Funcionario>(List<Funcionario> data)
        {
            {
                DataTable dataTable = new DataTable();

                PropertyInfo[] properties = typeof(Funcionario).GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    dataTable.Columns.Add(property.Name, property.PropertyType);
                }

                foreach (Funcionario item in data)
                {
                    DataRow row = dataTable.NewRow();
                    foreach (PropertyInfo property in properties)
                    {
                        row[property.Name] = property.GetValue(item);
                    }
                    dataTable.Rows.Add(row);
                }

                return dataTable;
            }
        }
    }
}
