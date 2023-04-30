using Fundamentos.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Joãozinho";
p1.Idade = 25;

Pessoa p2 = new Pessoa();
p2.Nome = "Mariazinha";
p2.Idade = 17;

p1.Apresentar();
p2.Apresentar();
Console.ReadKey();