using System;
/*  using MeuNovoApp.Utilitarios;
    Dessa forma, a linha 13 poderia ser reduzida para "string fraseReversa = Utilitario.Reverse(frase);"
*/

namespace MeuNovoApp 
{
    class Programa
    {
        static void Main(string[] args)
        {
            string frase = "Microsoft Learn";
            string fraseReversa = MeuNovoApp.Utilitarios.Utilitario.Reverse(frase);
            Console.WriteLine(fraseReversa);
        }
    }
}

namespace MeuNovoApp.Utilitarios
{
    class Utilitario
    {
        public static string Reverse(string mensagem)
        {
            char[] letras = mensagem.ToCharArray();
            Array.Reverse(letras);
            return new string(letras);
        }
    }
}