using PizzariaDoZe.src.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.services.@interface
{
    /**
     * Utilizando uma interface aqui para reduzir o acoplamento entre classes, 
     * e caso os default methods não sejam suficientes, podem ser implementados 
     * especificamente para cada entidade do banco de dados
     */
    internal interface ClienteService : Service<Cliente>
{
}
}
