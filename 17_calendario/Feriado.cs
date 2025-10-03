
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace _17_Calendario
{
    internal class Feriado : IComparable<Feriado>
    {
        public int Dia { get; set; } // dia do feriado
        public string Descricao { get; set; } // descrição do feriado
        public Feriado(int dia, string descricao) // construtor
        {
            this.Dia = dia;
            this.Descricao = descricao;

        }
        public int CompareTo(Feriado other) // método para comparar dois feriados
        {
            if(other == null) return 1;
            return this.Dia.CompareTo(other.Dia); // compara os dias dos feriados
        }   

    }
}