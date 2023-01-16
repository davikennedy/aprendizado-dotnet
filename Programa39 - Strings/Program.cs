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