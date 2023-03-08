var array = new int[3];

try
{
    for (int index = 0; index < 10; index++)
    {
        Console.WriteLine(array[index]);
    }
}
catch
{
    Console.WriteLine("Ops, algo deu errado!");
}