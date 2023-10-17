using PizzariaDoZe.src.entities.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.entities
{
    internal class Sabor : Entity
    {

        public int IdSabor { get; set; }
        public string DescricaoSabor { get; set; }
        public Bitmap Foto { get; set; }
        public char Categoria { get; set; }
        public char Tipo { get; set; }
        
        public Sabor() 
        { 
            this.IdSabor = 0;
            this.DescricaoSabor = "";
            this.Categoria = (char)0;
            this.Tipo = (char)0;
        }

        public Sabor(int idSabor, string descricaoSabor, char categoria, char tipo)
        {
            this.IdSabor = idSabor;
            this.DescricaoSabor = descricaoSabor;
            this.Categoria = categoria;
            this.Tipo = tipo;
        }

        public string getName()
        {
            return "sabor";
        }

        public string getFields()
        {
            return "id_sabor, descricao_sabor, foto, categoria, tipo";
        }

        public object getId()
        {
            return IdSabor;
        }

        public string idField()
        {
            return "id_sabor";
        }
    }
}
