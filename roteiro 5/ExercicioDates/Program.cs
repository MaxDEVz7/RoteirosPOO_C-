using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Data do seu compromisso: ");
        string entrada = Console.ReadLine();
        DateTime data;
        DateTime.TryParse(entrada, out data);

        DateTime agora = DateTime.Now;
        Console.WriteLine("Agora: " + agora);

        TimeSpan diferenca = data - agora;
        Console.WriteLine($"Seu compromisso será em : {diferenca.TotalDays:F0} dias, na {data.DayOfWeek}");
        Console.WriteLine($"Data Marcada: {data}");
    }
}