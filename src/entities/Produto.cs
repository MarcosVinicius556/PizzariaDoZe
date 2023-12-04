using PizzariaDoZe.src.entities.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.entities
{
    public class Produto : Entity
    {

        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public Decimal Valor { get; set; }
        public char Tipo { get; set; }
        public string MedidaUnitaria { get; set; }

        public Produto()
        {
            this.IdProduto = 0;
            this.DescricaoProduto = "";
            this.Valor = new Decimal(0);
            this.Tipo = (char)0;
            this.MedidaUnitaria = "";
        }

        public Produto(int idProduto, string descricaoProduto, Decimal valor, char tipo, string medidaUnitaria)
        {
            this.IdProduto = idProduto;
            this.DescricaoProduto = descricaoProduto;
            this.Valor = valor;
            this.Tipo = tipo;
            this.MedidaUnitaria = medidaUnitaria;
        }

        public string getName()
        {
            return "cad_produtos";
        }

        public string getFields()
        {
            return "id_produto, descricao_produto, valor, tipo, medida_unitaria";
        }

        public object getId()
        {
            return IdProduto;
        }

        public string idField()
        {
            return "id_produto";
        }
    }
}
