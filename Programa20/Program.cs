/*
    Desafio: Implementar as seguintes regras de jogo

    - O herói e o monstro começarão com dez pontos de integridade
    - Todos os ataques serão um valor entre 1 e 10
    - O herói atacará primeiro
    - Imprima a quantidade de integridade que o monstro perdeu e a integridade que resta a ele
    - Se a integridade do monstro for maior que zero, ele poderá atacar o herói
    - Imprima a quantidade de integridade que o herói perdeu e a integridade que resta a ele
    - Continue esta sequência de ataque até que a integridade do monstro ou do herói seja zero ou menos
    - Imprima quem foi o vencedor
*/

Random random = new Random();
int ataque = 0;
int integridadeHeroi = 10;
int integridadeMonstro = 10;

do {
    ataque = random.Next(1, 11);
    integridadeMonstro -= ataque;
    Console.WriteLine($"O monstro foi danificado e perdeu {ataque} de saúde e agora tem {integridadeMonstro}");
    
    if (integridadeMonstro <= 0) {
        Console.WriteLine($"O herói venceu!");
        break;
    } 
    else {
        ataque = random.Next(1, 11);
        integridadeHeroi -= ataque;
        Console.WriteLine($"O herói foi danificado e perdeu {ataque} de saúde e agora tem {integridadeHeroi}");
        
        if (integridadeHeroi <= 0) {
            Console.WriteLine($"O monstro venceu!");
            break;
        } 
    }
} while (integridadeMonstro > 0);