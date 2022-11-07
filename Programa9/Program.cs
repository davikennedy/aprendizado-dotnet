using Internal;
using System;
/*
string[] pedidosFraudulentosIDs = new string[3];

pedidosFraudulentosIDs[0] = "A123";
pedidosFraudulentosIDs[1] = "B456";
pedidosFraudulentosIDs[2] = "C789";
*/

string[] pedidosFraudulentosIDs = {"A123", "B456", "C789"};

Console.WriteLine($"Primeiro: \t{pedidosFraudulentosIDs[0]}");
Console.WriteLine($"Segundo: \t{pedidosFraudulentosIDs[1]}");
Console.WriteLine($"Terceiro: \t{pedidosFraudulentosIDs[2]}");

pedidosFraudulentosIDs[0] = "F000";

Console.WriteLine($"Reatribuição do Primeiro ID: {pedidosFraudulentosIDs[0]}");

Console.WriteLine($"Há {pedidosFraudulentosIDs.Length} pedidos fraudulentos para processar.");