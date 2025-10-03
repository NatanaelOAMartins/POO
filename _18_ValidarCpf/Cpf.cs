// CPF.cs
using System.Text.RegularExpressions;
using System.Xml.Linq;
using _18_ValidarCpf;

namespace ValidaCPF
{
    public class CPF : IDocumento
    {
        public string Numero { get; }

        public CPF(string numero)
        {
            // Remove tudo que não é número
            Numero = Regex.Replace(numero, @"[^\d]", "");
        }

        public bool Validar()
        {
            if (Numero.Length != 11)
                return false;

            // Verifica se todos os dígitos são iguais
            bool todosIguais = true;
            for (int i = 1; i < Numero.Length; i++)
            {
                if (Numero[i] != Numero[0])
                {
                    todosIguais = false;
                    break;
                }
            }
            if (todosIguais) return false;

            // Cálculo dos dígitos verificadores
            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = Numero.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            int digito1 = (resto < 2) ? 0 : 11 - resto;

            tempCpf += digito1;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            int digito2 = (resto < 2) ? 0 : 11 - resto;

            string digitosVerificadores = digito1.ToString() + digito2.ToString();

            return Numero.EndsWith(digitosVerificadores);
        }
    }
}
