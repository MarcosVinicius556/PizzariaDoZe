using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.entities.factory
{
    /**
     * Classe utilizada como fábrica de Entidades, o uso dela se deve mais ao fato de centralizarmos 
     * a criação de objetos todos em um único pontom além de facilitar, aumenta o controle
     */
    internal class EntityFactory
    {

        public Ingrediente CreateIngrediente()
        {
            return new Ingrediente();
        }

    }
}
