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
    internal class ValorServiceImpl : ValorService
    {
        private ValorRepository? repository;

        public ValorServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreateValorRepository();
            }
        }

        public void Save(Valor entity)
        {
            this.repository!.Save(entity);
        }

        public void Update(Valor entity)
        {
            this.repository!.Update(entity);
        }
        public Repository<Valor> GetRepository() => repository!;

        public DataTable CreateDataTableFromList<Valor>(List<Valor> data)
        {
            {
                DataTable dataTable = new DataTable();

                PropertyInfo[] properties = typeof(Valor).GetProperties();

                // Adicione colunas ao DataTable com base nas propriedades da classe
                foreach (PropertyInfo property in properties)
                {
                    dataTable.Columns.Add(property.Name, property.PropertyType);
                }

                // Preencha o DataTable com os dados da lista
                foreach (Valor item in data)
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
