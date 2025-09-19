using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace _08_Aluno
{
    internal class Aluno
    {
        private string nome;
        public string Nome { get { return nome; } }

        private int idade;
        public int Idade
        {
            get { return idade; }
            set
            {
                if (value >= 0)
                    idade = value;
                else
                    Console.WriteLine("Idade Inválida");
            }
        }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Media { get { return (Nota1 + Nota2) / 2; } }
        public string Situacao { get { return (Media >= 6) ? "Aprovado" : "Reprovado"; } }
        public Aluno(string nome)
        {
            this.nome = nome;
        }
    }
}