/*
    Desafio: Implementar regras de negócios.
    Se o usuário for um administrador com um nível maior que 55, exiba a mensagem: Welcome, Super Admin user.
    Se o usuário for um administrador com um nível menor ou igual a 55, exiba a mensagem: Welcome, Admin user.
    Se o usuário for um gerente com um nível maior ou igual a 20, exiba a mensagem: Contact an Admin for access.
    Se o usuário for um gerente com um nível menor que 20, exiba a mensagem: You do not have sufficient privileges.
    Se o usuário não for um administrador nem um gerente, exiba a mensagem: You do not have sufficient privileges.
*/

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin")) {
    if (level > 55) {
        Console.WriteLine("Welcome, Super Admin user.");
    } else {
        Console.WriteLine("Welcome, Admin user.");
    }
} 

else if (permission.Contains("Manager")) {
    if (level >= 20) {
        Console.WriteLine("Contact an Admin for access.");
    } else {
        Console.WriteLine("You do not have sufficient privileges.");
    }
} 

else {
    Console.WriteLine("You do not have sufficient privileges.");
}