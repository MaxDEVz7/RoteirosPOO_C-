using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase: ");
        string frase = Console.ReadLine();
        Stack<String> fraseInv = new Stack<string>();
        foreach (char c in frase)
        {
            fraseInv.Push(c.ToString());
        }
        Console.Write($"Frase invertida: ");
        while (fraseInv.Count > 0)
        {
            Console.Write(fraseInv.Pop());
        }
    }
}