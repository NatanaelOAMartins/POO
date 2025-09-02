using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DeclaracaoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado obj1 = new Quadrado();
            obj1.Lado = 5;
            obj1.ImprimeArea();
            obj1.Lado = 15;
            obj1.ImprimeArea();

            Quadrado obj2 = new Quadrado();
            obj2.Lado = 25;
            obj2.ImprimeArea();

            Retangulo num1 = new Retangulo();
            num1.Base = 5;
            num1.Altura = 15;
            num1.ImprimeArea();

            Circulo num2 = new Circulo();
            num2.raio = 5;
            num1.ImprimeArea();

            triangulo num3 = new triangulo();
            num3.Base = 15;
            num3.Altura = 25;
            num3.InprimirArea();
        }
    }
    public class Quadrado
    {
        public int Lado;
        public int CalculaArea()
        {
            int area = Lado * Lado;
            return area;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Quadrado com lado de {Lado}possui uma area de {CalculaArea()}");
        } 
    }
     public class Retangulo 
    {
        public int Altura;
        public int Base;
        public int CalculoArea()
        {
            int area = Altura * Base;
            return area;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Retangulo com Altura de {Altura} E base de {Base}, possui Area de {CalculoArea()}");
        }
    }

    public class Circulo 
    {
        public double raio;
        public double CalculoArea() 
        {
            return Math.PI * (raio * raio);
        }
        public void ImprimeArea() 
        {
            Console.WriteLine($"Circulo com raio de {raio:N2} possui Area de {CalculoArea()}");
        }
    }
    public class triangulo


    {

        public int Base;
        public int Altura;

        public double CalculoArea()
        {
            return (Base * Altura) / 2;
        }
        public void InprimirArea()
        {
            Console.WriteLine($"Triangulo com a Base de {Base:N2} e Altura de {Altura} {CalculoArea()}");
        }
    }
}
