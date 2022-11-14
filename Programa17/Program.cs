/*
    Aprendendo a utilizar a instrução switch
*/

int empregadoNivel = 200;
string empregadoNome = "João Alves";

string titulo = "";

switch (empregadoNivel) {
    case 100:
        titulo = "Associado Júnior";
        break;
    case 200:
        titulo = "Associado Sênior";
        break;
    case 300:
        titulo = "Gerente";
        break;
    case 400:
        titulo = "Gerente Sênior";
        break;
    default: // Não é obrigatório definir um rótulo 'default', mas é muito útil para utilizar como "opção padrão" ou mesmo, como "última opção"
        titulo = "Associado";
        break;
}

Console.WriteLine($"{empregadoNome} - {titulo}");