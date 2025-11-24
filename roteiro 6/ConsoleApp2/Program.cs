public class Program
{

    public static void Main()
    {
        string numero = Console.ReadLine();
        Boolean valido = false;

        while (!valido)
        {
            try
            {
                double numeroDouble = double.Parse(numero);
                Console.WriteLine("Numero convertido: " + numeroDouble + "C°");
                valido = true;
            }
            catch (FormatException)
            {
                //throw new FormatException("Formato invalido"); Primeira parte do exercício.
                Console.WriteLine("Formato invalido");
                numero = Console.ReadLine();
            }
        }
            
        
    }
}