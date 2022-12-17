using System;

string input = "Texto";
Console.WriteLine(input.PadLeft(12)); // Esse método inserirá espaços em branco à esquerda da string, até completar 12 caracteres
Console.WriteLine(input.PadRight(15)); // Esse método inserirá espaços em branco à direita da string, até completar 15 caracteres

System.Console.WriteLine(input.PadLeft(10, '-')); // Esse método inserirá '-' à esquerda da string, até completar 10 caracteres
System.Console.WriteLine(input.PadRight(13, '-')); // Esse método inserirá '-' à direita da string, até completar 13 caracteres