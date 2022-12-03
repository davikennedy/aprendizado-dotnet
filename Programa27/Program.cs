/*
    Há vários métodos e técnicas que permitem converter uma cadeia de caracteres em uma matriz e vice-versa.
    Use métodos como ToCharArray() e Split() para criar uma matriz.
    Use métodos como Join() ou crie uma cadeia de caracteres passando uma matriz de char para transformar a matriz novamente em uma só cadeia de caracteres.
*/

string valor = "abc123";
char[] arrayValor = valor.ToCharArray();

// String.Join serve para criar uma string com base em um delimitador informado
string resultado = String.Join(",", arrayValor);
Console.WriteLine(resultado);

//String.Split serve para criar um array de strings com base em um delimitador informado
string[] itens = resultado.Split(',');
foreach (string item in itens)
{
    Console.WriteLine(item);
}