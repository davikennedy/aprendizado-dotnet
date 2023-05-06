int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

Console.WriteLine("Percorrendo um array com 'for'");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição nº {contador} - {arrayInteiros[contador]}");
}


Console.WriteLine("Percorrendo um array com 'foreach'");
int contadorForeach = 0;
foreach (var valor in arrayInteiros)
{
    Console.WriteLine($"Posição nº {contadorForeach} - {valor}");
    contadorForeach++;
}