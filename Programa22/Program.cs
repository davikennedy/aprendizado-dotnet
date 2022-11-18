// Aprendendo a utilizar os métodos ToString() e Parse()

int primeiro = 5;
int segundo = 7;
string message = primeiro.ToString() + segundo.ToString();
Console.WriteLine(message); // 57

string terceiro = "5";
string quarto = "7";
int soma = int.Parse(terceiro) + int.Parse(quarto);
Console.WriteLine(soma); // 12