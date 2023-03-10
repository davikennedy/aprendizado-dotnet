var array = new int[3];

try
{
    /* for (int index = 0; index < 10; index++)
    {
        Console.WriteLine(array[index]);
    } */
    Cadastrar("");
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine(e.InnerException);
    Console.WriteLine(e.Message);
    Console.WriteLine("O índice informado não existe na list");
}
catch (ArgumentNullException e)
{
    Console.WriteLine(e.InnerException);
    Console.WriteLine(e.Message);
    Console.WriteLine("Insira um texto!");
}
catch (Exception e)
{
    Console.WriteLine(e.InnerException);
    Console.WriteLine(e.Message);
    Console.WriteLine("Ops, algo deu errado!");
}
finally
{
    Console.WriteLine("Chegou ao fim!");
}

static void Cadastrar(string texto)
{
    if (string.IsNullOrEmpty(texto))
        throw new ArgumentNullException("O texto não pode ser nulo ou vazio.");
}