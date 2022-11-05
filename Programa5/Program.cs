Random randomico = new Random();
int jogarDados = randomico.Next(1, 7);
Console.WriteLine(jogarDados); // Número aleatório que vai de 1 até o valor anterior a 7

Random randomico2 = new Random();
int jogarDados1 = randomico2.Next();
int jogarDados2 = randomico2.Next(101);
int jogarDados3 = randomico2.Next(50, 101);

Console.WriteLine($"Primeira jogada: {jogarDados1}"); // Número inteiro indefinido
Console.WriteLine($"Segunda jogada: {jogarDados2}"); // Número aleatório que vai de 0 até o valor anterior a 101
Console.WriteLine($"Terceira jogada: {jogarDados3}"); // Número aleatório que vai de 50 até o valor anterior a 101