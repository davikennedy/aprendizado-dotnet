// Imprimir a sequência de Fibonacci (até o vigésimo elemento)

int atual = 1;
int anterior = 1;

for (int i = 1; i < 20; i++) {
    if (i == 1) {
        Console.WriteLine(anterior);
    }
    Console.WriteLine(atual);
    atual += anterior;
    anterior = atual - anterior;
}