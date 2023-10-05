using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.src.entities.@interface
{
    /**
     * Define a base que toda classe que será um entidade do 
     * banco de dados deve possuir para funcionar com os default methods da aplicação
     */
    internal interface Entity
    {

        /**
         * Retorna o nome da tabela a ser acessada no banco
         */
        string getName();

        /**
         * Retorna o nome dos campos da tabela
         */
        string getFields();

        /**
         * Retorna o id da tabela
         */
        object getId();

    }
}
