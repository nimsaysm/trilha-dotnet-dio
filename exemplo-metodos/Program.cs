using ExemploMetodos.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Yasmin";
p1.Sobrenome = "Soraya";

Pessoa p2 = new Pessoa();
p2.Nome = "João";
p2.Sobrenome = "Kleber";

Curso cursoDeProgramacao = new Curso(); //new - isntância (materializar) da classe
cursoDeProgramacao.Nome = "Programação";
cursoDeProgramacao.Alunos = new List<Pessoa>();

cursoDeProgramacao.AdicionarAluno(p1);
cursoDeProgramacao.AdicionarAluno(p2);
cursoDeProgramacao.ListarAlunos(); 