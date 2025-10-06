using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_TratamentoExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            while (true)
            {
                Console.WriteLine("Digite o numero inteiro:");
                try
                {
                    numero = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Numero invalido, informe apenas valor inteiro!\nPressione qualquer tecla para continuar ");                  
                }
                finally
                {
                    Console.Clear();
                }

            }
            if (numero % 2 == 0)
            
                Console.WriteLine("O numero é par");            
            else
                Console.WriteLine("O numero é impar");
        }
    }
}
