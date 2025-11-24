using System;
public class Program
{
    public static void Main()
    {
        while (true)
        { 
            try
            {
                Console.WriteLine("Digite o nome do produto:");
                string name = Console.ReadLine();
                if (name == "")
                {
                    throw new ArgumentException("O nome nao pode ser vazio.");
                }
                Console.WriteLine("Digite o preco do produto:");
                double preco = double.Parse(Console.ReadLine());
                if (preco <= 0)
                {
                    throw new ArgumentException("O preco nao pode ser menor ou igual a zero.");
                }
                break;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Formato invalido, digite corretamente.");
            }
        }
    }
}