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
    internal class EnderecoServiceImpl : EnderecoService
    {
        private EnderecoRepository? repository;

        public EnderecoServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreateEnderecoRepository();
            }
        }

        public void Save(Endereco entity)
        {
            this.repository!.Save(entity);
        }

        public void Update(Endereco entity)
        {
            this.repository!.Update(entity);
        }
        public Repository<Endereco> GetRepository() => repository;

        public Endereco FindByCep(string cep)
        {
            return this.repository!.findByCEP(cep);
        }

        public DataTable CreateDataTableFromList<Endereco>(List<Endereco> data)
        {
            {
                DataTable dataTable = new DataTable();

                PropertyInfo[] properties = typeof(Endereco).GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    dataTable.Columns.Add(property.Name, property.PropertyType);
                }

                foreach (Endereco item in data)
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
