/*
    Desafio: Simulação da rolagem de três dados de seis lados cada. 
    Avaliaremos os valores para calcular a pontuação. Se a pontuação for superior a um total arbitrário, 
    exibiremos uma mensagem de vitória para o usuário. Caso contrário, exibiremos uma mensagem de derrota para o usuário.

    Se quaisquer dois dados rolados resultarem no mesmo valor, você receberá dois pontos de bônus pelo resultado duplicado.
    Se os três dados rolados resultarem no mesmo valor, você receberá seis pontos de bônus pelo resultado triplicado.
    Se a soma dos três dados rolados, mais quaisquer pontos de bônus, for igual ou maior que 15, você vencerá o jogo. 
    Caso contrário, você perderá.
*/

Random randomico = new Random();

int valor1 = randomico.Next(1, 7);
int valor2 = randomico.Next(1, 7);
int valor3 = randomico.Next(1, 7);

int total = valor1 + valor2 + valor3;

Console.WriteLine($"{valor1} + {valor2} + {valor3} = {total}");

if ((valor1 == valor2) || (valor2 == valor3) || (valor3 == valor1)) {
    if ((valor1 == valor2) && (valor2 == valor3)) {
        Console.WriteLine("Você obteve um valor triplicado: +6 de bônus no total!");
        total += 6;
    } else {
        Console.WriteLine("Você obteve um valor duplicado: +2 de bônus no total!");
        total += 2;
    }
}

if (total >= 15) {
    Console.WriteLine("Você venceu!");
} else {
    Console.WriteLine("Você perdeu!");
}