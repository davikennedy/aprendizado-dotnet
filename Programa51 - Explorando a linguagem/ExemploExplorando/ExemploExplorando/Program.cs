using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "João", sobrenome: "Da Silva");
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Rodrigues");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAlunos();

try
{
    string[] linhas = File.ReadAllLines("Arquivos/ArquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException e)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {e.Message}");
}
catch (DirectoryNotFoundException e)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {e.Message}");
}

 Console.ReadKey();