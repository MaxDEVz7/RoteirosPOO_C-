using System;
class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite um número: ");
            double input = Double.Parse(Console.ReadLine());
            Console.WriteLine($"O número original: {input}");
            Console.WriteLine($"O número arredondado para baixo: {Math.Floor(input)}");
            Console.WriteLine($"O número arredondado para cima: {Math.Ceiling(input)}");
            Console.WriteLine($"O número truncado: {Math.Truncate(input)}");
        }
    }
}