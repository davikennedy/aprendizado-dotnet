using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "João", sobrenome: "Da Silva");
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Rodrigues");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAlunos();

string[] linhas = File.ReadAllLines("Arquivos/ArquivoLeitura.txt");

foreach (string linha in linhas)
{
    Console.WriteLine(linha);
}

Console.ReadKey();