using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> filaAtendimento = new Queue<string>();
        bool valido = true;
        while (valido)
        {
            Console.Write("Qual operação você deseja fazer no programa de fila de atendimento? (1) adicionar cliente, (2) atender próximo, (3) ver tamanho da fila, (4) sair: ");
            int operacao = int.Parse(Console.ReadLine());
            if (operacao == 1)
            {
                Console.Write("Qual o nome do cliente que você deseja adicionar à fila: ");
                string nomeCliente = Console.ReadLine();
                
                filaAtendimento.Enqueue(nomeCliente);
                Console.WriteLine($"Cliente '{nomeCliente}' adicionado à fila.");
            }
            else if (operacao == 2)
            {
                string cliente = filaAtendimento.Peek();
                filaAtendimento.Dequeue();
                Console.WriteLine($"cliente: {cliente} atendido.");
            }
            else if (operacao == 3)
            {
                Console.WriteLine($"Tamanho da fila: {filaAtendimento.Count()} clientes."); // Substituir X pelo tamanho real
            }
            else if (operacao == 4)
            {
                valido = false;
            }
            else
            {
                Console.WriteLine("Operação inválida.");
            }
        }
    }
}