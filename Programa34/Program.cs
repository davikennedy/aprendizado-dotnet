// IndexOf() retorna um int da posição de um caractere na string
string mensagem = "Encontre o que está (dentro dos parênteses)";

int aberturaPosicao = mensagem.IndexOf('(');
int fechamentoPosicao = mensagem.IndexOf(')');

Console.WriteLine(aberturaPosicao);
Console.WriteLine(fechamentoPosicao);