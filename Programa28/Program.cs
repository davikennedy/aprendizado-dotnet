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
        Console.WriteLine("");

        // O Array.Resize serve para redimensionar um array, conforme o novo tamanho informado
        Array.Resize(ref paletes, 6);
        Console.WriteLine($"Redimensionando 6 ... Quantidade: {paletes.Length}");

        paletes[4] = "C01";
        paletes[5] = "C02";

        foreach (var palete in paletes)
        {
            Console.WriteLine($"-- {palete}");
        }
        Console.WriteLine("");

        // O Array.Resize também serve para diminuir o tamanho de um array
        Array.Resize(ref paletes, 3);
        Console.WriteLine($"Redimensionando 3 ... Quantidade: {paletes.Length}");

        foreach (var palete in paletes)
        {
            Console.WriteLine($"-- {palete}");
        }

        Console.WriteLine("Tecle Enter para encerrar");
        Console.ReadLine();
    }
}