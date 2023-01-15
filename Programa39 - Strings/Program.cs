// Criando id's com o uso de Guid
var id = Guid.NewGuid();
id.ToString();

id = new Guid("c618ef17-931a-4dc4-9adc-6dd1c78baf0d");

id = new Guid(); // Esse código vai atribuir o valor 00000000-0000-0000-0000-000000000000 para o id

Console.WriteLine(id);
