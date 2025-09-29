using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> diaDaSemanaSemEnum = new List<int> { 0, 1, 2, 3, 4, 5, 6 };
             List<int> diaDaSemanaSemEnum = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            foreach (var item in diaDaSemanaSemEnum)
            {
                if (item == 1) Console.WriteLine("Domingo - numero: 1");
                else if (item == 2) Console.WriteLine("Segunda - numero: 2");
                else if (item == 3) Console.WriteLine("Terça - numero: 3");
                else if (item == 4) Console.WriteLine("Quarta - numero: 4");
                else if (item == 5) Console.WriteLine("Quinta - numero: 5");
                else if (item == 6) Console.WriteLine("Sexta - numero: 6");
                else if (item == 7) Console.WriteLine("Sábado - numero: 7");
            }
            Console.WriteLine("\n\nCom a utilização do Enum");
            List<DiaDaSemana>diaDaSemanaComEnum = new List<DiaDaSemana>() { DiaDaSemana.Domingo, DiaDaSemana.Segunda, DiaDaSemana.Terca, DiaDaSemana.Quarta, DiaDaSemana.Quinta, DiaDaSemana.Sexta, DiaDaSemana.Sabado };

            foreach (var item in diaDaSemanaComEnum)
            {
                Console.WriteLine(item.ToString($"{item} Número: {(int)item}"));

            }
        }
    }

    public enum DiaDaSemana
    {
        Domingo,
        Segunda,
        Terca,
        Quarta,
        Quinta,
        Sexta,
        Sabado,
    }
}
