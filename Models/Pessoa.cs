using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        public void apresentar()
        {
            Console.Writeline($"Olá, meu nome é {nome} e eu tenho {idade} anos");   
        }
    }
}