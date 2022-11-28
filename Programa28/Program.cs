using System;

class Program 
{ 
    static void Main(string[] args)
    {
        string[] paletes = { "B14", "A11", "B12", "A13" };
        Console.WriteLine("");

        // O Array.Clear serve para limpar elementos de um array, dentro da sequência informada
        Array.Clear(paletes, 0, 2);
        Console.WriteLine($"Limpando 2 ... Quantidade: {paletes.Length}");

        foreach (var palete in paletes)
        {
            Console.WriteLine($"-- {palete}");
        }

        Console.WriteLine("Tecle Enter para encerrar");
        Console.ReadLine();
    }
}