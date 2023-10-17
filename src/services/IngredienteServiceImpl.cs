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
    internal class IngredienteServiceImpl : IngredienteService
    {
        private IngredienteRepository? repository;

        public IngredienteServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreateIngredienteRepository();
            }
        }

        public void Save(Ingrediente entity)
        {
            this.repository!.Save(entity);
        }

        public void Update(Ingrediente entity)
        {
            this.repository!.Update(entity);
        }
        public Repository<Ingrediente> GetRepository() => repository!;

        public DataTable CreateDataTableFromList<Ingrediente>(List<Ingrediente> data)
        {
            {
                DataTable dataTable = new DataTable();

                PropertyInfo[] properties = typeof(Ingrediente).GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    dataTable.Columns.Add(property.Name, property.PropertyType);
                }

                foreach (Ingrediente item in data)
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
