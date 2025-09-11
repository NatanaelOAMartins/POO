using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(5);
            quadrado.ImprimeArea();

            Retangulo retangulo = new Retangulo(15, 10);
            retangulo.ImprimeArea();

            Circulo circulo = new Circulo(7.5);
            circulo.ImprimeArea();

            Triangulo triangulo = new Triangulo(12.75, 25.5);
            triangulo.ImprimeArea();

        }
    }
    public class Quadrado
    {
        //Modificar de acesso Private 
        //pode ser acessado apenas dentro da classe
        private int Lado;

        //
        public Quadrado():this(5)
        {
            //this.Lado = 0;
        }

        public Quadrado(int Lado)
        {
            
            if(Lado > 0)
                this.Lado = Lado;
            

        }

        public int CalcularArea()
        {
            return Lado * Lado;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Quadrado com lado de {Lado} possui uma àrea de   {CalcularArea()}");
        }
    }
    public class Retangulo
    {
        private int Largura , Altura;
        
        public Retangulo(int Largura, int Altura)
        {
            this.Largura = Largura; this.Altura = Altura;
        }
        private int CalcularArea()
        {
            return Largura * Altura;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Retângulo com largura de {Largura} e altura de {Altura} possui uma àrea de   {CalcularArea()}");
        }
    }
    public class Circulo
    {
        private double Raio;
        private const double Pi = 3.14;
        public Circulo(double Raio)
        {
            this.Raio = Raio;
        }
        private double CalcularArea()
        {
            return Pi * (Raio * Raio);
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Círculo com raio de {Raio} possui uma àrea de   {CalcularArea()}");
        }
    }
    public class Triangulo 
    {
        private double Base, Altura;
        public Triangulo(double Base, double Altura)
        {
            this.Base = Base; this.Altura = Altura;
        }
        private double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Triângulo com base de {Base} e altura de {Altura} possui uma àrea de   {CalcularArea()}");
        }
    }
        
    
}
