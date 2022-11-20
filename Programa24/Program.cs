/*
    Desafio: 
    Adicione o código necessário para implementar as seguintes regras de negócio:

    Regra 1: se o valor for alfanumérico, concatene-o para formar uma mensagem
    Regra 2: se o valor for numérico, adicione-o ao total
    Regra 3: verifique se o resultado corresponde à seguinte saída:

    Comece com a seguinte linha de código:
    string[] valores = { "12.3", "45", "ABC", "11", "DEF" };
*/

string[] valores = { "12.3", "45", "ABC", "11", "DEF" };

string mensagem = "";
double somatorio = 0;
double numero = 0;

for (int i = 0; i < valores.Length; i++) {
    
    if (double.TryParse(valores[i], out numero)) {
       somatorio += numero;
    }
    else {
        mensagem += valores[i];
    }
}

Console.WriteLine($"Mensagem {mensagem}");
Console.WriteLine($"Total: {somatorio}");