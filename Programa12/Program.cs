// Usando o operador de igualdade
string valor1 = "a ";
string valor2 = "A";

Console.WriteLine(valor1 == valor2); // Saída: false;
Console.WriteLine(valor1.Trim().ToLower() == valor2.Trim().ToLower()); // Saída: True


// Usando o operador de desigualdade
Console.WriteLine("a" != "a"); // Saída: False
Console.WriteLine("a" != "A"); // Saída: True
Console.WriteLine(1 != 2); // Saída: False

string meuValor = "a";
Console.WriteLine(meuValor != "a"); // Saída: False