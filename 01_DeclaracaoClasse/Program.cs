using System;

namespace _01_DeclaracaoClasse

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Quadrado obj1 = new Quadrado();
            obj1.Lado = 5;
            obj1.ImprimeArea();
            obj1.Lado = 10;
            obj1.ImprimeArea();
            Quadrado obj2 = new Quadrado();
            obj2.Lado = 15;
            obj2.ImprimeArea();
            Retangulo obj3 = new Retangulo();
            obj3.Base = 10;
            obj3.Altura = 20;
            obj3.ImprimeArea();
            Circulo obj4 = new Circulo();
            obj4.Raio = 5;
            obj4.ImprimeArea();
            Conta contaHanna = new Conta();
            contaHanna.Banco = 077;
            contaHanna.Agencia = "0001-9";
            contaHanna.Numero = "11133322256";
            contaHanna.Saldo = 1000;
            contaHanna.Limite = 5000;
            Console.WriteLine($"Saldo Atual: {contaHanna.ConsultaSaldo()}");
            contaHanna.Sacar(500);
            Console.WriteLine($"Saldo Atual: {contaHanna.ConsultaSaldo()}");

            //Aluno
            Aluno aluno1 = new Aluno();
            aluno1.Codigo = 1;
            aluno1.Nome = "Hanna";

            //inicializando o vetor com 4 posicoes
            aluno1.LancarNota(1, 9.6);
            aluno1.LancarNota(2, 8.0);
            aluno1.LancarNota(3, 9.5);
            aluno1.LancarNota(4, 10.0);
            Console.WriteLine($"Aluno: {aluno1.Nome}, Media: {aluno1.CalcularMedia():N1} , Situação: {aluno1.Mencao()}");

        }

    }

    public class Quadrado

    {

        public int Lado;
        public int CalculaArea()
        {
            //atributo
            int area = Lado * Lado;
            return area;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Quadrado com lado de {Lado}, possui Área de {CalculaArea()}");
        }

    }

    public class Retangulo

    {

        public int Base, Altura;

        public int CalculaArea()
        {
            return Base * Altura;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Retangulo com Altura de {Altura} e Base de {Base}, Possui Área de {CalculaArea()}");
        }

    }

    public class Circulo

    {

        public double Raio;
        public double CalculaArea()
        {
            return Math.PI * (Raio * Raio);
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Circulo com Raio de {Raio}, multiplicado por PI, Possui Àrea de {CalculaArea()}");
        }

    }

    public class Conta
    {

        public int Banco;
        public string Agencia;
        public string Numero;
        public double Saldo;
        public double Limite;

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public void Sacar(double valor)
        {
            Saldo -= valor;
        }
        public double ConsultaSaldo()
        {
            return Saldo;
        }

    }

    public class Aluno

    {

        public int Codigo;
        public string Nome;
        public double[] Notas = new double[4];
        public void LancarNota(int trimestre, double nota) //int trimestre, double nota, Professor fez assim

        {
            Notas[trimestre - 1] = nota;  //Notas[trimestre - 1] = nota;
        }

        public double CalcularMedia()

        {

            double media = 0; //local que vai acumular a soma das notas.

            for (int i = 0; i < Notas.Length; i++) //percorrer o vetor

            {

                media += Notas[i]; //acumular as notas

            }

            return media / Notas.Length; //retornar a media; Notas.Length = quantidade de notas

        }

        //public double CalcularMedia()    OBS: Outra forma de fazer a media, Professor fez assim

        //{

        //    double media = 0;

        //    foreach (double nota in Notas)

        //    {

        //        media += nota;

        //    }

        //}

        public string Mencao()

        {

            if (CalcularMedia() >= 5)
            {
                return "Aprovado";
            }

            else
            {
                return "Reprovado";
            }

        }


    }

}

