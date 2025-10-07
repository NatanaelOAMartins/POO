using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidaCPFcomEcecao
{
    class CPFQtdeDigitosException : Exception
    {
        public CPFQtdeDigitosException() : base("O CPF deve ter 11 digitos") { }     
        
    }
}
