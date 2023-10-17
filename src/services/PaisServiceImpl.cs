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
    internal class PaisServiceImpl : PaisService
    {
        private PaisRepository? repository;

        public PaisServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreatePaisRepository();
            }
        }

        public void Save(Pais entity)
        {
            this.repository!.Save(entity);
        }

        public void Update(Pais entity)
        {
            this.repository!.Update(entity);
        }
        public Repository<Pais> GetRepository() => repository!;

        public DataTable CreateDataTableFromList<Pais>(List<Pais> data)
        {
            {
                DataTable dataTable = new DataTable();

                PropertyInfo[] properties = typeof(Pais).GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    dataTable.Columns.Add(property.Name, property.PropertyType);
                }

                foreach (Pais item in data)
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
