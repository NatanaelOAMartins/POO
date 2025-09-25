
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //<generic>
            List<string> nomes = new List<string>();
            nomes.Add("Suely");
            nomes.Add("Celso");

            List<Aluno> alunos = new List<Aluno>();
            Aluno suely = new Aluno { Id = 1, Nome = "Suely"};
            AlunoEspecial celso = new AlunoEspecial { Id = 2, Nome = "Celso", Deficiencia = "Mudo" };
            alunos.Add(suely);
            alunos.Add(celso);

            alunos.Add(new Aluno { Id = 3, Nome = "gustavo" });
            nomes.Add(suely.Nome);

            Console.WriteLine("Impressão dos Nomes:");
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("Impressão dos Alunos:");
            foreach (Aluno aluno in alunos)
            {
               aluno.ImprimirAluno();
            }

        }
    }
    class Aluno
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public double[] Nota { get; set; }
        public virtual  void ImprimirAluno()
        {
            Console.WriteLine($"-Id: {this.Id}, Nome: {this.Nome}");
        }

    }
    class AlunoEspecial : Aluno
    {
        public string Deficiencia { get; set; }
        public override void ImprimirAluno()
        {
            Console.WriteLine($"-id: {this.Id}, Nome: {this.Nome} - {this.Deficiencia}");
        }
    }
}
