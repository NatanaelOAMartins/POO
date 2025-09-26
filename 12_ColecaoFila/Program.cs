using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ColecaoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();
            Console.WriteLine("Escreva os nomes para a fila com no mínimo 3 caracteristicas");
            while (fila.Count < 5)
            {
                Console.Write($"Nome {fila.Count + 1}: ");
                string nome = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nome) && nome.Length >= 3)
                    fila.Enqueue(nome);
                else
                    Console.WriteLine($"nome Inválido!");
            }
            Console.WriteLine("\n_____Atendimentos_____");
            for (int i = 1; i <= 3; i++)
            {
                if(fila.Count > 0)
                    Console.WriteLine($"{i}º atendido: {fila.Dequeue()}");
            }
            Console.WriteLine("\n_____Ainda na Fila_____");
            foreach (string pessoa in fila)
                Console.WriteLine(pessoa);
        }
    }
}
