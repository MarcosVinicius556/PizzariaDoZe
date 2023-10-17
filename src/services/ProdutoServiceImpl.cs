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
    internal class ProdutoServiceImpl : ProdutoService
    {
        private ProdutoRepository? repository;

        public ProdutoServiceImpl()
        {
            if (this.repository == null)
            {
                this.repository = RepositoryFactory.CreateProdutoRepository();
            }
        }

        public void Save(Produto entity)
        {
            this.repository!.Save(entity);
        }

        public void Update(Produto entity)
        {
            this.repository!.Update(entity);
        }
        public Repository<Produto> GetRepository() => repository!;

        public DataTable CreateDataTableFromList<Produto>(List<Produto> data)
        {
            {
                DataTable dataTable = new DataTable();

                PropertyInfo[] properties = typeof(Produto).GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    dataTable.Columns.Add(property.Name, property.PropertyType);
                }

                foreach (Produto item in data)
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
