string dados = "12345DaviKennedy         5000  3  ";
string dadosAtualizados = dados.Remove(5, 20);
Console.WriteLine(dadosAtualizados); // Saída: 123455000  3

string mensagem = "Isto--é--um--ex-em-pl-o.";
mensagem = mensagem.Replace("--", " ");
mensagem = mensagem.Replace("-", "");
Console.WriteLine(mensagem); // Saída: Isto é um exemplo