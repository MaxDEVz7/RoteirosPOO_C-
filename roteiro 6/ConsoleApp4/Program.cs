using ConsoleApp4;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{

    public static void Main()
    {
        bool valido = false;
        
        while (!valido)
        {
            try
            {
                Console.WriteLine("Digite sua idade:");
                int idade = int.Parse(Console.ReadLine());
                VerificaIdade(idade);
                valido = true;
            }
            catch (ExeceptionMax e)
            {
                Console.WriteLine(e.Message.ToString()); 
            }
        }
    }

    public static void VerificaIdade(int idade)
    {
        if (idade < 18)
        {
            throw new ExeceptionMax("Erro: Idade mínima para acesso é 18 anos.");
        }
        if (idade >= 18)
        {
            Console.WriteLine("Acesso permitido.");
        }
    }
}