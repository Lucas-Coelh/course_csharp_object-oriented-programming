using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank_Herdado.Sistemas
{
    internal interface Autenticavel
    {
        bool Autenticar(string senha);
    }
}
