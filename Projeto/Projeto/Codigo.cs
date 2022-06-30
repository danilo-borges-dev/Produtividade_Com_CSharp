Console.WriteLine("Hello World!");

DateTime hoje = DateTime.Now;
DateTime ontem = hoje.AddDays(-1);
DateTime amanha = hoje.AddDays(1);
Console.WriteLine($"Ontem: {ontem:dd/MM/yyyy}");
Console.WriteLine($"Hoje: {hoje:dd/MM/yyyy}");
Console.WriteLine($"Amanhã: {amanha:dd/MM/yyyy}");
