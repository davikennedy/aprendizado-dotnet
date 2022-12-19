// IndexOf() retorna um int da posição de um caractere na string
string mensagem = "Encontre o que está (dentro dos parênteses)";

int aberturaPosicao = mensagem.IndexOf('(');
int fechamentoPosicao = mensagem.IndexOf(')');

Console.WriteLine(aberturaPosicao);
Console.WriteLine(fechamentoPosicao);

aberturaPosicao++;

int comprimento = fechamentoPosicao - aberturaPosicao;
Console.WriteLine(mensagem.Substring(aberturaPosicao, comprimento)); // Saída: dentro dos parênteses