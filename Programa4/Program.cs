/*
Operadores como +=, -=, *=, ++ e -- são conhecidos como operadores de atribuição composta 
porque compõem uma operação além de atribuir o resultado à variável. O operador += é chamado 
especificamente de operador de atribuição de adição.
*/

int valor = 1;
valor++;

Console.WriteLine("Primeiro: \t" + valor); // 2
Console.WriteLine("Segundo: \t" + valor++); // 2
Console.WriteLine("Terceiro: \t" + valor); // 3
Console.WriteLine("Quarto: \t" + (++valor)); // 4