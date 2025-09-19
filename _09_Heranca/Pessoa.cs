using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal abstract class Pessoa
    {
        public int Id;
        public string Nome ; 
        public string Telefone ;
        public abstract string GetDocumento();
        public void Imprimir() 
        {
          Console.WriteLine($"LISTA DE PESSOAS\n\nNome: {this.Nome} Documento {this.GetDocumento()} Telefone: {this.Telefone}");
        }
        public override string ToString()
        {
            return $"<toString()> Nome: {this.Nome} Documento {this.GetDocumento()} Telefone: {this.Telefone}";
        }
        public override bool Equals(object obj)
        {
            if(obj == null)
                return false;
            //Cast=> Conversão de objetos
            //( (Pessoa)obj)=> converte obj que é do tipo object para o tipo Pessoa
            return this.Id == ((Pessoa)obj).Id;
        }
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
