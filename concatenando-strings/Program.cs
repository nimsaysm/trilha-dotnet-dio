using ExemploConstrutores.Models;

Pessoa p1 = new Pessoa("Yasmin", "Soraya");
Pessoa p2 = new Pessoa(nome: "João", sobrenome:"Kleber");



Curso cursoDeProgramacao = new Curso(); //new - isntância (materializar) da classe
cursoDeProgramacao.Nome = "Programação";
cursoDeProgramacao.Alunos = new List<Pessoa>();

cursoDeProgramacao.AdicionarAluno(p1);
cursoDeProgramacao.AdicionarAluno(p2);
cursoDeProgramacao.ListarAlunos(); 