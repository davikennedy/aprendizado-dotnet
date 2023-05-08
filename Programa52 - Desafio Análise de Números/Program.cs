/* Desafio
 * Você deve fazer a leitura de 5 valores inteiros. 
 * Em seguida mostre quantos valores informados são pares, 
 * quantos valores informados são ímpares, 
 * quantos valores informados são positivos 
 * e quantos valores informados são negativos.
 * 
 * Considere que o número zero é positivo, 
 * mas não pode ser considerado como positivo ou negativo. * 
 */

using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        int valor1 = int.Parse(Console.ReadLine());
        int valor2 = int.Parse(Console.ReadLine());
        int valor3 = int.Parse(Console.ReadLine());
        int valor4 = int.Parse(Console.ReadLine());
        int valor5 = int.Parse(Console.ReadLine());

        int quantidadePares = 0;
        int quantidadeImpares = 0;
        int quantidadePositivos = 0;
        int quantidadeNegativos = 0;

        var numeros = new List<int> { valor1, valor2, valor3, valor4, valor5 };

        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] % 2 == 0) quantidadePares++;
            else quantidadeImpares++;

            if (numeros[i] > 0) quantidadePositivos++;
            if (numeros[i] < 0) quantidadeNegativos++;
        }

        Console.WriteLine("{0} par(es)", quantidadePares);
        Console.WriteLine("{0} ímpar(es)", quantidadeImpares);
        Console.WriteLine("{0} positivo(s)", quantidadePositivos);
        Console.WriteLine("{0} negativo(s)", quantidadeNegativos);
    }
}
