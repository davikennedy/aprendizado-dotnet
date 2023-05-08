using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "João";
p1.Sobrenome = "Da Silva";
p1.Idade = 25;

Pessoa p2 = new Pessoa();
p2.Nome = "Eduardo";
p2.Sobrenome = "Rodrigues";
p2.Idade = 31;


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAlunos();