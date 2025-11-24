public class Program
{

    public static void Main()
    {
        
        Boolean valido = false;

        while (!valido)
        {
            try
            {
                Console.WriteLine("Digite um número inteiro:");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Numero convertido para int: " + numero);
                valido = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
            }
        }


    }
}