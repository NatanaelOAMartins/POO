using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ColecaoPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();
            Console.WriteLine("Digite 5 números inteiros:");
            for (int i = 1; i < 5; i++)
            {
                Console.Write($"Número {i}:");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    numeros.Push(valor);
                }
                else
                {
                    Console.WriteLine("Valor inválido, tente novamente!");
                        i--;
                }
            }
            Console.WriteLine($"\nÚltimo número inserido: {numeros.Peek()}");
        }
    }
}
