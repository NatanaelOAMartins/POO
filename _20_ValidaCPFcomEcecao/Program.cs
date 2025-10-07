using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using _20_ValidaCPFcomEcecao;
using _20_ValidaCPFComExecao;

namespace _20_ValidaCPFComExecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o CPF");
            //string cpf = Console.ReadLine();

            //CPF numero = new CPF(cpf);
            IDocumento documento;
            while (true)
            {
                Console.WriteLine("Digite o CPF");
                try
                {
                    documento = new CPF(Console.ReadLine());
                    break;
                }
                catch (CPFQtdeDigitosException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (CPFMesmoNumeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"CPF Inválido!{ex.Message}");
                    Console.ReadLine();
                    continue;
                }
                finally
                {
                    Console.Clear();
                    Console.WriteLine("Pressione qualquer tecla para cintinuar");
                    Console.ReadKey();
                }
            }
            if (documento.Validar())
                Console.WriteLine($"Documento válido");
            else
                Console.WriteLine($"Documento inválido");

            //Console.WriteLine("Informe o CPF");
            //CPF cpf = new CPF(Console.ReadLine());
            //                 OU
            //IDocumento documento = new CPF(Console.ReadLine());

            //if(cpf.Validar())
            //    Console.WriteLine("CPF válido")
            //else
            //    Console.WriteLine("CPF inválido")


        }



    }
}


