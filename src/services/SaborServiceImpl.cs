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
    internal class SaborServiceImpl : SaborService
    {
        private SaborRepository? repository;

        public SaborServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreateSaborRepository();
            }
        }

        public void Save(Sabor entity)
        {
            this.repository!.Save(entity);
        }

        public void Update(Sabor entity)
        {
            this.repository!.Update(entity);
        }
        public Repository<Sabor> GetRepository() => repository!;

        public DataTable CreateDataTableFromList<Sabor>(List<Sabor> data)
        {
            {
                DataTable dataTable = new DataTable();

                PropertyInfo[] properties = typeof(Sabor).GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    dataTable.Columns.Add(property.Name, property.PropertyType);
                }

                foreach (Sabor item in data)
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
