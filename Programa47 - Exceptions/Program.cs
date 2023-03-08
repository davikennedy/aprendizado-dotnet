using System;
var array = new int[3];

try
{
    for (int index = 0; index < 10; index++)
    {
        Console.WriteLine(array[index]);
    }
}
catch (Exception e)
{
    Console.WriteLine(e.InnerException);
    Console.WriteLine(e.Message);
    Console.WriteLine("Ops, algo deu errado!");
}