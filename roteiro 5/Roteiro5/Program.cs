using System;
class Program
{
    static void Main()
    {

        Console.WriteLine("digite uma frase com espaços no início e no fim, e com palavras separadas por vírgulas:");
        string frase = Console.ReadLine();
        Console.WriteLine("Original: '" + frase + "'");
        frase = frase.Trim();
        Console.WriteLine("Trim: '" + frase + "'");
        String[] palavras = frase.Split();


        foreach (string palavra in palavras)
        {
            Console.WriteLine("palavras split: " + palavra);
        }
        Console.WriteLine("Replace: " + frase.Replace("teste", "testando"));

        Console.WriteLine("Frase inicia com 'Olá'? " + frase.StartsWith("Olá"));
        Console.WriteLine("Frase inicia com 'Mundo'? " + frase.EndsWith("Mundo"));
    }
}