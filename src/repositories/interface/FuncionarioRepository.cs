using PizzariaDoZe.src.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.repositories.@interface
{
    /**
     * Utilizando interface para separar a abstração da implementação, reduzindo assim o acomplamento entre classes
     */
    internal interface FuncionarioRepository : Repository<Funcionario>
    {
    }
}
