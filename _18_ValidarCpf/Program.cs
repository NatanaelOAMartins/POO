// Program.cs
using System;
using System.Xml.Linq;
using _18_ValidarCpf;
using ValidaCPF;

class Program
{
    static void Main()
    {
        Console.Write("Digite o CPF: ");
        string cpfDigitado = Console.ReadLine();

        // Polimorfismo: usamos a interface para instanciar
        IDocumento documento = new CPF(cpfDigitado);

        if (documento.Validar())
            Console.WriteLine($"CPF {documento.Numero} é válido!");
        else
            Console.WriteLine($"CPF {documento.Numero} é inválido!");
    }
}
