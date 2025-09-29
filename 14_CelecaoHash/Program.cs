using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CelecaoHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numeros = new HashSet<int>();
            int[] valores = { 1, 2, 3, 4, 5, 3, 2, 6, 7, 1 };

            foreach (int v in valores)
                numeros.Add(v);

            Console.WriteLine("_____Números sem duplicatas_____");
                foreach (int n in numeros)
                Console.WriteLine(n);
        }
    }
}
