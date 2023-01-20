using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            lista.Adicionar(10);
            lista.Adicionar(20);
            lista.Adicionar(30);

            int e1 = (int)lista.Ler(0);
            int e2 = (int)lista.Ler(1);
            int e3 = (int)lista.Ler(2);

            Console.WriteLine($"{e1}, {e2}, {e3}");
            Console.ReadKey();
        }
    }
}
