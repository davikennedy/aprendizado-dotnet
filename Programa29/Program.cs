/*
    Desafio: 
    Escrever um novo código que vai gerar novas IDs de pedido para os pedidos cuja ID começa com a letra "B", 
    a partir da string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
*/

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] resultado = orderStream.Split(',');

for (int i = 0; i < resultado.Length; i++)
{
    char[] arrayValor = resultado[i].ToCharArray();
    if (arrayValor[0] == 'B')
    {
        Console.WriteLine(resultado[i]);
        continue;
    }
}