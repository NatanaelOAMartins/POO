
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
            Aluno suely = new Aluno { Id = 1, Nome = "Suely" };
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
            Dictionary<int, string> dicNomes = new Dictionary<int, string>();
            dicNomes.Add(1, "suely");
            dicNomes.Add(2, "celso");
            dicNomes.Add(3, "gustavo");

            Console.WriteLine("Impressão do Dicionário:");
            for (int i = 1; i <= dicNomes.Count; i++)
            {
                Console.WriteLine($" - {dicNomes[i]}");
            }
            Dictionary<int, Aluno> dicAlunos = new Dictionary<int, Aluno>();
            dicAlunos.Add(suely.Id, suely);
            dicAlunos.Add(celso.Id, celso);

            Console.WriteLine("Impressão do DicAlunos:");
            //for (int i = 1; i <= dicAlunos.Count; i++) ;
            //{
            //    dicAlunos[i].ImprimirAluno();
            //}
            foreach (Aluno aluno in dicAlunos.Values)
            {
                aluno.ImprimirAluno();
            }
            Queue<string> filaNomes = new Queue<string>();
            filaNomes.Enqueue("Suely");
            filaNomes.Enqueue("Celso");
            filaNomes.Enqueue("Gustavo");


            Console.WriteLine("Impressão da Fila:");
            Console.WriteLine($" 1°){filaNomes.Dequeue()}");
            foreach (String nome in filaNomes)
            {
                Console.WriteLine($" - {nome}");
            }
            Stack<string> stackNomes = new Stack<string>();
            stackNomes.Push("Suely");
            stackNomes.Push("Celso");
            stackNomes.Push("Gustavo");
            Console.WriteLine("Impressão dos stackNomes:");
            Console.WriteLine($" 1°){stackNomes.Pop()}");

            foreach (String nome in stackNomes)
            {
                Console.WriteLine($" - {nome}");
            }
            HashSet<string> setNomes = new HashSet<string>();
            setNomes.Add("Suely");
            setNomes.Add("Celso");
            setNomes.Add("Gustavo");
            //vamos duplicar
            setNomes.Add("Suely");
            setNomes.Add("Celso");
            setNomes.Add("Gustavo");

            foreach (String nome in setNomes)
            {
                Console.WriteLine($" - {nome}");
            }

        }
    }
    class Aluno
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public double[] Nota { get; set; }
        public virtual void ImprimirAluno()
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
