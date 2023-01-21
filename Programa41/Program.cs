using System;
using System.Text;

namespace GenericsConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator<StringBuilder> c1 = new Creator<StringBuilder>();
            StringBuilder sb = c1.Create();

            Console.ReadKey();
        }
    }

    // public class Creator<T> where T : struct, new()
    // public class Creator<T> where T : class, IInterfaceNome, new()
    public class Creator<T> where T : class, new()
    {
        public T Create()
        {
            return new T();
        }
    }
}