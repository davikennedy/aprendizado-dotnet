// Criando id's com o uso de Guid
var id = Guid.NewGuid();
id.ToString();

id = new Guid("c618ef17-931a-4dc4-9adc-6dd1c78baf0d");
id = new Guid(); // Esse código vai atribuir o valor 00000000-0000-0000-0000-000000000000 para o id

Console.WriteLine(id);


// Comparando strings
var texto = "Testando";
Console.WriteLine(texto.CompareTo("Testando")); // Retorna 0, quando a string comparada é idêntica
Console.WriteLine(texto.Contains("estando")); // Retorna True se a correspondência for encontrada

var texto2 = "Teste";

var teste1 = texto2.Contains("teste");
Console.WriteLine(teste1); // Retorna False

var teste2 = texto2.Contains("teste", StringComparison.OrdinalIgnoreCase);
Console.WriteLine(teste2); // Retorna True


// StartsWith / EndsWith
var texto3 = "Este texto é um teste";

Console.WriteLine(texto3.StartsWith("Este")); // Retorna True
Console.WriteLine(texto3.StartsWith("este")); // Retorna False
Console.WriteLine(texto3.StartsWith("este", StringComparison.OrdinalIgnoreCase)); // Retorna True

Console.WriteLine(texto3.EndsWith("teste")); // Retorna True
Console.WriteLine(texto3.EndsWith("Teste")); // Retorna False
Console.WriteLine(texto3.EndsWith("Teste", StringComparison.OrdinalIgnoreCase)); // Retorna True

// Manipulando strings
Console.WriteLine(texto3.Replace("e", "X")); // Retorna EstX tXxto é um tXstX
Console.WriteLine(texto3.Substring(startIndex: 5, length: 5)); // Retorna texto
System.Console.WriteLine(texto3.Insert(5, "AQUI ")); // Insere o texto AQUI na posição 5 da string
System.Console.WriteLine(texto3.Remove(5, 5)); // Remove 5 caracteres a partir do 5º caractere da string

texto3 = "   Este texto é um teste   ";
texto3 = texto3.Trim();
Console.WriteLine($"Texto com trim: {texto3}"); // O trim remove os espaços em branco no início e fim de uma string

// Usando método split
var divisao = texto3.Split(" ");
Console.WriteLine(divisao[0]);

foreach (string div in divisao)
{
    Console.WriteLine(div);
}