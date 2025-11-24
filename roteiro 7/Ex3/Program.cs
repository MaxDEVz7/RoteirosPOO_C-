using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> numerosUnicos = new HashSet<int>();
        bool valido = true;
        while (valido)
        {
            Console.Write("Digite um número inteiro (ou 0 para encerrar): ");
            int numero = int.Parse(Console.ReadLine());
            if (numero == 0)
            {
                valido = false;
                break;
            }
            numerosUnicos.Add(numero);
        }
        Console.WriteLine("Números únicos digitados:");
        foreach (var num in numerosUnicos)
        {
            Console.WriteLine(num);
        }
    }
}