using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        //<visibilidade> <tipo> <NomeMétodo>(<tipo> <variável>)
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno); 
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            for (int count = 0; count < Alunos.Count; count++)
            {
                //concatenação de strings
                //string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;
                //interpolação
                string texto = $"Nº {count + 1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}