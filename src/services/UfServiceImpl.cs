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
    internal class UfServiceImpl : UfService
    {
        private UfRepository? repository;

        public UfServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreateUfRepository();
            }
        }

        public void Save(Uf entity)
        {
            this.repository!.Save(entity);
        }

        public void Update(Uf entity)
        {
            this.repository!.Update(entity);
        }
        public Repository<Uf> GetRepository() => repository!;

        public DataTable CreateDataTableFromList<Uf>(List<Uf> data)
        {
            {
                DataTable dataTable = new DataTable();

                PropertyInfo[] properties = typeof(Uf).GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    dataTable.Columns.Add(property.Name, property.PropertyType);
                }

                foreach (Uf item in data)
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
