using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta("999-88");
            conta.setNome  ("Natanael Martins");
            //conta.Numero = "1234";
            //conta.Saldo = -1000.00m;
            conta.Depositar(-1000.00m);

            conta.setSaldo(1000.00m);
            conta.ImprimirSaldo();

            while (true)
            {
                Console.WriteLine("Informe a Operação: [D]-Depositar, [S]Sacar ou [E]-Sair");
                string operacao = Console.ReadLine();

                if (operacao.ToUpper() == "D")
                {
                    Console.WriteLine("Informe o valor para Deposito:");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "S")
                {
                    Console.WriteLine("Informe o valor para saque:");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorSaque);
                    conta.ImprimirSaldo();
                }
                if (operacao.ToUpper() == "E")
                {
                    Console.WriteLine($"conta: {conta.getNumero()} Nome:{conta.getNome()} Saldo:{conta.getSaldo():c2}");
                    break;
                }
                else
                {
                    
                    Console.WriteLine("Informe apenas as letras [D] para Depositar, [S] para Sacar ou [E] para sair:");
                     
                }
            }
        }
    }
    public class Conta
    {
        private string numero;
        private string nome;

        public Conta(string numero)
        {
            this.numero = numero;
        }

        //Transformar conta Saldo com acesso privado
        //public decimal Saldo;
        private decimal saldo;
        public decimal getSaldo()
        {
            return saldo;

        }

        public void setSaldo(decimal saldo)
        {
            this.Depositar(saldo);
        }
        public string getNumero()
        {
            return numero;
        }
        public string getNome()
        {
            return nome; 
             
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)              
            saldo += valor;
            else
                Console.WriteLine("Valor de deposito incorreto, ele deve ser maior que zero");
        }
        public void Sacar(decimal valor)
        {
            saldo -= valor;
        }
        public void ImprimirSaldo()
        {
            Console.WriteLine($"Saldo Atual: {saldo:c2}");
        }
    }
}
