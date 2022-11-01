namespace Aplicacao 
{
    class App 
    {
        static void Main () 
        {
            string firstName = "Bob";
            int qtdMessages = 3;
            decimal temperatura = 34.4m;

            Console.Write("Hello, ");
            Console.Write(firstName);
            Console.Write("! You have ");
            Console.Write(qtdMessages);
            Console.Write(" messages in your inbox. The temperature is ");
            Console.Write(temperatura);
            Console.Write(" celsius.");
        }
    }
}