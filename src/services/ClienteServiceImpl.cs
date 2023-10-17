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
    internal class ClienteServiceImpl : ClienteService
    {
        private ClienteRepository? repository;

        public ClienteServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreateClienteRepository();
            }
        }

        public void Save(Cliente entity)
        {
            this.repository!.Save(entity);
        }

        public void Update(Cliente entity)
        {
            this.repository!.Update(entity);
        }
        public Repository<Cliente> GetRepository() => repository!;

        public DataTable CreateDataTableFromList<Cliente>(List<Cliente> data)
        {
            {
                DataTable dataTable = new DataTable();

                PropertyInfo[] properties = typeof(Cliente).GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    dataTable.Columns.Add(property.Name, property.PropertyType);
                }

                foreach (Cliente item in data)
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
