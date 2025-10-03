using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ValidarCpf
{
    internal interface IDocumento
    {
        string Numero { get; }
        bool Validar();
    }
}
