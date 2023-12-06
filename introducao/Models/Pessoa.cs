using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo.Models //organização das classes - caminho lógico para identificar classes que estão no mesmo domínio
{
    public class Pessoa
    {
        // atributos: <visibilidade> <tipo_propriedade> <nome_propriedade> { get (para pegar valor); set (para atribuir); }

        public string Nome { get; set; } // get -> pega valor, set -> atribui valor
        public int Idade { get; set; }

        // criação de métodos/funções - ações que a classe pode realizar

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }

    }
}