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
    internal class CidadeServiceImpl : CidadeService
    {
        private CidadeRepository? repository;

        public CidadeServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreateCidadeRepository();
            }
        }

        public void Save(Cidade entity)
        {
            this.repository!.Save(entity);
        }

        public void Update(Cidade entity)
        {
            this.repository!.Update(entity);
        }
        public Repository<Cidade> GetRepository() => repository!;

        public DataTable CreateDataTableFromList<Cidade>(List<Cidade> data)
        {
            {
                DataTable dataTable = new DataTable();

                /* Colunas do DataTable com base nas propriedades da classe */
                PropertyInfo[] properties = typeof(Cidade).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    dataTable.Columns.Add(property.Name, property.PropertyType);
                }

                /* Populando a grid com os dados da lista */
                foreach (Cidade item in data)
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
