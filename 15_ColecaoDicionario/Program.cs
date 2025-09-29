using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ColecaoDicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> alunos = new Dictionary<int, string>();

            Console.WriteLine("Cadastro de alunos (RA e Nome):");
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Digite o RA do aluno {i}: ");
                int ra = int.Parse(Console.ReadLine());
                
                string nome;
                do
                {
                    Console.Write("Digite o nome do aluno: ");
                    nome = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(nome) || nome.Length < 3)
                        Console.WriteLine("Nome inválido! Deve ter pelo menos 3 caracteres.");
                } while (string.IsNullOrWhiteSpace(nome) || nome.Length < 3);

                alunos.Add(ra, nome);
            }

            Console.WriteLine("\n--- Alunos cadastrados ---");
            foreach (var aluno in alunos)
                Console.WriteLine($"RA: {aluno.Key}, Nome: {aluno.Value}");
        }
    }
}
