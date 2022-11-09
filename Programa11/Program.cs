/*
    Desafio:
    Nossa equipe detectou um padrão. Pedidos que começam com a letra "B" 
    têm um número de fraudes 25 vezes maior que o normal. Vamos escrever 
    um novo código para gerar a ID de novos pedidos, em que a ID do pedido 
    começa com a letra "B". Isso será usado por nossa equipe de fraudes 
    para investigar ainda mais.
*/

string[] pedidos = {"B123","C234","A345","C15","B177","G3003","C235","B179"};

foreach(string pedido in pedidos) {
    if(pedido.StartsWith("B")) {
        Console.WriteLine($"Pedido: {pedido}"); // Saída Pedido: B123 | Pedido: B177 | Pedido: B179

    }
}