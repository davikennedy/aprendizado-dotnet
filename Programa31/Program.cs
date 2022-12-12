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
            Console.WriteLine("Não é possível fazer uma divisão por zero!");
            Console.WriteLine(excecao.Message);
            Console.WriteLine(excecao.StackTrace);
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Aconteceu um erro!");
        }
        
        Console.ReadLine();
    }
    static int Dividir (int numero, int divisor)
    {
        try
        {
            return numero / divisor;
        }
        catch
        {
            Console.WriteLine($"Exceção com número = {numero} e divisor = {divisor}");
            throw;
        }
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