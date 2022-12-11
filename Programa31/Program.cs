class Program 
{
    static void Main(string[] args) 
    {
        try
        {
            Metodo();
        }
        catch (DivideByZeroException excecao)
        {
            Console.WriteLine(excecao.Message);
            Console.WriteLine(excecao.StackTrace);
        }
        
        Console.ReadLine();
    }
    static int Dividir (int numero, int divisor)
    {
        return numero / divisor;
    }

    static void Metodo()
    {
        TestaDivisao(0);
    }

    static void TestaDivisao(int divisor) 
    {
        Dividir(10, divisor);
    }
}