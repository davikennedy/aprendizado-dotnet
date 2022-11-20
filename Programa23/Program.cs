// Aprendendo a utilizar o método TryParse()
string value = "120";
int resultado = 0;
if (int.TryParse(value, out resultado)) {
    Console.WriteLine($"Teste: {resultado}"); // 120
}
else {
    Console.WriteLine("O teste não foi bem-sucedido.");
}