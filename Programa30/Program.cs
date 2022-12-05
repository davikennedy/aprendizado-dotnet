using Internal;
string primeira = "Hello";
string segunda = "World";
string resultado = string.Format("{0} {1}!", primeira, segunda); 
Console.WriteLine(resultado); // Saída - Hello World
Console.WriteLine("{0} {0} {0}!", primeira, segunda); // Saída - Hello Hello Hello


// Formatar moeda conforme o país
decimal preco = 123.45m;
int desconto = 50;
Console.WriteLine($"Preço: {preco:C} (Desconto {desconto:C})"); // Saída - R$ 123,45 (Desconto R$ 50,00)


// Formatar número incluindo vírgulas para delinear, milhares, milhões, etc
decimal medida = 123456.78912m;
Console.WriteLine($"Medida: {medida:N}"); // Saída - Medida: 123.456,79


// Formatar número com apresentação de percentual
double taxa = .3678;
Console.WriteLine($"Taxa: {taxa:P2}"); // Saída - Taxa: 36,78%
Console.WriteLine($"Taxa: {taxa:P3}"); // Saída - Taxa: 36,780%