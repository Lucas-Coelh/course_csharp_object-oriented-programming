using _04_ByteBank_Herdado.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank_Herdado
{
    internal class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        

        public double GetTotalBonificacao()
        {

            return _totalBonificacao;
        }
    }
}
