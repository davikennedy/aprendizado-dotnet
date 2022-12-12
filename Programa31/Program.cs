class Program 
{
    static void Main(string[] args) 
    {
        try
        {
            Metodo();
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Não é possível fazer uma divisão por zero!");
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
        }
        catch (Exception e)
        {
            Console.WriteLine("Aconteceu um erro!");
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
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