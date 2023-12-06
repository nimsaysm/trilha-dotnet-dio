using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPropriedades.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;

        public string Nome 
        { 
            get => _nome; //retorna o nome em maiúsculo
            // get {
            //     return _nome.ToUpper(); //retorna o nome em maiúsculo
            // }


            set 
            {
                if (value == "") //value - argumento que recebe o nome
                {
                    throw new ArgumentException("O nome não pode ser vazio"); //disparo de exceção
                }
                _nome = value; 
            }
     }

        public string Sobrenome { get; set; }

        //propriedade para juntar nome e sobrenome
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade 
        { 
            get => _idade; //retorna sem tratamento
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}"); //uso do get - não há atribuição, apenas chamada
        }
    }
}