using System;
using System.Text;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> lista = new Lista<int>();

            lista.Adicionar(10);
            lista.Adicionar(20);
            lista.Adicionar(30);

            int e1 = lista.Ler(0);
            int e2 = lista.Ler(1);
            int e3 = lista.Ler(2);

            Console.WriteLine($"{e1}, {e2}, {e3}");
            Console.ReadKey();            
        }
    }
}
