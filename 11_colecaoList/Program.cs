using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ColecaoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            Console.WriteLine("Digite 5 nomes com no mínimo 3 caracteres:");
            while (nomes.Count < 5)
            {
                Console.Write($"Nome {nomes.Count + 1}: ");
                string nome = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(nome) && nome.Length >= 3)
                    nomes.Add(nome);
                else
                    Console.WriteLine("Nome Inválido!");
            }

            Console.WriteLine("\n_____LISTA DE NOMES_____");
            foreach (string nome in nomes) 
                Console.WriteLine(nome);
        }
    }
}
