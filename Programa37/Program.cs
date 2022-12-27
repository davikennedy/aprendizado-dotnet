// Aprendendo a utilizar expressões regulares com Regex
using System.Text.RegularExpressions;

string padraoTelefone = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
string texto = "Meu número de contato é 8574-9741";

Match telefoneObtido = Regex.Match(texto, padraoTelefone);
System.Console.WriteLine(telefoneObtido.Value);