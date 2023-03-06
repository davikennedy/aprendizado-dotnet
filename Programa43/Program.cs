var data = DateTime.Now;
// var dataFormatada = String.Format("{0:T}", data); // 22:58:06 (Exemplo)
// var dataFormatada = String.Format("{0:t}", data); // 22:57 (Exemplo)
// var dataFormatada = String.Format("{0:d}", data); // sexta-feira, 27 de janeiro de 2023 (Exemplo)
// var dataFormatada = String.Format("{0:R}", data); // Fri, 27 Jan 2023 23:01:28 GMT (Exemplo)
// var dataFormatada = String.Format("{0:r}", data); // Fri, 27 Jan 2023 23:04:13 GMT (Exemplo)
// var dataFormatada = String.Format("{0:s}", data); // 2023-01-27T23:04:40 (Exemplo)
var dataFormatada = String.Format("{0:u}", data); // 2023-01-27 23:05:04Z (Exemplo)

// Alterando valores das datas
Console.WriteLine(dataFormatada);
Console.WriteLine(data.AddDays(-12));
Console.WriteLine(data.AddMonths(-12));
Console.WriteLine(data.AddYears(-12));


// Comparando datas
var data1 = DateTime.Now;

if (data1.Date == DateTime.Now.Date)
{
    Console.WriteLine("É igual");
}

// Lidando com TimeSpan
var timeSpan = new TimeSpan();
Console.WriteLine($"timeSpan = {timeSpan}");

var timeSpanNanosegundos = new TimeSpan(1);
Console.WriteLine($"timeSpanNanosegundos = {timeSpanNanosegundos}");

var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
Console.WriteLine($"timeSpanHoraMinutoSegundo = {timeSpanHoraMinutoSegundo}");

// Lidando com dias da semana
static bool IsWeekend(DayOfWeek today)
{
    return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
}

Console.ReadLine();
