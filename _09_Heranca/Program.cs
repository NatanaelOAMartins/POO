using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nao posso instanciar uma classe abstrata
            //Pessoa p = new Pessoa();
            Pessoa[] pessoas = new Pessoa[2];

            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoas[0] = pessoaFisica;
            pessoaFisica.Nome = "Affonso";
            pessoaFisica.CPF = "999.999.999-99";
            pessoaFisica.Telefone = "(14) 99999-9999";
            pessoaFisica.Imprimir();

            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoas[1] = pessoaJuridica;
            pessoaJuridica.Id = 1;
            pessoaJuridica.Nome = "Senac Marília";
            pessoaJuridica.CNPJ = "99.999.999/0001-99";
            pessoaJuridica.Telefone = "(014) 9999-9999";
            pessoaJuridica.Imprimir();

            Console.WriteLine(pessoaFisica);
            Console.WriteLine(pessoaJuridica);

            if (pessoaFisica.Equals(pessoaJuridica)) 
                Console.WriteLine("São iguais");
            else
                Console.WriteLine("São pessoas diferenres");

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }

    }
}
