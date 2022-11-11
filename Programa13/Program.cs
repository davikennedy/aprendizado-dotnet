/*
    Desafio: Lançar moeda para exibir "Cara" ou "Coroa".
    As chances de que o resultado seja "Cara" ou "Coroa" devem ser de 50% cada.
    Você deve ser capaz de realizar o resultado desejado em três linhas de código ou menos.
*/

Random randomico = new Random();
int teste = randomico.Next(0, 2);
Console.WriteLine($"Teste: {(teste == 0 ? "Cara" : "Coroa")}");