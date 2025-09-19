using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do aluno: ");
            //string nome = Console.ReadLine();
            //Aluno aluno = new Aluno(nome);
            Aluno aluno = new Aluno(Console.ReadLine());

            Console.Write("Informe a Idade: ");
            aluno.Idade = int.Parse(Console.ReadLine());

            Console.Write("Informe a 1ª Nota: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a 2ª Nota: ");
            aluno.Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Nome: {aluno.Nome} Idade {aluno.Idade} 1º Nota: {aluno.Nota1} 2ª Nota: {aluno.Nota2} Média: {aluno.Media} Situação: {aluno.Situacao}");
        }
    }
}
