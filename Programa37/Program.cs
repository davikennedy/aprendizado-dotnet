// Aprendendo a utilizar expressões regulares com Regex
using System.Text.RegularExpressions;

//string padraoTelefone = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
//string padraoTelefone = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
//string padraoTelefone = "[0-9]{4,5}[-][0-9]{4}";
//string padraoTelefone = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
//string padraoTelefone = "[0-9]{4,5}-{0,1}[0-9]{4}";
string padraoTelefone = "[0-9]{4,5}-?[0-9]{4}";
string texto = "Meu número de contato é 98574-9741";

Match telefoneObtido = Regex.Match(texto, padraoTelefone);
System.Console.WriteLine(telefoneObtido.Value);