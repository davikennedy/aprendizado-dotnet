// string[] nomes = {"Davi", "Késia", "Iago"};
// 
// foreach (string nome in nomes) {
//     Console.WriteLine(nome);
// }

int[] inventario = { 200, 450, 700, 175, 250 };
int soma = 0;
int caixa = 0;

foreach (int itens in inventario) {
	  soma += itens;
		caixa++;
    Console.WriteLine($"Caixa {caixa} = {itens} itens (Execução total: {soma})");
}

Console.WriteLine($"Nós temos {soma} itens no inventário.");